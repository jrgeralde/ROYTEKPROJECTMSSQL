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
    public partial class frmSearchDirectory : Form
    {
        DataTable DTable;
        SqlDataAdapter DAdapter;
        SqlCommandBuilder DCommandBuilder;
        BindingSource DBindingSource;

        int idcolumn = 0;
        int dirtype = Globals.gtypeVendor;  // default type
        String dirtitle = Globals.gtitleVendor;
        String initialfilter = "@#!$@FWERR#rewert34";


        long iddirectory = 0;
        String namedirectory = "";
        public frmSearchDirectory(int dtype, String dtitle)
        {
            InitializeComponent();
            this.dirtype = dtype;
            this.dirtitle = dtitle;
            this.Text = "Search " + this.dirtitle + "s";

            this.lblFilter.Text = "Filter " + dtitle + "s";
            SetTheme();
            this.BindMainGrid();
            this.InitializeMainGrid();
            this.dgvMain.Focus();


        }

        public void SetTheme()
        {
            this.BackColor = Globals.gDialogBackgroundColor;
            this.pnlTop.BackColor = Globals.gDialogBackgroundColor;
            this.pnlBottom.BackColor = Globals.gDialogBackgroundColor;

            this.dgvMain.BackgroundColor = Globals.gGridOddRowColor;
            this.dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Globals.gGridEvenRowColor;

            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Globals.gGridHeaderColor;

        }

        public void InitializeMainGrid()
        {

            this.dgvMain.Columns[idcolumn].Visible = false;
            this.dgvMain.Columns[idcolumn].ReadOnly = true;
            this.dgvMain.Columns[idcolumn].HeaderText = this.dirtitle + " ID";
            this.dgvMain.Columns[idcolumn].Width = 50;

            this.dgvMain.Columns["name"].HeaderText = this.dirtitle + " Name";
            this.dgvMain.Columns["name"].Width = 400;
            this.dgvMain.Columns["name"].DefaultCellStyle.ForeColor = Color.Blue;

            this.dgvMain.Columns["nameshort"].HeaderText = "Short Name";

            this.dgvMain.Columns["address"].HeaderText = "                            Address";
            this.dgvMain.Columns["address"].Width = 600;

            this.dgvMain.Columns["telno"].HeaderText = "Telephone No.";
            this.dgvMain.Columns["telno"].Width = 150;

        }
        public void PerformBind()
        {
            if (Globals.glOpenSqlConn())
            {

                if (this.initialfilter != "@#!$@FWERR#rewert34")
                    this.initialfilter = this.txtFilter.Text.Trim();


                SqlCommand cmd = new SqlCommand("exec dbo.spSearchDirectory " +
                    this.dirtype + ", " +
                    Globals.glQoutedSinglestr(this.initialfilter + "%"),
                    Globals.sqlconn);

                DTable = new DataTable();
                DAdapter = new SqlDataAdapter();
                DCommandBuilder = new SqlCommandBuilder();

                DCommandBuilder.DataAdapter = DAdapter;

                DAdapter.SelectCommand = cmd;
                DAdapter.Fill(DTable);

                DBindingSource = new BindingSource();

                DBindingSource.DataSource = DTable;

                this.initialfilter = this.txtFilter.Text.Trim();

            }
            Globals.glCloseSqlConn();
        }

        public void BindMainGrid()
        {
            using (frmWait frm = new frmWait(PerformBind, "Loading records..."))
            {
                frm.ShowDialog(this);
            }
            bindingNavigator1.BindingSource = DBindingSource;
            dgvMain.DataSource = DBindingSource;// DTABLE if fields are bounded;

        }

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // e.Handled = true;
                e.SuppressKeyPress = true; // PUT THE DING OFF
                this.btnRefresh.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true; // PUT THE DING OFF
                this.btnCancel.PerformClick();
            }
        }

        public long IdDirectory
        {
            get
            {
                this.iddirectory = 0;
                if (dgvMain.RowCount > 0)
                {
                    DataGridViewRow row = dgvMain.CurrentRow;
                    this.iddirectory = row.Cells[this.idcolumn].Value == DBNull.Value
                              ? (long)0 : (long)row.Cells[this.idcolumn].Value;

                }

                return this.iddirectory;



            }
            set { this.iddirectory = value; }
        }

        public String NameDirectory
        {
            get
            {
                this.namedirectory = "";
                if (dgvMain.RowCount > 0)
                {
                    DataGridViewRow row = dgvMain.CurrentRow;
                    this.namedirectory = row.Cells["name"].Value == DBNull.Value
                              ? "" : row.Cells["name"].Value.ToString();
                }

                return this.namedirectory;
            }
            set { this.namedirectory = value; }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.BindMainGrid();
            this.dgvMain.Focus();
        }

        private void txtFilter_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = e.KeyCode == Keys.Return || e.KeyCode == Keys.Enter;
        }

        private void dgvMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // e.Handled = true;
                e.SuppressKeyPress = true; // PUT THE DING OFF
                this.btnOK.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true; // PUT THE DING OFF
                this.btnCancel.PerformClick();
            }
        }

        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    String.Format("{0,6}", (e.RowIndex + 1).ToString()),
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

        private void txtFilter_Click(object sender, EventArgs e)
        {
            this.txtFilter.Text = "";
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.btnRefresh.PerformClick();
        }

        private void dgvMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvMain.RowCount > 0)
            {
                this.btnOK.PerformClick();
            }
        }
    }
}
