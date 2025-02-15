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

namespace RoyTekProjectSQL
{
    public partial class frmPickUserBranch : Form
    {
        DataTable DTable;
        SqlDataAdapter DAdapter;
        SqlCommandBuilder DCommandBuilder;
        BindingSource DBindingSource;
        int idcolumn = 0;
        long iduser;

        public frmPickUserBranch(long uid)
        {
            InitializeComponent();
            this.iduser = uid;

            SetTheme();
            BindMainGrid();
            InitializeMainGrid();
            
        }

        private void frmPickUserBranch_Load(object sender, EventArgs e)
        {
            
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
            this.dgvMain.Columns[idcolumn].HeaderText = "Branch ID";
            this.dgvMain.Columns[idcolumn].Width = 50;

            this.dgvMain.Columns["name"].HeaderText = "Branch Name";
          
        }
        public void BindMainGrid()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Globals.sqlconn;

                cmd.CommandText = "exec dbo.spPickUserBranch "+this.iduser.ToString();
                                
                DTable = new DataTable();
                DAdapter = new SqlDataAdapter();
                DCommandBuilder = new SqlCommandBuilder();

                DCommandBuilder.DataAdapter = DAdapter;

                DAdapter.SelectCommand = cmd;
                DAdapter.Fill(DTable);

                DBindingSource = new BindingSource();

                DBindingSource.DataSource = DTable;

                bindingNavigator1.BindingSource = DBindingSource;

                dgvMain.DataSource = DBindingSource;
            }
            Globals.glCloseSqlConn();

        }

        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            this.btnOK.PerformClick();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvMain.CurrentRow;

            Globals.gIdBranch=int.Parse(row.Cells["idbranch"].Value.ToString());
            Globals.gBranchName = row.Cells["name"].Value.ToString().ToUpper();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgvMain_KeyDown(object sender, KeyEventArgs e)
        {
        
            if (e.KeyCode == Keys.Escape)
               this.btnCancel.PerformClick();
            else if (e.KeyCode == Keys.Enter)
               this.btnOK.PerformClick();
        }

        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    String.Format("{0,5}", (e.RowIndex + 1).ToString()),
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
            dgvMain.RowHeadersWidth = rowHeaderWitdh + 30;


        }
    }
}
