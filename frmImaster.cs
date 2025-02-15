using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyTekProjectSQL
{
    public partial class frmImaster : Form
    {
        DataTable DTable;
        SqlDataAdapter DAdapter;
        SqlCommandBuilder DCommandBuilder;
        BindingSource DBindingSource;
        // DataGridViewComboBoxColumn cbxItemClass;

        int idcolumn = 0;

        int activevalue = 1;

        private bool IsChanging = true;
        private bool SuspendAllCellUpdates = true;
        public frmImaster(int act)
        {
            InitializeComponent();
            // this.SuspendAllCellUpdates = false;
            // this.IsChanging = false;
            //this.IsAccessible = false;
            this.activevalue = act;

            if (act == 1)
            {
                this.StartPosition = FormStartPosition.CenterScreen;

            }

            SetTheme();

        }
        private void frmImaster_Load(object sender, EventArgs e)
        {
            if (this.activevalue == 1)
                this.Text = "Master List of ACTIVE Items";
            else
                this.Text = "Master List of INACTIVE Items";

            this.Populatecbxclass();
            this.Populatecbxitemgroup();

            this.BindMainGrid();

            this.InitializeMainGrid();

            this.dgvMain.Focus();
            this.SuspendAllCellUpdates = false;
            this.IsChanging = false;
        }

        public void InitializeMainGrid()
        {

            this.dgvMain.Columns[this.idcolumn].Visible = false;

            this.dgvMain.Columns["description"].HeaderText = "                                Item Description    ";
            this.dgvMain.Columns["description"].Width = 400;


            this.dgvMain.Columns["active"].HeaderText = " Active";
            this.dgvMain.Columns["active"].Width = 40;

            this.dgvMain.Columns["code"].HeaderText = "    Item Code";
            this.dgvMain.Columns["code"].Width = 100;

            this.dgvMain.Columns["uom"].HeaderText = "Unit";
            this.dgvMain.Columns["uom"].Width = 50;

            //this.dgvMain.Columns["iditemclass"].HeaderText = "                 Item Classification";
            //this.dgvMain.Columns["iditemclass"].Width = 100;
            //this.dgvMain.Columns["iditemclass"].CellType = DataGridViewComboBoxColumn;
            this.dgvMain.ShowCellToolTips = false;


            this.dgvMain.Columns["uompack"].HeaderText = "Packaged Unit";
            this.dgvMain.Columns["uompack"].Width = 60;

            this.dgvMain.Columns["packfactor"].HeaderText = "Pckg Factor";
            this.dgvMain.Columns["packfactor"].Width = 50;
            this.dgvMain.Columns["packfactor"].DefaultCellStyle.Format = "N2";

            this.dgvMain.Columns["vatpercent"].HeaderText = "VAT Percent";
            this.dgvMain.Columns["vatpercent"].Width = 50;
            this.dgvMain.Columns["vatpercent"].DefaultCellStyle.Format = "N2";

            this.dgvMain.Columns["packfactor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
        }

        public void PerformBind()
        {
            this.SuspendAllCellUpdates = true;

            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Globals.sqlconn;

                cmd.CommandText = "spGetAllImaster";
                cmd.CommandType = CommandType.StoredProcedure;

                String likedesc = this.txtdescription.Text.Trim() + "%";
                String likegroup = this.txtGroup.Text.Trim() + "%";
                String likeclass = this.txtClassification.Text.Trim() + "%";

                cmd.Parameters.AddWithValue("@active", this.activevalue);

                cmd.Parameters.AddWithValue("@likedesc", likedesc);
                cmd.Parameters.AddWithValue("@likegroup", likegroup);
                cmd.Parameters.AddWithValue("@likeclass", likeclass);

                DTable = new DataTable();
                DAdapter = new SqlDataAdapter();
                DCommandBuilder = new SqlCommandBuilder();

                DCommandBuilder.DataAdapter = DAdapter;

                DAdapter.SelectCommand = cmd;
                DAdapter.Fill(DTable);

                DBindingSource = new BindingSource();

                DBindingSource.DataSource = DTable;
            }
            Globals.glCloseSqlConn();

            this.SuspendAllCellUpdates = false;
        }
        public void BindMainGrid()
        {

            using (frmWait frm = new frmWait(PerformBind, "Loading items..."))
            {
                frm.ShowDialog(this);
            }

            bindingNavigator1.BindingSource = DBindingSource;
            dgvMain.DataSource = DBindingSource;// DTABLE if fields are bounded;

        }

        public void SetTheme()
        {
            this.BackColor = Globals.gDialogBackgroundColor;

            this.dgvMain.BackgroundColor = Globals.gGridOddRowColor;
            if (this.activevalue == 1)
                this.dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;
            else
                this.dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor2;

            this.dgvMain.EnableHeadersVisualStyles = false;
            if (this.activevalue == 1)
                this.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;
            else
                this.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor2;

        }
        public void Populatecbxclass()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlDataAdapter sqlda = new SqlDataAdapter(
                   "select id,name from itemclasses " +
                    "where isnull(active,0)<>0 order by name", Globals.sqlconn);

                DataTable xTable = new DataTable();

                sqlda.Fill(xTable);

                this.cbxItemClass.ValueMember = "id";
                this.cbxItemClass.DisplayMember = "name";
                this.cbxItemClass.DataSource = xTable;
            }
            Globals.glCloseSqlConn();
        }

        public void Populatecbxitemgroup()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlDataAdapter sqlda = new SqlDataAdapter(
                   "select id,name from item_groups " +
                    "order by name", Globals.sqlconn);

                DataTable xTable = new DataTable();

                sqlda.Fill(xTable);

                this.cbxitemgroup.ValueMember = "id";
                this.cbxitemgroup.DisplayMember = "name";
                this.cbxitemgroup.DataSource = xTable;
            }
            Globals.glCloseSqlConn();
        }

        private void tsbtnSave_Click(object sender, EventArgs e)
        {
            // use the following if you are using a Binding Source 
            // attach this to a save button
            // DataTable changes = ((DataTable)dgvMain.DataSource).GetChanges();

            // if (changes!=null)
            // {
            //    DAdapter.Update(DTable);
            //}
        }
        private void dgvMain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            if (this.SuspendAllCellUpdates || this.IsChanging)
                return;

            if (this.dgvMain.CurrentRow != null)
            {
                if (Globals.glOpenSqlConn())
                {

                    DataGridViewRow row = dgvMain.CurrentRow;

                    String description = row.Cells["description"].Value == DBNull.Value ? ""
                        : row.Cells["description"].Value.ToString().ToUpper();

                    if (row.Cells["description"].Value == DBNull.Value)
                    {
                        csMessageBox.Show("Please encode a valid item description.", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvMain.CancelEdit();

                    }
                    else
                    {
                        try
                        {
                            int active = row.Cells["active"].Value == DBNull.Value
                              ? 0 : Convert.ToInt32(row.Cells["active"].Value);
                            String code = row.Cells["code"].Value == DBNull.Value ? ""
                              : row.Cells["code"].Value.ToString().ToUpper();
                            String uom = row.Cells["uom"].Value == DBNull.Value ? ""
                               : row.Cells["uom"].Value.ToString().ToUpper();

                            long iditemgroup = row.Cells["iditemgroup"].Value == DBNull.Value
                                        ? 0 : Convert.ToInt64(row.Cells["iditemgroup"].Value);
                            long iditemclass = row.Cells["iditemclass"].Value == DBNull.Value
                                 ? 0 : Convert.ToInt64(row.Cells["iditemclass"].Value);
                            String uompack = row.Cells["uompack"].Value == DBNull.Value ? ""
                                : row.Cells["uompack"].Value.ToString().ToUpper();
                            int packfactor = row.Cells["packfactor"].Value == DBNull.Value
                                 ? 0 : Convert.ToInt32(row.Cells["packfactor"].Value);
                            double branch_srp1 = row.Cells["branch_srp1"].Value == DBNull.Value
                                 ? 0 : Convert.ToDouble(row.Cells["branch_srp1"].Value);

                            double branch_srp2 = row.Cells["branch_srp2"].Value == DBNull.Value
                                    ? 0 : Convert.ToDouble(row.Cells["branch_srp2"].Value);
                            double branch_srp3 = row.Cells["branch_srp3"].Value == DBNull.Value
                                    ? 0 : Convert.ToDouble(row.Cells["branch_srp3"].Value);
                            double branch_srp4 = row.Cells["branch_srp4"].Value == DBNull.Value
                                    ? 0 : Convert.ToDouble(row.Cells["branch_srp4"].Value);
                            double branch_srp5 = row.Cells["branch_srp5"].Value == DBNull.Value
                                    ? 0 : Convert.ToDouble(row.Cells["branch_srp5"].Value);


                            long idval = row.Cells[this.idcolumn].Value == DBNull.Value
                               ? 0 : Convert.ToInt64(row.Cells["id"].Value);

                            if (idval == 0) active = this.activevalue;

                            SqlCommand cmd = new SqlCommand("exec dbo.spImasterAddEdit " +
                                idval.ToString() + ", " +
                                active.ToString() + ", " +
                                Globals.glQoutedSinglestr(description) + ", " +
                                Globals.glQoutedSinglestr(code) + ", " +
                                Globals.glQoutedSinglestr(uom) + ", " +
                                iditemgroup.ToString() + ", " +
                                iditemclass.ToString() + ", " +
                                Globals.glQoutedSinglestr(uompack) + ", " +
                                packfactor.ToString() + ", " +
                                branch_srp1.ToString() + ", " +
                                branch_srp2.ToString() + ", " +
                                branch_srp3.ToString() + ", " +
                                branch_srp4.ToString() + ", " +
                                branch_srp5.ToString(),
                                Globals.sqlconn);

                            //MessageBox.Show(cmd.CommandText);

                            SqlDataAdapter cadapt = new SqlDataAdapter(cmd);
                            DataSet cds = new DataSet();
                            cadapt.Fill(cds);

                            long lastid = 0;
                            if (cds.Tables[0].Rows.Count == 1)
                                lastid = Int64.Parse(cds.Tables[0].Rows[0][0].ToString());

                            this.IsChanging = true;
                            if (idval == 0)
                            {
                                row.Cells[this.idcolumn].Value = lastid;
                                row.Cells["active"].Value = active;
                            }
                            this.IsChanging = false;

                            //if (idval == 0)
                            //    this.SearchName(description);

                        }
                        catch (Exception ex)
                        {

                            //MessageBox.Show("Exception Error:" + ex.Message);
                            csMessageBox.Show("Duplicate Exists!!!",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.BindMainGrid();
                            this.bindingNavigator1.MoveLastItem.PerformClick();
                        }
                    }

                    Globals.glCloseSqlConn();

                    //this.BindMainGrid();

                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvMain.CurrentRow;

            String name = row.Cells["description"].Value == DBNull.Value ? ""
                 : row.Cells["description"].Value.ToString().ToUpper();

            this.BindMainGrid();

            // if (name != "") this.SearchName(name);
            // else bindingNavigator1.MoveLastItem.PerformClick();

            this.dgvMain.Focus();
        }

        private bool deleteRow()
        {
            bool cancel = true;

            DataGridViewRow row = this.dgvMain.CurrentRow;
            String rname = row.Cells["description"].Value.ToString().Trim();


            if (row.Cells[idcolumn].Value != DBNull.Value &&
              csMessageBox.Show("Delete the item" + rname, "Please confirm.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Globals.glOpenSqlConn())
                {

                    SqlCommand cmd = new SqlCommand("spImasterDelete", Globals.sqlconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt64(row.Cells[idcolumn].Value));
                    cmd.ExecuteNonQuery();

                    cancel = false;

                }

                Globals.glCloseSqlConn();
                this.dgvMain.Rows.RemoveAt(row.Index);

            }

            return cancel;
        }
        private void dgvMain_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = deleteRow();
        }

        private Boolean SearchName(String searchVal)
        {
            bool resultVal = false;

            searchVal = searchVal.Trim().ToUpper();
            if (searchVal != "")
            {
                this.bindingNavigator1.MoveFirstItem.PerformClick();

                foreach (DataGridViewRow row in dgvMain.Rows)
                {
                    try
                    {
                        if (row.Cells["description"].Value.ToString().StartsWith(searchVal))
                        {
                            dgvMain.Rows[row.Index].Selected = true;
                            resultVal = true;
                            break;
                        }
                        this.bindingNavigator1.MoveNextItem.PerformClick();
                    }
                    catch
                    {
                        break;
                    }
                } // foreach
                  // if (!resultVal)
                  //   csMessageBox.Show("Record not found.", "Search Result",
                  //    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } // if
            return resultVal;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String searchVal = txtSearch.Text.Trim().ToUpper();

            if (this.SearchName(searchVal))
            {
                this.txtSearch.Clear();
                this.dgvMain.Focus();

            }
            else
            {
                csMessageBox.Show("Record not found.", "Search Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtSearch.Focus();
            }

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                this.btnSearch.PerformClick(); //Select();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.txtSearch.Clear();
                this.dgvMain.Focus();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtSearch.Focus();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.btnRefresh.PerformClick();
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

        private void txtdescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    e.SuppressKeyPress = true; // PUT THE DING OFF
                    this.GetNextControl(ActiveControl, true).Focus();
                }
            }
        }

        private void txtClassification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // PUT THE DING OFF
                this.btnRefresh.PerformClick();
            }
        }

        private void txtClassification_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // PUT THE DING OFF

            }
        }

        private void txtClassification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;


            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.deleteRow();
        }
    }
}
