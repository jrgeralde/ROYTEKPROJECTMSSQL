using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;
//using MySql.Data;
using System.Data.Sql;
using Microsoft.Data.SqlClient;


namespace RoyTekProjectSQL
{
    public partial class frmUsers : Form
    {
        DataTable DTable;
        //DataSet DTable;
        SqlDataAdapter DAdapter;
        SqlCommandBuilder DCommandBuilder;
        BindingSource DBindingSource;
        int idcolumn = 0;

        private bool IsChanging = true;
        private bool SuspendAllCellUpdates = true;
        //int birthdatecolumn = 5;

        int indexRow;
        public frmUsers()
        {
            InitializeComponent();
 
            SetTheme();
            PopulatecbxBranches();  // must be done before BindMainGrid
            BindMainGrid();
            InitializeMainGrid();

            this.dgvMain.Focus();
            this.SuspendAllCellUpdates = false;
            this.IsChanging = false;
        }

        public void SetTheme()
        {
            this.BackColor = Globals.gDialogBackgroundColor;

            this.dgvMain.BackgroundColor = Globals.gGridOddRowColor;
            this.dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;

        }

        public void InitializeMainGrid()
        {
            this.dgvMain.ShowCellToolTips = false;
            this.dgvMain.Columns[idcolumn].Visible = false;
            this.dgvMain.Columns[idcolumn].ReadOnly = true;
            this.dgvMain.Columns[idcolumn].HeaderText = "User ID";
            this.dgvMain.Columns[idcolumn].Width = 50;

            this.dgvMain.Columns["loginname"].HeaderText = "Login Name";
            this.dgvMain.Columns["active"].HeaderText = " Active";
            this.dgvMain.Columns["active"].Width = 40;

            this.dgvMain.Columns["mustchangepwd"].HeaderText = "Must Change Password";
            this.dgvMain.Columns["mustchangepwd"].Width = 60;

            this.dgvMain.Columns["gender"].HeaderText = "     Gender";
            this.dgvMain.Columns["gender"].Width = 90;
            
            this.dgvMain.Columns["birthdate"].HeaderText = "   Birth Date";
            this.dgvMain.Columns["birthdate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            this.dgvMain.Columns["birthdate"].Width = 100;
            // this.dgvMain.Columns["birthdate"].ReadOnly = true;

            this.dgvMain.Columns["email"].HeaderText = "                         User Email";
            this.dgvMain.Columns["email"].Width = 300;
              
            this.dgvMain.Columns["smtphost"].HeaderText = "                      SMTP Host";
            this.dgvMain.Columns["smtphost"].Visible = true;
            this.dgvMain.Columns["smtphost"].Width = 300;

            this.dgvMain.Columns["smtpport"].HeaderText = "SMTP Port";
            this.dgvMain.Columns["smtpport"].Visible = true;
     
        }
        public void BindMainGrid()
        {
            this.SuspendAllCellUpdates = true;
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Globals.sqlconn;

                cmd.CommandText = "spGetAllUsers";
                cmd.CommandType = CommandType.StoredProcedure;

               // cmd.CommandText="select id, loginname, active, mustchangepwd, gender, birthdate, email, "+ 
                //    "smtphost, smtpport, idbranch  from users order by loginname ";
                
                
                DTable = new DataTable();
                DAdapter = new SqlDataAdapter();
                DCommandBuilder = new SqlCommandBuilder();

                DCommandBuilder.DataAdapter = DAdapter;

                DAdapter.SelectCommand = cmd;
                DAdapter.Fill(DTable);

                DBindingSource = new BindingSource();

                DBindingSource.DataSource = DTable;

                bindingNavigator1.BindingSource = DBindingSource;

                dgvMain.DataSource = DBindingSource;// DTABLE if fields are bounded;
            }
            Globals.glCloseSqlConn();

            this.SuspendAllCellUpdates = false;
        }

        private void PopulatecbxBranches()
        {
                  SqlDataAdapter da = new SqlDataAdapter("select id,name " +
                    "from dbo.directory "+
                    "where dirtype=0 "+
                    // " where isnull(active,0)=1 " +
                    "order by name",
                     Globals.sqlconn);

                DataTable tblBranch = new DataTable();

                da.Fill(tblBranch);

                this.cbxBranch.ValueMember = "id";
                this.cbxBranch.DisplayMember = "name";

                DataRow topItem = tblBranch.NewRow();
                topItem[0] = 0;
                topItem[1] = "-Select-";
                tblBranch.Rows.InsertAt(topItem, 0);

                this.cbxBranch.DataSource = tblBranch;
      
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

                    String loginname = row.Cells["loginname"].Value == DBNull.Value ? ""
                         : row.Cells["loginname"].Value.ToString().ToUpper();

                    if (loginname == "")
                    {
                        csMessageBox.Show("Please encode a valid user name", "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dgvMain.CancelEdit();

                    }
                    else
                    {
                        long userid = row.Cells[this.idcolumn].Value == DBNull.Value ? 0
                            : Convert.ToInt64(row.Cells["id"].Value);

                        int active = row.Cells["active"].Value == DBNull.Value
                                ? 0 : Convert.ToInt32(row.Cells["active"].Value);

                        int mustchangepwd = row.Cells["mustchangepwd"].Value == DBNull.Value
                            ? 0 : Convert.ToInt32(row.Cells["mustchangepwd"].Value);

                        String gender = row.Cells["gender"].Value == DBNull.Value ? "FEMALE"
                            : row.Cells["gender"].Value.ToString();

                        long idbranch = row.Cells["cbxbranch"].Value == DBNull.Value
                            ? 0
                            : Convert.ToInt64(row.Cells["cbxbranch"].Value.ToString());

                        String birthdatestr = row.Cells["birthdate"].Value == DBNull.Value
                            ? Globals.glToMySqlDate(DateTime.Today)
                            : Globals.glToMySqlDate((DateTime)row.Cells["birthdate"].Value);

                         String email = row.Cells["email"].Value == DBNull.Value
                            ? ""
                            : row.Cells["email"].Value.ToString();

                        String smtphost = row.Cells["smtphost"].Value == DBNull.Value ? ""
                            : row.Cells["smtphost"].Value.ToString();

                        String smtpport = row.Cells["smtpport"].Value == DBNull.Value ? ""
                            : row.Cells["smtpport"].Value.ToString();

                        try
                        {
                            SqlCommand cmd = new SqlCommand("exec dbo.spusersAddEdit "+
                                "@id="+userid.ToString()+", "+
                                "@loginname="+Globals.glQoutedSinglestr(loginname)+", "+
                                "@active="+active.ToString()+", "+
                                "@mustchangepwd="+mustchangepwd.ToString() + ", " +
                                "@gender="+Globals.glQoutedSinglestr(gender)+", "+
                                "@birthdate="+Globals.glQoutedSinglestr(birthdatestr)+", "+
                                "@email="+Globals.glQoutedSinglestr(email) + ", " +
                                "@smtphost="+Globals.glQoutedSinglestr(smtphost) + ", " +
                                "@smtpport="+Globals.glQoutedSinglestr(smtpport) + ", " +
                                "@idbranch="+idbranch.ToString()
                                , Globals.sqlconn);
                              
                            SqlDataAdapter cadapt = new SqlDataAdapter(cmd);
                            DataSet cds = new DataSet();
                            cadapt.Fill(cds);

                            long lastid = 0;
                            if (cds.Tables[0].Rows.Count == 1)
                                lastid = Int64.Parse(cds.Tables[0].Rows[0][0].ToString());

                            this.IsChanging = true;
                            if (userid == 0)
                                row.Cells[this.idcolumn].Value = lastid;
                            this.IsChanging = false;



                        }
                        catch (Exception ex)
                        {
                            csMessageBox.Show("Duplicate Exists!!!",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           // csMessageBox.Show("Exception Error:" + ex.Message,
                            //   "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.BindMainGrid();
                            this.bindingNavigator1.MoveLastItem.PerformClick();
                        }
                    }
                    Globals.glCloseSqlConn();
                    // this.BindMainGrid();

                }
                Globals.glCloseSqlConn();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMain.CurrentRow;

            String name = row.Cells["loginname"].Value == DBNull.Value ? ""
                 : row.Cells["loginname"].Value.ToString().ToUpper();

            this.BindMainGrid();

            if (name != "") this.SearchName(name);
            else bindingNavigator1.MoveLastItem.PerformClick();

            this.dgvMain.Focus();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtSearch.Focus();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.btnRefresh.PerformClick();
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
                        if (row.Cells["loginname"].Value.ToString().StartsWith(searchVal))
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
                this.btnSearch.PerformClick(); //.Select();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                // CustomMessageBox.ShowMessage("Escape key is pressed", "Result",
                //     MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtSearch.Clear();
                this.dgvMain.Focus();
            }
        }

        private frmEditUser EditUserfrm;
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            long userid;
            DataGridViewRow row = dgvMain.CurrentRow;

            if (row.Cells[this.idcolumn].Value == DBNull.Value)
                userid = 0;
            else
                userid = Convert.ToInt64(row.Cells[this.idcolumn].Value);

            if (userid != 0)
            {
                if (EditUserfrm == null)
                {
                    
                    this.indexRow = this.dgvMain.CurrentRow.Index;

                    EditUserfrm = new frmEditUser(userid);
                    EditUserfrm.MdiParent = this.MdiParent;
                    
                    EditUserfrm.FormClosed += EditUserfrm_FormClosed;

                    EditUserfrm.Show();
                }
                else EditUserfrm.Activate();

            }

        }

        private void EditUserfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataGridViewRow dgrow = dgvMain.Rows[indexRow];

            dgrow.Cells["active"].Value = EditUserfrm.IsActive;
            dgrow.Cells["mustchangepwd"].Value = EditUserfrm.MustChangePwd;
           
            dgrow.Cells["gender"].Value = EditUserfrm.Gender;
            dgrow.Cells["birthdate"].Value = EditUserfrm.Birthdate;
            dgrow.Cells["email"].Value = EditUserfrm.Email;
            dgrow.Cells["smtphost"].Value = EditUserfrm.SMTPHost;
            dgrow.Cells["smtpport"].Value = EditUserfrm.SMTPPort;

            EditUserfrm = null;
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

        private bool deleteRow()
        {
            bool cancel = true;

            DataGridViewRow row = this.dgvMain.CurrentRow;
            String name = row.Cells["loginname"].Value.ToString().Trim();

            if (row.Cells[idcolumn].Value != DBNull.Value &&
               csMessageBox.Show("Delete the user:" + name, "Please confirm.",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Globals.glOpenSqlConn())
                {

                    SqlCommand cmd = new SqlCommand("dbo.spusersDelete", Globals.sqlconn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rid", Convert.ToInt64(row.Cells[idcolumn].Value));
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
            //e.Cancel = this.deleteRow();

        }

        private frmUserEmail UserEmailfrm;
        private void tspChangePassword_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvMain.CurrentRow;
            String lname = row.Cells["loginname"].Value.ToString().Trim();
            String lemail = row.Cells["email"].Value.ToString().Trim();

            UserEmailfrm = new frmUserEmail(lname, lemail);
            UserEmailfrm.MdiParent = this.MdiParent;

            UserEmailfrm.FormClosed += UserEmailfrm_FormClosed;

            UserEmailfrm.Show(); //ShowDialog();
        }

        private void UserEmailfrm_FormClosed(object sender, FormClosedEventArgs e)
        {

            UserEmailfrm = null;
        }

        private frmChangePassword ChangePasswordfrm;
        private void tspChangePassword_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvMain.CurrentRow;
            long liduser = int.Parse(row.Cells[idcolumn].Value.ToString());
            String lname = row.Cells["loginname"].Value.ToString().Trim();

            ChangePasswordfrm = new frmChangePassword(liduser, lname);

            ChangePasswordfrm.FormClosed += ChangePasswordfrm_FormClosed;

            ChangePasswordfrm.ShowDialog();
        }

        private void ChangePasswordfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangePasswordfrm = null;
        }

        private void dgvMain_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }

}
