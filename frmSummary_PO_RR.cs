using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RoyTekProjectSQL
{
    public partial class frmSummary_PO_RR : Form
    {
        long idbranch;
        String Trantype;
        String TranTitle;
        String BranchName;

        int dirtype;
        String dirtitle;

        long iddirectorysearch;

        // main grid
        DataTable DTable;
        SqlDataAdapter DAdapter;
        SqlCommandBuilder DCommandBuilder;
        BindingSource DBindingSource;

        // footer grid
        DataTable FTable;
        SqlDataAdapter FAdapter;
        SqlCommandBuilder FCommandBuilder;
        BindingSource FBindingSource;

        // int idcolumn = 0;

        public frmSummary_PO_RR(long idb, String bname, String ttype, String tTitle)
        {
            InitializeComponent();
            this.idbranch = idb;
            this.BranchName = bname;
            this.Trantype = ttype;
            this.TranTitle = tTitle;

            this.dirtype = Globals.gtypeVendor;
            this.dirtitle = Globals.gtitleVendor;

            this.Text = this.TranTitle + "s " + this.BranchName + " Branch";
            this.SetTheme();

            this.pkrDateto.Value = Globals.glServerDatetime();
            this.pkrDatefrom.Value = Convert.ToDateTime(Globals.glMSSqlYearBeginDate());

        }

        private void frmSummary_PO_RR_Load(object sender, EventArgs e)
        {

            //        
            this.btnRefresh.PerformClick();
        }

        void TestDelay()
        {
            Thread.Sleep(300);
        }

        public void BindGrids()
        {
            // TestDelay();
            BindMainGrid();
            BindFooterGrid();

        }

        public void BindDataSources()
        {
            dgvMain.DataSource = DBindingSource;// DTABLE if fields are bounded;
            dgvFooter.DataSource = FBindingSource;// DTABLE if fields are bounded;
        }
        public void BindMainGrid()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Globals.sqlconn;

                cmd.CommandText = "exec dbo.spSummary_PO_RR_Select " +
                    this.idbranch.ToString() + ", " +
                    Globals.glQoutedSinglestr(this.Trantype) + ", " +
                    Globals.glQoutedSinglestr(Globals.glToMySqlDate(this.pkrDatefrom.Value)) + ", " +
                    Globals.glQoutedSinglestr(Globals.glToMySqlDateMax(this.pkrDateto.Value)) + ", " +
                    Globals.glQoutedSinglestr("%" + this.txtVendor.Text.ToString().ToUpper().Trim() + "%");

                // MessageBox.Show(cmd.CommandText);

                DTable = new DataTable();
                DAdapter = new SqlDataAdapter();
                DCommandBuilder = new SqlCommandBuilder();

                DCommandBuilder.DataAdapter = DAdapter;

                DAdapter.SelectCommand = cmd;
                DAdapter.Fill(DTable);

                DBindingSource = new BindingSource();

                DBindingSource.DataSource = DTable;

                // bindingNavigator1.BindingSource = DBindingSource;

                // dgvMain.DataSource = DBindingSource;// DTABLE if fields are bounded;
            }
            Globals.glCloseSqlConn();
        }

        public void BindFooterGrid()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand fcmd = new SqlCommand();
                fcmd.Connection = Globals.sqlconn;

                fcmd.CommandText = "exec dbo.spSummary_PO_RR_GridFooter " +
                    this.idbranch.ToString() + ", " +
                    Globals.glQoutedSinglestr(this.Trantype) + ", " +
                    Globals.glQoutedSinglestr(Globals.glToMySqlDate(this.pkrDatefrom.Value)) + ", " +
                    Globals.glQoutedSinglestr(Globals.glToMySqlDateMax(this.pkrDateto.Value)) + ", " +
                    Globals.glQoutedSinglestr(this.txtVendor.Text.ToString().ToUpper().Trim() + "%");

                FTable = new DataTable();
                FAdapter = new SqlDataAdapter();
                FCommandBuilder = new SqlCommandBuilder();

                FCommandBuilder.DataAdapter = FAdapter;

                FAdapter.SelectCommand = fcmd;
                FAdapter.Fill(FTable);

                FBindingSource = new BindingSource();

                FBindingSource.DataSource = FTable;

                //dgvFooter.DataSource = FBindingSource;// DTABLE if fields are bounded;
            }
            Globals.glCloseSqlConn();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            using (frmWait frm = new frmWait(BindGrids, "Retrieving Data..."))
            {
                frm.ShowDialog(this);
            }

            bindingNavigator1.BindingSource = DBindingSource;
            dgvMain.DataSource = DBindingSource;
            dgvFooter.DataSource = FBindingSource;

        }

        public void SetTheme()
        {
            this.BackColor = Globals.gDialogBackgroundColor;
            this.pnlTop.BackColor = Globals.gDialogBackgroundColor;
            this.pnlBottom.BackColor = Globals.gDialogBackgroundColor;
            this.bindingNavigator1.BackColor = Globals.gDialogBackgroundColor;

            this.dgvMain.BackgroundColor = Globals.gGridOddRowColor;
            this.dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;
        }


        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    String.Format("{0,8}", (e.RowIndex + 1).ToString()),
                    e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);

            }
        }

        private void FormatRow(DataGridViewRow row)
        {
            String status = row.Cells["cstatus"].Value == DBNull.Value ? ""
                   : row.Cells["cstatus"].Value.ToString().ToUpper();
            row.Cells["cstatus"].Style.ForeColor = Globals.glGetStatusColor(status);

        }
        private void dgvMain_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int firstDisplayedCellIndex = dgvMain.FirstDisplayedCell.RowIndex;
            int lastDisplayedCellIndex = firstDisplayedCellIndex + dgvMain.DisplayedRowCount(true);

            Graphics Graphics = dgvMain.CreateGraphics();
            int measureFirstDisplayed = (int)(Graphics.MeasureString(firstDisplayedCellIndex.ToString(), dgvMain.Font).Width);
            int measureLastDisplayed = (int)(Graphics.MeasureString(lastDisplayedCellIndex.ToString(), dgvMain.Font).Width);

            int rowHeaderWitdh = System.Math.Max(measureFirstDisplayed, measureLastDisplayed);
            dgvMain.RowHeadersWidth = rowHeaderWitdh + 40;

            // FormatRow(dgvMain.Rows[e.RowIndex]);


        }

        private void dgvFooter_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    String.Format("{0,8}", ""),
                    e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvMain_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll && dgvMain.Rows.Count > 0 && dgvFooter.Rows.Count > 0)
            {
                dgvFooter.HorizontalScrollingOffset = dgvMain.HorizontalScrollingOffset;
            }
        }

        private void dgvFooter_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll && dgvFooter.Rows.Count > 0 && dgvMain.Rows.Count > 0)
            {
                dgvMain.HorizontalScrollingOffset = dgvFooter.HorizontalScrollingOffset;
            }

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            long lastid = 0;
            DialogResult rst;

            if (csMessageBox.Show("Create New " + this.TranTitle + "?", "Please confirm.",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String name = "";

                rst = PickDirectory.Show(this.dirtype, this.dirtitle, ref iddirectorysearch, ref name);

                if (rst == DialogResult.OK && Globals.glOpenSqlConn())
                {

                    if (Globals.glOpenSqlConn())
                    {
                        String ccmdstr = "exec dbo.spSummary_PO_RR_CreateNew " +
                            this.idbranch.ToString() + ", " +
                            Globals.glQoutedSinglestr(this.Trantype) + ", " +
                            this.iddirectorysearch.ToString() + ", " +
                            Globals.glQoutedSinglestr(Globals.gLoginName);

                        SqlCommand ccmd = new SqlCommand(ccmdstr, Globals.sqlconn);

                        SqlDataAdapter cadapt = new SqlDataAdapter(ccmd);
                        DataSet cds = new DataSet();
                        cadapt.Fill(cds);

                        if (cds.Tables[0].Rows.Count == 1)
                            lastid = Int64.Parse(cds.Tables[0].Rows[0][0].ToString());
                        else lastid = 0;
                    }
                    Globals.glCloseSqlConn();
                    // csMessageBox.Show("New " + this.TranTitle + " created. "+lastid.ToString(), "Result",
                    //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ccmd.ExecuteNonQuery();

                    this.btnRefresh.PerformClick();
                    this.bindingNavigator1.MoveFirstItem.PerformClick();



                    this.dgvMain.Focus();
                    this.Open_PO_RR(lastid);
                }
            }
        }


        private void dgvFooter_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int firstDisplayedCellIndex = dgvFooter.FirstDisplayedCell.RowIndex;
            int lastDisplayedCellIndex = firstDisplayedCellIndex + dgvFooter.DisplayedRowCount(true);

            Graphics Graphics = dgvMain.CreateGraphics();
            int measureFirstDisplayed = (int)(Graphics.MeasureString(firstDisplayedCellIndex.ToString(), dgvFooter.Font).Width);
            int measureLastDisplayed = (int)(Graphics.MeasureString(lastDisplayedCellIndex.ToString(), dgvFooter.Font).Width);

            int rowHeaderWitdh = System.Math.Max(measureFirstDisplayed, measureLastDisplayed);
            dgvFooter.RowHeadersWidth = rowHeaderWitdh + 40;

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnRefresh.PerformClick();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            long retvalue = 0;
            long docid = 0;

            rs = AskDialog.AskInt("Please type the document no. to retrieve.", 0, ref retvalue);

            if (rs == DialogResult.OK && Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("exec spSUMMARY_PO_RR_RetrieveDoc " +
                   Globals.glQoutedSinglestr(this.Trantype) + ", " +
                   this.idbranch.ToString() + ", " +
                   retvalue.ToString(),
                   Globals.sqlconn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    docid = Int64.Parse(reader[0].ToString());

                }
                else csMessageBox.Show("Document No. " + retvalue.ToString() + " is not found!", "Warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Globals.glCloseSqlConn();

            if (docid != 0) this.Open_PO_RR(docid);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnCreate.PerformClick();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnPrint.PerformClick();
        }

        private void txtVendor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // PUT THE DING OFF
            }
        }

        private void txtVendor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // PUT THE DING OFF

                this.btnRefresh.PerformClick();
                // if (this.GetNextControl(ActiveControl, true) != null)
                // {
                //    this.GetNextControl(ActiveControl, true).Focus();
                // }
            }
        }

        private frmDetail_PO_RR Detail_PO_RRfrm;
        private void Open_PO_RR(long cid)
        {
            // if (Detail_PO_RRfrm == null)
            // {

            Detail_PO_RRfrm = new frmDetail_PO_RR(cid, this.idbranch, this.BranchName,
                this.Trantype, this.TranTitle);
            Detail_PO_RRfrm.MdiParent = this.MdiParent;

            Detail_PO_RRfrm.FormClosed += Detail_PO_RRfrm_FormClosed;

            Detail_PO_RRfrm.Show();
            //}
            //else Detail_PO_RRfrm.Activate();
        }
        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMain.RowCount > 0)
            {
                DataGridViewRow dgr = dgvMain.CurrentRow;
                long id = Int64.Parse(dgr.Cells["cID"].Value.ToString());
                Open_PO_RR(id);

            }

        }

        private void Detail_PO_RRfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Detail_PO_RRfrm = null;
        }

        private void dgvMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow row in dgvMain.Rows)
            {
                String status = row.Cells["cstatus"].Value == DBNull.Value ? ""
                    : row.Cells["cstatus"].Value.ToString().ToUpper();

                Color cl = Globals.glGetStatusColor(status);

                row.Cells["cstatus"].Style.ForeColor = cl;

            }

        }

        private void retrieveDocNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnRetrieve.PerformClick();
        }
    }
}
