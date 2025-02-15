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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RoyTekProjectSQL
{
    public partial class frmDetail_PO_RR : Form
    {
        long idsummary;
        long iddirectory = 0;
        String namedirectory = "";

        long idbranch;
        String branchname;
        String doctype;
        String doctitle;
        String PreviousItemDesc;

        long iditem = 0;
        String itemcode = "";
        String itemdescription = "";
        String itemuom = "";
        float itemlat_cost = 0;
        String itemuompack = "";
        int itempackfactor = 0;

        bool IsChanging = true;

        public frmDetail_PO_RR(long ids, long idb, String bn, String dtype, String dtitle)
        {
            InitializeComponent();
            this.idsummary = ids;
            this.idbranch = idb;
            this.branchname = bn;
            this.doctype = dtype;
            this.doctitle = dtitle;
            this.txtStatus.Text = "";

            this.Text = dtitle + " " + bn + " branch";

            this.label2.Text = doctype + " No.";
            this.label4.Text = doctype + " Date ";

            this.SetTheme();

            this.txtDocumentNo.ReadOnly = true;
            this.dtpTrandate.Enabled = true;

            this.tabControl2.SelectedTab = this.tbItems;
        }

        public void SetTheme()
        {
            this.txtDocumentNo.ForeColor = Color.Blue;
            this.BackColor = Globals.gDialogBackgroundColor;
            this.tabControl1.BackColor = Globals.gDialogBackgroundColor;
            this.tabControl2.BackColor = Globals.gDialogBackgroundColor;

            this.tbEditLogs.BackColor = Globals.gDialogBackgroundColor;

            this.rhbtxtEditLogs.BackColor = this.rhbtxtEditLogs.BackColor;
            this.rhbtxtEditLogs.ForeColor = Globals.gHighlightText;

            this.pnlBottom.BackColor = Globals.gDialogBackgroundColor;
            this.pnlDetail.BackColor = Globals.gDialogBackgroundColor;

            this.tabPage1.BackColor = Globals.gDialogBackgroundColor;
            this.tbItems.BackColor = Globals.gDialogBackgroundColor;

            this.bindingNavigator1.BackColor = Globals.gDialogBackgroundColor;

            this.dgvMain.BackgroundColor = Globals.gGridEvenRowColor;
            this.dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;

            this.dgvFooter.BackgroundColor = Globals.gGridEvenRowColor;
            this.rhbtxtEditLogs.BackColor = Globals.gDialogBackgroundColor;

            this.txtName_SetColor();


        }

        private void frmDetail_PO_RR_Load(object sender, EventArgs e)
        {
            this.txtStatus.Text = "";

            this.BindGrids();
            this.InitializeMainGrid();
            this.SetTheme();
            // this.dgvMain.Focus();
            // this.dgvMain.Rows[0].Cells[0].Selected = true;
            //this.tabControl2.Focus();
            //this.dgvMain.Focus();
            this.txtRemarks.Focus();
        }

        private void InitializeMainGrid()
        {

            this.dgvMain.Columns["id"].Visible = false;
            this.dgvMain.Columns["idimaster"].Visible = false;


            this.dgvMain.Columns["description"].HeaderText = "                                Item Description    ";
            this.dgvMain.Columns["description"].Width = 400;
            this.dgvMain.Columns["description"].DefaultCellStyle.ForeColor = Color.Navy;

            //  this.dgvMain.Columns["description"].DefaultCellStyle.Font
            // = new Font("Segoe UI Semibold", 10,FontStyle.Bold);
            //     = new Font("tahoma", 10, FontStyle.Bold);

            this.dgvMain.Columns["description"].SortMode = DataGridViewColumnSortMode.NotSortable;

            this.dgvFooter.Columns["description"].Width = 408;

            this.dgvMain.Columns["qty"].HeaderText = "Quantity";
            this.dgvMain.Columns["qty"].Width = 80;
            this.dgvFooter.Columns["qty"].Width = 80;
            this.dgvMain.Columns["qty"].DefaultCellStyle.Format = "N2";
            this.dgvMain.Columns["qty"].DefaultCellStyle.Alignment =
                  DataGridViewContentAlignment.MiddleRight;
            this.dgvMain.Columns["qty"].SortMode = DataGridViewColumnSortMode.NotSortable;

            this.dgvMain.Columns["uom"].HeaderText = "Unit";
            this.dgvMain.Columns["uom"].Width = 50;
            this.dgvFooter.Columns["uom"].Width = 50;
            this.dgvMain.Columns["uom"].SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dgvMain.Columns["uom"].ReadOnly = true;

            this.dgvMain.Columns["unitamt"].HeaderText = "      Unit Cost";
            this.dgvMain.Columns["unitamt"].Width = 130;
            this.dgvFooter.Columns["unitamt"].Width = 130;
            this.dgvMain.Columns["unitamt"].DefaultCellStyle.ForeColor = Color.Maroon;
            this.dgvMain.Columns["unitamt"].DefaultCellStyle.Format = "#,##0.000000;(#,##0.000000)";//"N6";
            this.dgvMain.Columns["unitamt"].DefaultCellStyle.Alignment =
                  DataGridViewContentAlignment.MiddleRight;
            this.dgvMain.Columns["unitamt"].SortMode = DataGridViewColumnSortMode.NotSortable;

            this.dgvMain.Columns["totalamt"].HeaderText = "      Total Amount";
            this.dgvMain.Columns["totalamt"].Width = 130;
            this.dgvMain.Columns["totalamt"].DefaultCellStyle.ForeColor = Color.Red;
            this.dgvMain.Columns["totalamt"].DefaultCellStyle.Format = "#,##0.000000;(#,##0.000000)"; // "N6";
            this.dgvMain.Columns["totalamt"].DefaultCellStyle.Alignment =
                  DataGridViewContentAlignment.MiddleRight;


            this.dgvMain.Columns["totalamt"].ReadOnly = true;
            this.dgvMain.Columns["totalamt"].SortMode = DataGridViewColumnSortMode.NotSortable;

            this.dgvFooter.Columns["totalamt"].Width = 130;
            this.dgvFooter.Columns["totalamt"].DefaultCellStyle.Format = "N6";
            this.dgvFooter.Columns["totalamt"].DefaultCellStyle.Alignment =
                  DataGridViewContentAlignment.MiddleRight;

            this.dgvMain.Columns["lat_cost"].Visible = false;

        }
        private void LoadMaster()
        {
            if (Globals.glOpenSqlConn())
            {
                String ccmdstr = "exec dbo.spDetail_PO_RR_Master " +
                           this.idsummary.ToString() + ", " +
                           Globals.glQoutedSinglestr(this.doctype);

                SqlCommand ccmd = new SqlCommand(ccmdstr, Globals.sqlconn);

                SqlDataAdapter cadapt = new SqlDataAdapter(ccmd);
                DataTable cdt = new DataTable();
                cadapt.Fill(cdt);

                DataRow dr = cdt.Rows[0];

                this.iddirectory = Int64.Parse(dr["iddirectory"].ToString());
                txtDocumentNo.Text = dr["documentno"].ToString();
                dtpTrandate.Value = DateTime.Parse(dr["trandate"].ToString());
                txtName.Text = dr["name"].ToString();
                txtReference.Text = dr["reference"].ToString();
                txtRemarks.Text = dr["remarks"].ToString();
                String status = dr["status"].ToString();

                txtStatus.Text = status;

                rhbtxtEditLogs.Text = dr["editlogs"].ToString();
            }
            Globals.glCloseSqlConn();

        }

        private void LoadDetail()
        {
            if (Globals.glOpenSqlConn())
            {
                String ccmdstr = "exec dbo.spDetail_PO_RR_Detail " +
                           this.idsummary.ToString() + ", " +
                           Globals.glQoutedSinglestr(this.doctype);

                SqlCommand ccmd = new SqlCommand(ccmdstr, Globals.sqlconn);

                SqlDataAdapter cadapt = new SqlDataAdapter(ccmd);
                DataTable cdt = new DataTable();
                cadapt.Fill(cdt);

                BindingSource cBindingSource = new BindingSource();

                cBindingSource.DataSource = cdt;

                bindingNavigator1.BindingSource = cBindingSource;

                dgvMain.DataSource = cBindingSource;


            }
            Globals.glCloseSqlConn();

        }
        private void LoadFooter()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand fcmd = new SqlCommand();
                fcmd.Connection = Globals.sqlconn;

                fcmd.CommandText = "exec dbo.spDetail_PO_RR_GridFooter " +
                           this.idsummary.ToString() + ", " +
                           Globals.glQoutedSinglestr(this.doctype);

                DataTable FTable = new DataTable();
                SqlDataAdapter FAdapter = new SqlDataAdapter();
                SqlCommandBuilder FCommandBuilder = new SqlCommandBuilder();


                FCommandBuilder.DataAdapter = FAdapter;

                FAdapter.SelectCommand = fcmd;
                FAdapter.Fill(FTable);

                BindingSource FBindingSource = new BindingSource();

                FBindingSource.DataSource = FTable;

                dgvFooter.DataSource = FBindingSource;

            }
            Globals.glCloseSqlConn();

            // save totals
            DataGridViewRow row = this.dgvFooter.CurrentRow;

            float amount = row.Cells["totalamt"].Value == DBNull.Value
                    ? 0
                    : float.Parse(row.Cells["totalamt"].Value.ToString());

            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("exec dbo.spDetail_PO_RR_SaveFooter " +
                   this.idsummary.ToString() + ", " +
                   Globals.glQoutedSinglestr(this.doctype) + ", " +
                   amount.ToString(),
                   Globals.sqlconn);
                cmd.ExecuteNonQuery();
            }
            Globals.glCloseSqlConn();

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

        private void dgvMain_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int firstDisplayedCellIndex = dgvMain.FirstDisplayedCell.RowIndex;
            int lastDisplayedCellIndex = firstDisplayedCellIndex + dgvMain.DisplayedRowCount(true);

            Graphics Graphics = dgvMain.CreateGraphics();
            int measureFirstDisplayed = (int)(Graphics.MeasureString(firstDisplayedCellIndex.ToString(), dgvMain.Font).Width);
            int measureLastDisplayed = (int)(Graphics.MeasureString(lastDisplayedCellIndex.ToString(), dgvMain.Font).Width);

            int rowHeaderWitdh = System.Math.Max(measureFirstDisplayed, measureLastDisplayed);
            dgvMain.RowHeadersWidth = rowHeaderWitdh + 40;
        }

        private void dgvMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String sval = "";
            DialogResult rst;

            long idval = 0;
            float qty = 0;
            float unitamt = 0;
            float vatpcent = 0, srp1 = 0, srp2 = 0, srp3 = 0, srp4 = 0, srp5 = 0;

            DataGridViewRow row = dgvMain.CurrentRow;
            this.IsChanging = true;

            if (row != null)
            {
                idval = row.Cells["id"].Value == DBNull.Value
                       ? 0 : Convert.ToInt64(row.Cells["id"].Value);

                sval = row.Cells["description"].Value == DBNull.Value
                        ? ""
                        : row.Cells["description"].Value.ToString();
                qty = row.Cells["qty"].Value == DBNull.Value
                        ? 0
                        : float.Parse(row.Cells["qty"].Value.ToString());
                unitamt = row.Cells["unitamt"].Value == DBNull.Value
                        ? 0
                        : float.Parse(row.Cells["unitamt"].Value.ToString());

            }
            if (e.ColumnIndex == 2) //
            {

                if (row != null)
                {

                    if (sval == "")
                    {
                        dgvMain.CancelEdit(); // if blank cancel edit
                    }
                    else if (sval != this.PreviousItemDesc)
                    {
                        // MessageBox.Show(sval);
                        //dr.Cells["description"].Value = this.PreviousItemDesc; //if dialog returns ok
                        // dgvMain.CancelEdit(); // if dialog result is cancel also works with new row
                        int searchby = btnDescription.Checked
                                ? Globals.SearchbyName : Globals.SearchbyCode;

                        rst = PickItem.Show(searchby, "%" + sval.ToUpper().Trim() + "%",
                            ref iditem,
                            ref itemdescription,
                            ref itemcode,
                            ref itemuom,
                            ref itemlat_cost,
                            ref itemuompack,
                            ref itempackfactor,
                            ref vatpcent,
                            ref srp1,
                            ref srp2,
                            ref srp3,
                            ref srp4,
                            ref srp5
                        );

                        if (rst == DialogResult.OK)
                        {
                            //MessageBox.Show("Item Picked:" + itemdescription);
                            row.Cells["idimaster"].Value = iditem;
                            row.Cells["description"].Value = itemdescription;
                            row.Cells["uom"].Value = itemuom;
                            row.Cells["unitamt"].Value = itemlat_cost;

                            RecomputeRow(row);

                            // then call save item;

                            DetailSaveItem(ref idval, iditem, itemlat_cost);
                            row.Cells["id"].Value = idval;

                            // go to the cost column
                            SendKeys.Send("{UP}");
                            SendKeys.Send("{RIGHT}");
                            // SendKeys.Send("{RIGHT}");

                        }
                        else
                        {
                            // MessageBox.Show("Item pick is cancelled.");

                            if (idval == 0)
                            {
                                dgvMain.CancelEdit();
                            }
                            else
                            {
                                row.Cells["description"].Value = this.PreviousItemDesc;
                            }
                        }
                    }
                }

            }

            if (e.ColumnIndex == 3) // qty column
            {
                DetailSaveRecord(idval, qty, unitamt);
                RecomputeRow(row);
                // go to the cost column
                SendKeys.Send("{UP}");
                SendKeys.Send("{RIGHT}");
                SendKeys.Send("{RIGHT}");
            }

            if (e.ColumnIndex == 5) // unit amt column LAST COLUMN DO NOT HANDLE NAVIGATION!!!!
            {
                DetailSaveRecord(idval, qty, unitamt);
                RecomputeRow(row);
                // go to description column
                SendKeys.Send("{LEFT}");
                SendKeys.Send("{LEFT}");
                SendKeys.Send("{LEFT}");
            }

            this.IsChanging = false;

        }

        private void DetailSaveItem(ref long nidval, long nidimaster, float nunitamt)
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("exec dbo.spDetail_PO_RR_ChangeItem " +
                  nidval.ToString() + ", " +
                  Globals.glQoutedSinglestr(this.doctype) + ", " +
                  nidimaster.ToString() + ", " +
                  this.idsummary.ToString() + ", " +
                  nunitamt.ToString()
                 , Globals.sqlconn);

                SqlDataAdapter cadapt = new SqlDataAdapter(cmd);
                DataSet cds = new DataSet();
                cadapt.Fill(cds);

                nidval = 0;
                if (cds.Tables[0].Rows.Count == 1)
                    nidval = Int64.Parse(cds.Tables[0].Rows[0][0].ToString());
            }
            Globals.glCloseSqlConn();
        }

        private void DetailSaveRecord(long nidval, float nqty, float nunitamt)
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("exec dbo.spDetail_PO_RR_SaveRecord " +
                              nidval.ToString() + ", " +
                              Globals.glQoutedSinglestr(this.doctype) + ", " +
                              nqty.ToString() + ", " +
                              nunitamt.ToString()
                             , Globals.sqlconn);

                cmd.ExecuteNonQuery();
            }
            Globals.glCloseSqlConn();
            this.LoadFooter();
        }

        private void SaveMaster()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand("exec dbo.spDetail_PO_RR_SaveMaster " +
                              this.idsummary.ToString() + ", " +
                              Globals.glQoutedSinglestr(this.doctype) + ", " +
                              this.iddirectory.ToString() + ", " +
                              Globals.glQoutedSinglestr(this.txtDocumentNo.Text) + ", " +
                              Globals.glQoutedSinglestr(Globals.glToMySqlDateTime(this.dtpTrandate.Value)) + ", " +
                              Globals.glQoutedSinglestr(this.txtReference.Text) + ", " +
                              Globals.glQoutedSinglestr(this.txtRemarks.Text)
                             , Globals.sqlconn);

                cmd.ExecuteNonQuery();
            }
            Globals.glCloseSqlConn();
        }
        private void RecomputeRow(DataGridViewRow row)
        {
            float nqty = row.Cells["qty"].Value == DBNull.Value
                    ? 0
                    : float.Parse(row.Cells["qty"].Value.ToString());
            float nunitamt = row.Cells["unitamt"].Value == DBNull.Value
                    ? 0
                    : float.Parse(row.Cells["unitamt"].Value.ToString());

            row.Cells["totalamt"].Value = nqty * nunitamt;

        }
        private void dgvMain_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvMain.RowCount == 0)
            {
                this.PreviousItemDesc = "";
                this.dgvMain.CancelEdit();
                this.tabControl2.Focus();


                return;
            }

            if (e.ColumnIndex == 2)
            {
                this.bindingNavigator1.BindingSource.CurrencyManager.Refresh(); // do not delete!!!!
                DataGridViewRow dr = dgvMain.CurrentRow;

                if (dr != null)
                {
                    // this.PreviousItemDesc = "test";

                    try
                    {
                        this.PreviousItemDesc = (dr.Cells["description"].Value == DBNull.Value
                               ? ""
                               : dr.Cells["description"].Value.ToString());
                    }
                    catch (Exception ex)
                    {

                        this.PreviousItemDesc = "";
                    }

                }

            }
        }

        private void dgvMain_CancelRowEdit(object sender, QuestionEventArgs e)
        {
            //
        }


        private void dgvMain_KeyDown(object sender, KeyEventArgs e)
        {    /********** NEVER PUT THIS IN _KeyUP ********/

            /*** NOTE: THESE ARE NON EDITING KEYS - KEYS PRESSED ON THE GRID NOT ON THE CELL ***/
            if (dgvMain.CurrentCell == null) return;
            int ci = dgvMain.CurrentCell.ColumnIndex;


            if (e.KeyCode == Keys.Enter)
            {
                if (ci == 2)  // description column
                {
                    // go to the qty column
                    SendKeys.Send("{UP}");
                    SendKeys.Send("{RIGHT}");
                    //  SendKeys.Send("{RIGHT}");
                }

                if (ci == 3)  // qty column
                {
                    // go to the unit amount column
                    SendKeys.Send("{UP}");
                    SendKeys.Send("{RIGHT}");
                    SendKeys.Send("{RIGHT}");
                }

                if (ci == 5) // unit amt column
                {
                    // go to the description column
                    SendKeys.Send("{LEFT}");
                    SendKeys.Send("{LEFT}");
                    SendKeys.Send("{LEFT}");

                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.DetailDeleteRow();
        }
        private void DetailDeleteRow()
        {
            DataGridViewRow row = dgvMain.CurrentRow;
            String desc = row.Cells["description"].Value == null
                  ? "" : row.Cells["description"].Value.ToString().Trim();


            if (row != null && desc != "" && csMessageBox.Show("Delete " + desc + "?", "Please confirm.",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                long idval = row.Cells["id"].Value == DBNull.Value

                  ? 0 : Convert.ToInt64(row.Cells["id"].Value);
                if (Globals.glOpenSqlConn())
                {

                    SqlCommand cmd = new SqlCommand("exec dbo.spDetail_PO_RR_DeleteItem " +
                        idval.ToString() + ", " +
                        Globals.glQoutedSinglestr(this.doctype),
                        Globals.sqlconn);
                    cmd.ExecuteNonQuery();

                }

                Globals.glCloseSqlConn();
                try
                {
                    dgvMain.Rows.Remove(row);
                }
                catch (Exception ex)
                {
                    csMessageBox.Show("Unsaved rows cannot be deleted.", "Reminder",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.LoadFooter();
            }

        }

        private void dgvMain_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            this.DetailDeleteRow();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DetailDeleteRow();
        }

        private void btnSearchDir_Click(object sender, EventArgs e)
        {
            DialogResult rst;
            long nid = 0;
            String nname = "";

            rst = PickDirectory.Show(Globals.gtypeVendor, Globals.gtitleVendor,
                ref nid, ref nname);

            if (rst == DialogResult.OK)
            {
                this.iddirectory = nid;
                this.namedirectory = nname;

                this.txtName.Text = nname;

                this.SaveMaster();

                this.txtReference.Focus();

            }


        }

        private void ChangeNameMenuItem_Click(object sender, EventArgs e)
        {
            btnSearchDir.PerformClick();

        }


        private void txtRemarks_Leave(object sender, EventArgs e)
        {
            this.SaveMaster();
        }

        void TestDelay()
        {
            Thread.Sleep(200);
        }

        private void BindGrids()
        {
            this.LoadMaster();
            this.LoadDetail();
            this.LoadFooter();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.BindGrids();
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

        private void searchByDescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnDescription.Checked = true;
        }

        private void searchByCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnCode.Checked = true;
        }

        // set colors of read only boxes
        private void txtName_SetColor()
        {
            this.txtName.BackColor = this.txtName.BackColor;
            this.txtName.ForeColor = Globals.gHighlightText;
        }

        private void txtStatus_SetColor()
        {
            String status = txtStatus.Text;

            Color cl = Globals.glGetStatusColor(status);

            txtStatus.BackColor = txtStatus.BackColor;
            txtStatus.ForeColor = cl;

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {
            txtStatus_SetColor();

        }

        private String SampleQtyBalance(String idimaster)
        {
            long itemid = long.Parse(idimaster);
            double qtybal = 0;

            switch (itemid)
            {
                case 1:
                    qtybal = 10;
                    break;
                case 2:
                    qtybal = 3.2;
                    break;
                case 5:
                    qtybal = 6.5;
                    break;
                case 7:
                    qtybal = 10.5;
                    break;
                case 8:
                    qtybal = 5.5;
                    break;
                case 16:
                    qtybal = 3.8;
                    break;
                default:
                    qtybal = 1;
                    break;


            }

            return "Onhand Balance:" + qtybal.ToString("N2");


        }
        private void dgvMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvMain.Columns["description"].Index)
            {
                var cell = dgvMain.Rows[e.RowIndex].Cells[e.ColumnIndex];
                // Set the Cell's ToolTipText.  In this case we're retrieving the value stored in 
                // another cell in the same row (see my note below).
                cell.ToolTipText = dgvMain.Rows[e.RowIndex].Cells["idimaster"].Value == null
                                 ? "" : SampleQtyBalance(dgvMain.Rows[e.RowIndex].Cells["idimaster"].Value.ToString());
            }
        }

        private void dgvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            String msg = "Data format error.";
            csMessageBox.Show(msg, "Warning.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
