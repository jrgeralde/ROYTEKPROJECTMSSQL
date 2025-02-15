using System;
using System.IO;
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
using ExcelDataReader;
using System.Threading;

namespace RoyTekProjectSQL
{
    public partial class frmDirectory : Form
    {
        DataTable DTable;
        SqlDataAdapter DAdapter;
        SqlCommandBuilder DCommandBuilder;
        BindingSource DBindingSource;

        int idcolumn = 0;

        private bool IsChanging;

        int dirtype = Globals.gtypeVendor;  // default type
        String dirtitle = Globals.gtitleVendor;

        //        WorkBook wb;
        //        WorkSheet ws;

        public frmDirectory(int dtype, String dtitle)
        {
            InitializeComponent();
            this.dirtype = dtype;
            this.dirtitle = dtitle;

            this.Text = dtitle + "s";
            switch (this.dirtype)
            {
                case 1:
                    this.StartPosition = FormStartPosition.Manual;
                    this.Left = 50;
                    this.Top = 50;
                    this.btnImport.Visible = true;
                    break;

                case 2:
                    this.StartPosition = FormStartPosition.CenterScreen;
                    this.btnImport.Visible = true;
                    break;

                default:
                    this.StartPosition = FormStartPosition.Manual;
                    this.Left = 200;
                    this.Top = 75;
                    this.btnImport.Visible = false;
                    break;
            }

            SetTheme();
            this.BindMainGrid();
            this.InitializeMainGrid();
            this.dgvMain.Focus();

        }
        public void InitializeMainGrid()
        {
            this.dgvMain.Columns[idcolumn].Visible = false;
            this.dgvMain.Columns[idcolumn].Visible = false;
            this.dgvMain.Columns[idcolumn].ReadOnly = true;
            this.dgvMain.Columns[idcolumn].HeaderText = this.dirtitle + " ID";
            this.dgvMain.Columns[idcolumn].Width = 50;
            this.dgvMain.Columns[idcolumn].Frozen = true;

            this.dgvMain.Columns["name"].HeaderText = this.dirtitle + " Name";
            this.dgvMain.Columns["name"].Width = 350;
            this.dgvMain.Columns["name"].Frozen = true;

            this.dgvMain.Columns["active"].HeaderText = " Active";
            this.dgvMain.Columns["active"].Width = 40;
            this.dgvMain.Columns["active"].Frozen = true;

            this.dgvMain.Columns["nameshort"].HeaderText = "Short Name";

            this.dgvMain.Columns["code"].HeaderText = "   Code";

            this.dgvMain.Columns["contactprefix"].HeaderText = "Contact Prefix";
            this.dgvMain.Columns["contactprefix"].Width = 50;

            this.dgvMain.Columns["contactfirstname"].HeaderText = "Contact First Name";
            this.dgvMain.Columns["contactfirstname"].Width = 150;

            this.dgvMain.Columns["contactmi"].HeaderText = "Contact M.I.";
            this.dgvMain.Columns["contactmi"].Width = 50;

            this.dgvMain.Columns["contactlastname"].HeaderText = "Contact Last Name";
            this.dgvMain.Columns["contactlastname"].Width = 150;


            this.dgvMain.Columns["addressline1"].HeaderText = "Address Line 1";
            this.dgvMain.Columns["addressline1"].Width = 300;
            this.dgvMain.Columns["addressline2"].HeaderText = "Address Line 2";
            this.dgvMain.Columns["addressline2"].Width = 300;
            this.dgvMain.Columns["addressline3"].HeaderText = "Address Line 3";
            this.dgvMain.Columns["addressline3"].Width = 300;
            this.dgvMain.Columns["addressline4"].HeaderText = "Address Line 4";
            this.dgvMain.Columns["addressline4"].Width = 300;
            this.dgvMain.Columns["addressline5"].HeaderText = "Address Line 5";
            this.dgvMain.Columns["addressline5"].Width = 300;


            this.dgvMain.Columns["telno1"].HeaderText = "Main Telephone";
            this.dgvMain.Columns["telno1"].Width = 100;

            this.dgvMain.Columns["telno2"].HeaderText = "Alternate Telephone";
            this.dgvMain.Columns["telno2"].Width = 100;

            this.dgvMain.Columns["faxno"].HeaderText = "Fax No.";
            this.dgvMain.Columns["faxno"].Width = 100;

            this.dgvMain.Columns["email"].HeaderText = "Email Address";
            this.dgvMain.Columns["email"].Width = 250;

        }

        public void PerformBind()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Globals.sqlconn;

                cmd.CommandText = "spGetAllDirectory";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dirtype", this.dirtype);

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
        }
        public void BindMainGrid()
        {
            this.txtSearch.Clear();
            using (frmWait frm = new frmWait(PerformBind, "Loading records..."))
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
            this.dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;

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
            if (this.IsChanging)
                return;

            if (this.dgvMain.CurrentRow != null)
            {
                if (Globals.glOpenSqlConn())
                {

                    DataGridViewRow row = dgvMain.CurrentRow;

                    if (row.Cells["name"].Value == DBNull.Value)
                    {
                        csMessageBox.Show("Please encode a valid " + this.dirtitle + "name", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvMain.CancelEdit();

                    }
                    else
                    {
                        long idval = row.Cells[this.idcolumn].Value == DBNull.Value
                              ? 0 : Convert.ToInt64(row.Cells[this.idcolumn].Value);


                        String name = row.Cells["name"].Value == DBNull.Value ? ""
                            : row.Cells["name"].Value.ToString().ToUpper();
                        name = name.Replace("'", "");

                        int active = row.Cells["active"].Value == DBNull.Value
                             ? 0 : Convert.ToInt32(row.Cells["active"].Value);

                        String nameshort = row.Cells["nameshort"].Value == DBNull.Value ? ""
                            : row.Cells["nameshort"].Value.ToString().ToUpper();
                        String code = row.Cells["code"].Value == DBNull.Value ? ""
                                : row.Cells["code"].Value.ToString().ToUpper();

                        String contactprefix = row.Cells["contactprefix"].Value == DBNull.Value ? ""
                           : row.Cells["contactprefix"].Value.ToString();
                        String contactfirstname = row.Cells["contactfirstname"].Value == DBNull.Value ? ""
                           : row.Cells["contactfirstname"].Value.ToString();
                        String contactmi = row.Cells["contactmi"].Value == DBNull.Value ? ""
                           : row.Cells["contactmi"].Value.ToString();
                        String contactlastname = row.Cells["contactlastname"].Value == DBNull.Value ? ""
                           : row.Cells["contactlastname"].Value.ToString();


                        String addressline1 = row.Cells["addressline1"].Value == DBNull.Value ? ""
                            : row.Cells["addressline1"].Value.ToString();

                        String addressline2 = row.Cells["addressline2"].Value == DBNull.Value ? ""
                            : row.Cells["addressline2"].Value.ToString();
                        String addressline3 = row.Cells["addressline3"].Value == DBNull.Value ? ""
                            : row.Cells["addressline3"].Value.ToString();
                        String addressline4 = row.Cells["addressline4"].Value == DBNull.Value ? ""
                            : row.Cells["addressline4"].Value.ToString();
                        String addressline5 = row.Cells["addressline5"].Value == DBNull.Value ? ""
                            : row.Cells["addressline5"].Value.ToString();

                        String telno1 = row.Cells["telno1"].Value == DBNull.Value ? ""
                            : row.Cells["telno1"].Value.ToString();
                        String telno2 = row.Cells["telno2"].Value == DBNull.Value ? ""
                            : row.Cells["telno2"].Value.ToString();
                        String faxno = row.Cells["faxno"].Value == DBNull.Value ? ""
                            : row.Cells["faxno"].Value.ToString();

                        String email = row.Cells["email"].Value == DBNull.Value ? ""
                            : row.Cells["email"].Value.ToString();

                        try
                        {

                            SqlCommand cmd = new SqlCommand("exec dbo.spDirectoryAddEdit " +
                                "@id=" + idval.ToString() + ", " +
                                "@dirtype=" + dirtype.ToString() + ", " +
                                "@name=" + Globals.glQoutedSinglestr(name) + ", " +
                                "@active=" + active.ToString() + ", " +
                                "@nameshort=" + Globals.glQoutedSinglestr(nameshort) + ", " +
                                "@code=" + Globals.glQoutedSinglestr(code) + ", " +
                                "@contactprefix=" + Globals.glQoutedSinglestr(contactprefix) + ", " +
                                "@contactfirstname=" + Globals.glQoutedSinglestr(contactfirstname) + ", " +
                                "@contactmi=" + Globals.glQoutedSinglestr(contactmi) + ", " +
                                "@contactlastname=" + Globals.glQoutedSinglestr(contactlastname) + ", " +
                                "@addressline1=" + Globals.glQoutedSinglestr(addressline1) + ", " +
                                "@addressline2=" + Globals.glQoutedSinglestr(addressline2) + ", " +
                                "@addressline3=" + Globals.glQoutedSinglestr(addressline3) + ", " +
                                "@addressline4=" + Globals.glQoutedSinglestr(addressline4) + ", " +
                                "@addressline5=" + Globals.glQoutedSinglestr(addressline5) + ", " +
                                "@telno1=" + Globals.glQoutedSinglestr(telno1) + ", " +
                                "@telno2=" + Globals.glQoutedSinglestr(telno2) + ", " +
                                "@faxno=" + Globals.glQoutedSinglestr(faxno) + ", " +
                                "@email=" + Globals.glQoutedSinglestr(email)
                                , Globals.sqlconn);

                            //MessageBox.Show(cmd.CommandText);

                            SqlDataAdapter cadapt = new SqlDataAdapter(cmd);
                            DataSet cds = new DataSet();
                            cadapt.Fill(cds);

                            long lastid = 0;
                            if (cds.Tables[0].Rows.Count == 1)
                                lastid = Int64.Parse(cds.Tables[0].Rows[0][0].ToString());

                            this.IsChanging = true;
                            if (idval == 0)
                                row.Cells[this.idcolumn].Value = lastid;
                            this.IsChanging = false;

                        }
                        catch (Exception ex)
                        {

                            //csMessageBox.Show("Exception Error:" + ex.Message,
                            //   "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            csMessageBox.Show("Duplicate Exists!!!",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.BindMainGrid();
                            this.bindingNavigator1.MoveLastItem.PerformClick();
                        }
                    }

                    Globals.glCloseSqlConn();
                    // this.BindMainGrid();

                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMain.CurrentRow;

            this.IsChanging = true;

            String name = "";
            // if (dgvMain.Rows.Count>0)
            //   name = row.Cells["name"].Value == DBNull.Value ? ""
            //      : row.Cells["name"].Value.ToString().ToUpper();

            this.BindMainGrid();

            this.IsChanging = false;

            //if (name != "") this.SearchName(name);
            //else bindingNavigator1.MoveLastItem.PerformClick();

            this.dgvMain.Focus();

        }

        private bool deleteRow()
        {
            bool cancel = true;

            DataGridViewRow row = this.dgvMain.CurrentRow;
            String rname = row.Cells["name"].Value.ToString().Trim();


            if (row.Cells[idcolumn].Value != DBNull.Value &&
              csMessageBox.Show("Delete the " + this.dirtitle + " " + rname + "?", "Please confirm.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Globals.glOpenSqlConn())
                {

                    SqlCommand cmd = new SqlCommand("spDirectoryDelete", Globals.sqlconn);
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
            int rowIndex = -1;

            searchVal = searchVal.Trim().ToUpper();
            if (searchVal != "")
            {
                this.bindingNavigator1.MoveFirstItem.PerformClick();

                foreach (DataGridViewRow row in dgvMain.Rows)
                {
                    try
                    {
                        if (row.Cells["name"].Value.ToString().StartsWith(searchVal))
                        {
                            rowIndex = row.Index;
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

                if (!resultVal)
                    csMessageBox.Show("Record not found.", "Search Result",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.deleteRow();
        }

        DataTableCollection tCollection;
        DataTable dTable;

        private void ImportRows()
        {
            String cmdstr = "";
            int rc;

            rc = this.dTable.Rows.Count;

            //MessageBox.Show("Imported rows:" + this.dTable.Rows.Count.ToString());
            foreach (DataRow row in dTable.Rows)
            {
                String ActiveStr = row["Active Status"].ToString().Trim();
                int dactive = (ActiveStr == "Active" ? 1 : 0);
                // MessageBox.Show("dactive:" + dactive.ToString());

                String dname = row[this.dirtitle].ToString().ToUpper().Trim();

                dname = dname.Replace("'", "");
                //MessageBox.Show(dirtitle+":" + dname);

                String dcontactprefix = row["Mr./Ms./..."].ToString().Trim();
                dcontactprefix = dcontactprefix.Replace("'", "");
                //MessageBox.Show("contactprefix:" + dcontactprefix);

                String dcontactfirstname = row["First Name"].ToString().Trim();
                dcontactfirstname = dcontactfirstname.Replace("'", "");
                //MessageBox.Show("contactfirstname:" + dcontactfirstname);

                String dcontactmi = row["M.I."].ToString().Trim();
                dcontactmi = dcontactmi.Replace("'", "");
                //MessageBox.Show("contactmi:" + dcontactmi);

                String dcontactlastname = row["Last Name"].ToString().Trim();
                dcontactlastname = dcontactlastname.Replace("'", "");
                //MessageBox.Show("contactlastname:" + dcontactlastname);

                string al1 = (dirtitle == Globals.gtitleVendor ? "Bill from 1" : "Bill to 1");
                String daddressline1 = row[al1].ToString().Trim();
                daddressline1 = daddressline1.Replace("'", "");
                //MessageBox.Show("addressline1:" + daddressline1);

                string al2 = (dirtitle == Globals.gtitleVendor ? "Bill from 2" : "Bill to 2");
                String daddressline2 = row[al2].ToString().Trim();
                daddressline2 = daddressline2.Replace("'", "");
                //MessageBox.Show("addressline2:" + daddressline2);

                string al3 = (dirtitle == Globals.gtitleVendor ? "Bill from 3" : "Bill to 3");
                String daddressline3 = row[al3].ToString().Trim();
                daddressline3 = daddressline3.Replace("'", "");
                //MessageBox.Show("addressline3:" + daddressline3);

                string al4 = (dirtitle == Globals.gtitleVendor ? "Bill from 4" : "Bill to 4");
                String daddressline4 = row[al4].ToString().Trim();
                daddressline4 = daddressline4.Replace("'", "");
                //MessageBox.Show("addressline4:" + daddressline4);

                string al5 = (dirtitle == Globals.gtitleVendor ? "Bill from 5" : "Bill to 5");

                String daddressline5 = row[al5].ToString().Trim();
                daddressline5 = daddressline5.Replace("'", "");
                //MessageBox.Show("addressline5:" + daddressline5);

                String dtelephone1 = row["Main Phone"].ToString().Trim();
                //MessageBox.Show("telno1:" + dtelephone1);
                String dfaxno = row["Fax"].ToString().Trim();
                // MessageBox.Show("faxno:" + dfaxno);
                String dtelephone2 = row["Alt. Phone"].ToString().Trim();
                // MessageBox.Show("telno2:" + dtelephone2);

                cmdstr = "spDirectoryImport " +
                        this.dirtype.ToString() + ", " +
                        Globals.glQoutedSinglestr(dname) + ", " +
                        dactive.ToString() + ", " +
                        Globals.glQoutedSinglestr(dcontactprefix) + ", " +
                        Globals.glQoutedSinglestr(dcontactfirstname) + ", " +
                        Globals.glQoutedSinglestr(dcontactmi) + ", " +
                        Globals.glQoutedSinglestr(dcontactlastname) + ", " +
                        Globals.glQoutedSinglestr(daddressline1) + ", " +
                        Globals.glQoutedSinglestr(daddressline2) + ", " +
                        Globals.glQoutedSinglestr(daddressline3) + ", " +
                        Globals.glQoutedSinglestr(daddressline4) + ", " +
                        Globals.glQoutedSinglestr(daddressline5) + ", " +
                        Globals.glQoutedSinglestr(dtelephone1) + ", " +
                        Globals.glQoutedSinglestr(dtelephone2) + ", " +
                        Globals.glQoutedSinglestr(dfaxno);

                // MessageBox.Show(cmdstr);
                if (Globals.glOpenSqlConn())
                {
                    SqlCommand cmd = new SqlCommand(cmdstr
                        , Globals.sqlconn);

                    //         MessageBox.Show(cmd.CommandText);

                    cmd.ExecuteNonQuery();
                }
                Globals.glCloseSqlConn();

                //MessageBox.Show("Imported rows:" + this.dTable.Rows.Count.ToString());

            }

        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Excel Files|*.xls;*.xlsx";

            if (of.ShowDialog() == DialogResult.OK)
            {
                string fname = of.FileName;

                if (File.Exists(fname) &&
                    csMessageBox.Show("Import data from Excel file",
                      "Please confirm", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (var stream = File.Open(fname, FileMode.Open, FileAccess.Read))
                        {
                            using (IExcelDataReader rdr = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = rdr.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                    { UseHeaderRow = true }
                                });

                                tCollection = result.Tables;

                                dTable = tCollection[0];

                                using (frmWait frm = new frmWait(ImportRows, "Importing Data..."))
                                {
                                    frm.ShowDialog(this);
                                }

                                csMessageBox.Show("Imported " + dTable.Rows.Count.ToString() + " records.", "Result",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.IsChanging = true;
                                this.BindMainGrid();
                                this.IsChanging = false;
                            }
                        }
                    }
                    catch
                    {
                        csMessageBox.Show("File is still open.", "Reminder",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }

        }
    }
}
