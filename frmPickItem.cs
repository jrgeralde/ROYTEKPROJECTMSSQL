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
    public partial class frmPickItem : Form
    {
        DataTable DTable;
        SqlDataAdapter DAdapter;
        SqlCommandBuilder DCommandBuilder;
        BindingSource DBindingSource;
        int idcolumn = 0;
        String likestr;

        long iditem;
        String itemdescription;
        String itemcode;
        String itemuom;
        float itemlat_cost;
        String itemuompack;
        int itempackfactor;
        float vatpercent;
        float srp1, srp2, srp3, srp4, srp5;

        int searchby;

        public frmPickItem(int sby, String lkstr)
        {
            InitializeComponent();
            this.searchby = sby;
            this.likestr = lkstr;

            if (searchby == Globals.SearchbyName)
                this.Text = "Choose Item by Description";
            else
                this.Text = "Choose Item by Code";


            SetTheme();
            BindMainGrid();
            InitializeMainGrid();
            
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
            this.dgvMain.Columns[idcolumn].Frozen = true;

            this.dgvMain.Columns["description"].HeaderText = "    Item Description ";
            this.dgvMain.Columns["description"].Width = 300;
            this.dgvMain.Columns["description"].Frozen = true;

            this.dgvMain.Columns["code"].HeaderText = " Item Code ";
            this.dgvMain.Columns["code"].Width = 100;
            this.dgvMain.Columns["code"].Frozen = true;

            this.dgvMain.Columns["uom"].HeaderText = "Unit";
            this.dgvMain.Columns["uom"].Width = 70;

            this.dgvMain.Columns["lat_cost"].HeaderText = "Latest Cost";
            this.dgvMain.Columns["lat_cost"].Width = 100;
            this.dgvMain.Columns["lat_cost"].DefaultCellStyle.Format = "N2";
            this.dgvMain.Columns["lat_cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvMain.Columns["uompack"].HeaderText = "Package Unit";
            this.dgvMain.Columns["uompack"].Width = 80;

            this.dgvMain.Columns["packfactor"].HeaderText = "Pkg Factor";
            this.dgvMain.Columns["packfactor"].Width = 70;
            this.dgvMain.Columns["packfactor"].DefaultCellStyle.Format = "N0";
            this.dgvMain.Columns["packfactor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvMain.Columns["vatpercent"].HeaderText = "VAT Percent";
            this.dgvMain.Columns["vatpercent"].Width = 90;
            this.dgvMain.Columns["vatpercent"].DefaultCellStyle.Format = "N2";
            this.dgvMain.Columns["vatpercent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvMain.Columns["srp1"].HeaderText = "Price #1";
            this.dgvMain.Columns["srp1"].Width = 90;
            this.dgvMain.Columns["srp1"].DefaultCellStyle.Format = "N2";
            this.dgvMain.Columns["srp1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvMain.Columns["srp2"].HeaderText = "Price #2";
            this.dgvMain.Columns["srp2"].Width = 90;
            this.dgvMain.Columns["srp2"].DefaultCellStyle.Format = "N2";
            this.dgvMain.Columns["srp2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvMain.Columns["srp3"].HeaderText = "Price #3";
            this.dgvMain.Columns["srp3"].Width = 90;
            this.dgvMain.Columns["srp3"].DefaultCellStyle.Format = "N2";
            this.dgvMain.Columns["srp3"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvMain.Columns["srp4"].HeaderText = "Price #4";
            this.dgvMain.Columns["srp4"].Width = 90;
            this.dgvMain.Columns["srp4"].DefaultCellStyle.Format = "N2";
            this.dgvMain.Columns["srp4"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            this.dgvMain.Columns["srp5"].HeaderText = "Price #5";
            this.dgvMain.Columns["srp5"].Width = 90;
            this.dgvMain.Columns["srp5"].DefaultCellStyle.Format = "N2";
            this.dgvMain.Columns["srp5"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }
        public void BindMainGrid()
        {
            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Globals.sqlconn;

                cmd.CommandText = "exec dbo.spPickItem "+
                    this.searchby.ToString()+", "+
                    Globals.glQoutedSinglestr(this.likestr);

                                              
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
            if (dgvMain.RowCount > 0)
            {
                DataGridViewRow row = dgvMain.CurrentRow;

                this.iditem = Int64.Parse(row.Cells[this.idcolumn].Value == DBNull.Value
                         ? "0" : row.Cells[this.idcolumn].Value.ToString());

                this.itemdescription = row.Cells["description"].Value == DBNull.Value
                           ? "" : row.Cells["description"].Value.ToString();
                this.itemcode = row.Cells["code"].Value == DBNull.Value
                           ? "" : row.Cells["code"].Value.ToString();
                this.itemuom = row.Cells["uom"].Value == DBNull.Value
                               ? "" : row.Cells["uom"].Value.ToString();
                this.itemlat_cost = float.Parse(row.Cells["lat_cost"].Value == DBNull.Value
                               ? "0" : row.Cells["lat_cost"].Value.ToString());
                this.itemuompack = row.Cells["uompack"].Value == DBNull.Value
                               ? "" : row.Cells["uompack"].Value.ToString();
                this.itempackfactor = Int32.Parse(row.Cells["packfactor"].Value == DBNull.Value
                               ? "0" : row.Cells["packfactor"].Value.ToString());



                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.iditem = 0;
            this.itemdescription = "";
            this.itemuom = "";
            this.itemlat_cost= 0;
            this.itemuompack = "";
            this.itempackfactor = 0;

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
        public long IdItem
        {
            get { return this.iditem; }
            set { this.iditem = value; }
        }

        public String ItemDescription
        {
            get { return this.itemdescription; }
            set { this.itemdescription = value; }
        }

        public String ItemCode
        {
            get { return this.itemcode; }
            set { this.itemcode = value; }
        }

        public String ItemUom
        {
            get { return this.itemuom; }
            set { this.itemuom = value; }
        }

        public float ItemLat_Cost
        {
            get { return this.itemlat_cost; }
            set { this.itemlat_cost = value; }
        }

        public String ItemUomPack
        {
            get { return this.itemuompack; }
            set { this.itemuompack = value; }
        }

        public int ItemPackFactor
        {
            get { return this.itempackfactor; }
            set { this.itempackfactor = value; }
        }

        public float VatPercent
        {
            get { return this.vatpercent; }
            set { this.vatpercent = value; }
        }

        public float Srp1
        {
            get { return this.srp1; }
            set { this.srp1 = value; }
        }

        public float Srp2
        {
            get { return this.srp2; }
            set { this.srp2 = value; }
        }
        public float Srp3
        {
            get { return this.srp3; }
            set { this.srp3 = value; }
        }
        public float Srp4
        {
            get { return this.srp4; }
            set { this.srp4 = value; }
        }
        public float Srp5
        {
            get { return this.srp5; }
            set { this.srp5 = value; }
        }

    }
}
