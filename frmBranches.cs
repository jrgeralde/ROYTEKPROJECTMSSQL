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
    public partial class frmBranches : Form
    {
        DataTable DTable;
        SqlDataAdapter DAdapter;
        SqlCommandBuilder DCommandBuilder;
        BindingSource DBindingSource;

        private bool IsChanging=true;

        int idcolumn = 0;
        bool allowinsertion=false;
        bool allowdeletion = false;

        public frmBranches()
        {
            InitializeComponent();
           
            SetTheme();
            this.PopulatecbxPriceCategory();
            this.PopulatecbxBranchType();
            this.BindMainGrid();
            this.InitializeMainGrid();
            this.dgvMain.Focus();
            
        }
        public void InitializeMainGrid()
        {
            this.dgvMain.Columns[idcolumn].Visible = false;
     
            this.dgvMain.Columns[idcolumn].ReadOnly = true;
            this.dgvMain.Columns[idcolumn].HeaderText = "Branch ID";
            this.dgvMain.Columns[idcolumn].Width = 50;

            this.dgvMain.Columns["name"].HeaderText = "Branch Name";
           
            this.dgvMain.Columns["active"].HeaderText = " Active";
            this.dgvMain.Columns["active"].Width = 40;

            //this.dgvMain.Columns["idpricecategory"].HeaderText = "Price Category";
            //this.dgvMain.Columns["idpricecategory"].Width = 90;

            this.dgvMain.Columns["address"].HeaderText = "                            Address";
            this.dgvMain.Columns["address"].Width = 300;

            this.dgvMain.Columns["requestno"].HeaderText = " Next Requisition No";
            this.dgvMain.Columns["requestno"].Width = 70;
            this.dgvMain.Columns["requestno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgvMain.Columns["requestno"].DefaultCellStyle.Format = "N0";

            this.dgvMain.Columns["orderingno"].HeaderText = " Next PO No";
            this.dgvMain.Columns["orderingno"].Width = 40;
            this.dgvMain.Columns["orderingno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgvMain.Columns["orderingno"].DefaultCellStyle.Format = "N0";

            this.dgvMain.Columns["receivingno"].HeaderText = " Next RR No";
            this.dgvMain.Columns["receivingno"].Width = 40;
            this.dgvMain.Columns["receivingno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgvMain.Columns["receivingno"].DefaultCellStyle.Format = "N0";

            this.dgvMain.Columns["issuanceno"].HeaderText = " Next Issuance No";
            this.dgvMain.Columns["issuanceno"].Width = 70;
            this.dgvMain.Columns["issuanceno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgvMain.Columns["issuanceno"].DefaultCellStyle.Format = "N0";

            this.dgvMain.Columns["adjustmentno"].HeaderText = " Next Adjustment No";
            this.dgvMain.Columns["adjustmentno"].Width = 70;
            this.dgvMain.Columns["adjustmentno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgvMain.Columns["adjustmentno"].DefaultCellStyle.Format = "N0";

            this.dgvMain.Columns["purchasereturnno"].HeaderText = " Next Purchase Return No";
            this.dgvMain.Columns["purchasereturnno"].Width = 70;
            this.dgvMain.Columns["purchasereturnno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgvMain.Columns["purchasereturnno"].DefaultCellStyle.Format = "N0";

            this.dgvMain.Columns["cashinvoiceno"].HeaderText = " Next Cash Invoice No";
            this.dgvMain.Columns["cashinvoiceno"].Width = 70;
            this.dgvMain.Columns["cashinvoiceno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgvMain.Columns["cashinvoiceno"].DefaultCellStyle.Format = "N0";

            this.dgvMain.Columns["chargeinvoiceno"].HeaderText = " Next Cash Invoice No";
            this.dgvMain.Columns["chargeinvoiceno"].Width = 70;
            this.dgvMain.Columns["chargeinvoiceno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgvMain.Columns["chargeinvoiceno"].DefaultCellStyle.Format = "N0";

            this.dgvMain.Columns["stocktransferinno"].HeaderText = " Next Stock Transfer In No";
            this.dgvMain.Columns["stocktransferinno"].Width = 70;
            this.dgvMain.Columns["stocktransferinno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgvMain.Columns["stocktransferinno"].DefaultCellStyle.Format = "N0";
            
            this.dgvMain.Columns["stocktransferoutno"].HeaderText = " Next Stock Transfer Out No";
            this.dgvMain.Columns["stocktransferoutno"].Width = 70;
            this.dgvMain.Columns["stocktransferoutno"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgvMain.Columns["stocktransferoutno"].DefaultCellStyle.Format = "N0";

            String[] RolestoUse = new String[] { "PROGADMIN" };

            if (Globals.gCheckUserRole(Globals.gIdUser, ref RolestoUse))
            {
                allowinsertion = true;
                allowdeletion = true;

                this.dgvMain.Columns["name"].ReadOnly = false;
              
            } else
            {
                allowinsertion = false;
                allowdeletion = false;

                this.dgvMain.Columns["name"].ReadOnly = true;

            }

            this.dgvMain.AllowUserToAddRows = allowinsertion;
            this.dgvMain.AllowUserToDeleteRows = allowdeletion;
        }

        public void PopulatecbxPriceCategory()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlDataAdapter sqlda = new SqlDataAdapter(
                   "select id,name from dbo.BranchPriceCategories " +
                    "order by name", Globals.sqlconn);

                DataTable xTable = new DataTable();

                sqlda.Fill(xTable);

                this.cbxPriceCategory.ValueMember = "id";
                this.cbxPriceCategory.DisplayMember = "name";

                DataRow topItem = xTable.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                xTable.Rows.InsertAt(topItem, 0);

                this.cbxPriceCategory.DataSource = xTable;
            }
            Globals.glCloseSqlConn();
        }

        public void PopulatecbxBranchType()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlDataAdapter sqlda = new SqlDataAdapter(
                   "select id,name from BranchTypes " +
                    "order by name", Globals.sqlconn);

                DataTable xTable = new DataTable();

                sqlda.Fill(xTable);

                this.cbxbranchtype.ValueMember = "id";
                this.cbxbranchtype.DisplayMember = "name";

                DataRow topItem = xTable.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                xTable.Rows.InsertAt(topItem, 0);

                this.cbxbranchtype.DataSource = xTable;
            }
            Globals.glCloseSqlConn();
        }

        public void BindMainGrid()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Globals.sqlconn;

                cmd.CommandText = "spGetAllBranches";
                cmd.CommandType = CommandType.StoredProcedure;

                DTable = new DataTable();
                DAdapter = new SqlDataAdapter();
                DCommandBuilder = new SqlCommandBuilder();

                DCommandBuilder.DataAdapter = DAdapter;

                this.IsChanging = true;
                DAdapter.SelectCommand = cmd;
                DAdapter.Fill(DTable);
                this.IsChanging = false;

                DBindingSource = new BindingSource();

                DBindingSource.DataSource = DTable;
          
                bindingNavigator1.BindingSource = DBindingSource;

                dgvMain.DataSource = DBindingSource;// DTABLE if fields are bounded;
            }
            Globals.glCloseSqlConn();
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

            if (this.dgvMain.CurrentRow!=null)
            {
                if (Globals.glOpenSqlConn())
                {

                    DataGridViewRow row = dgvMain.CurrentRow;
                   
                    if (row.Cells["name"].Value == DBNull.Value)
                    {
                        csMessageBox.Show("Please encode a valid branch name", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvMain.CancelEdit();
                        
                    } else
                    {
                        try
                        {

                            long idval = row.Cells[this.idcolumn].Value == DBNull.Value
                                  ? 0 : Convert.ToInt64(row.Cells[idcolumn].Value);

                            String act = (row.Cells["active"].Value == DBNull.Value
                                   ? "false" : row.Cells["active"].Value.ToString());
                            int actval = (act == "false" ? 0 : 1);

                            String pc = (row.Cells["idpricecategory"].Value == DBNull.Value
                                   ? "1" : row.Cells["idpricecategory"].Value.ToString());
                            int pcval = int.Parse(pc);

                            String bt = (row.Cells["idbranchtype"].Value == DBNull.Value
                                  ? "1" : row.Cells["idbranchtype"].Value.ToString());
                            int btval = int.Parse(bt);

                            String cmdstr = "exec spBranchesAddEdit " +
                                "@id =" + (row.Cells[this.idcolumn].Value == DBNull.Value
                                   ? "0" : row.Cells[this.idcolumn].Value.ToString()) + ", " +
                                "@name =" + (row.Cells["name"].Value == DBNull.Value
                                   ? Globals.glQoutedSinglestr("")
                                   :Globals.glQoutedSinglestr(row.Cells["name"].Value.ToString().ToUpper())) + ", " +
                                "@active =" +actval.ToString()+ ", " +
                                "@idbranchtype =" + btval.ToString() + ", " +
                                "@idpricecategory =" + pcval.ToString() + ", " +
                                "@address =" + (row.Cells["address"].Value == DBNull.Value
                                   ? Globals.glQoutedSinglestr("")
                                   : Globals.glQoutedSinglestr(row.Cells["address"].Value.ToString().ToUpper())) + ", " +
                                "@requestno =" + (row.Cells["requestno"].Value == DBNull.Value
                                   ? "0" : row.Cells["requestno"].Value.ToString()) + ", " +
                                "@orderingno =" + (row.Cells["orderingno"].Value == DBNull.Value
                                   ? "0" : row.Cells["orderingno"].Value.ToString()) + ", " +
                                "@receivingno =" + (row.Cells["receivingno"].Value == DBNull.Value
                                   ? "0" : row.Cells["receivingno"].Value.ToString()) + ", " +
                                "@issuanceno =" + (row.Cells["issuanceno"].Value == DBNull.Value
                                   ? "0" : row.Cells["issuanceno"].Value.ToString()) + ", " +
                                "@adjustmentno =" + (row.Cells["adjustmentno"].Value == DBNull.Value
                                   ? "0" : row.Cells["adjustmentno"].Value.ToString()) + ", " +
                                "@purchasereturnno =" + (row.Cells["purchasereturnno"].Value == DBNull.Value
                                   ? "0" : row.Cells["purchasereturnno"].Value.ToString()) + ", " +
                                "@cashinvoiceno =" + (row.Cells["cashinvoiceno"].Value == DBNull.Value
                                   ? "0" : row.Cells["cashinvoiceno"].Value.ToString()) + ", " +
                                "@chargeinvoiceno =" + (row.Cells["chargeinvoiceno"].Value == DBNull.Value
                                   ? "0" : row.Cells["chargeinvoiceno"].Value.ToString()) + ", " +
                                "@stocktransferinno =" + (row.Cells["stocktransferinno"].Value == DBNull.Value
                                   ? "0" : row.Cells["stocktransferinno"].Value.ToString()) + ", " +
                                "@stocktransferoutno =" + (row.Cells["stocktransferoutno"].Value == DBNull.Value
                                   ? "0" : row.Cells["stocktransferoutno"].Value.ToString());

                            SqlCommand cmd = new SqlCommand(cmdstr, Globals.sqlconn);
                            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adapt.Fill(ds);

                            long lastid = 0;

                            if (ds.Tables[0].Rows.Count == 1)
                                lastid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                            else lastid = 0;

                            this.IsChanging = true;
                            if (idval == 0)
                                row.Cells[this.idcolumn].Value = lastid;
                            this.IsChanging = false;

                            // cmd.ExecuteNonQuery();

                            // if (idval == 0)
                            //    this.SearchName(name);

                        }
                        catch (Exception ex)
                        {

                           // MessageBox.Show("Exception Error:" + ex.Message);
                            
                            csMessageBox.Show("Duplicate Exists!!!" ,
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

            String name = row.Cells["name"].Value == DBNull.Value ? ""
                 : row.Cells["name"].Value.ToString().ToUpper();

            this.BindMainGrid();

            if (name != "") this.SearchName(name);
            else bindingNavigator1.MoveLastItem.PerformClick();

            this.dgvMain.Focus();
        }

        private bool deleteRow()
        {
            bool cancel = true;

            DataGridViewRow row = this.dgvMain.CurrentRow;
            String rname = row.Cells["name"].Value.ToString().Trim();
           
           
                if (row.Cells[idcolumn].Value != DBNull.Value &&
                  csMessageBox.Show("Delete the branch:" + rname, "Please confirm.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Globals.glOpenSqlConn())
                    {

                        SqlCommand cmd = new SqlCommand("spBranchesDelete", Globals.sqlconn);
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
          //  e.Cancel = deleteRow();
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

            } else if (e.KeyCode == Keys.Escape)
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
                    String.Format("{0,8}",(e.RowIndex + 1).ToString()),
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
    }
}
