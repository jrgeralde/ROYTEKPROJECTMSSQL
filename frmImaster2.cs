using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.Sql;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace RoyTekProjectSQL
{
    public partial class frmImaster2 : Form
    {
        DataTable DTable;
        SqlDataAdapter DAdapter;
        SqlCommandBuilder DCommandBuilder;
        BindingSource DBindingSource;
        // DataGridViewComboBoxColumn cbxItemClass;

        int idcolumn = 0;

        int activevalue = 1;
        int CurrentRowIndex = 1;

        private bool IsChanging = false;
        private bool SuspendAllCellUpdates = true;
        public frmImaster2(int act)
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
        private void frmImaster2_Load(object sender, EventArgs e)
        {
            if (this.activevalue == 1)
                this.Text = "Master List of ACTIVE Items";
            else
                this.Text = "Master List of INACTIVE Items";

            this.Populatecbxitemgroup();
            this.Populatecbxclass();

            this.BindMainGrid();

            this.InitializeMainGrid();


            this.dgvMain.Focus();

            this.LoadRowData();
            this.SuspendAllCellUpdates = false;
            this.IsChanging = false;
        }

        public void InitializeMainGrid()
        {

            this.dgvMain.Columns[this.idcolumn].Visible = false;

            this.dgvMain.Columns["description"].HeaderText = "                                Item Description    ";
            this.dgvMain.Columns["description"].Width = 390;


            this.dgvMain.Columns["active"].HeaderText = " Active";
            this.dgvMain.Columns["active"].Width = 45;

            this.dgvMain.Columns["groupname"].HeaderText = "Item Group";
            this.dgvMain.Columns["groupname"].Width = 125;

            this.dgvMain.Columns["classname"].HeaderText = "Item Class";
            this.dgvMain.Columns["classname"].Width = 180;

            this.dgvMain.Columns["iditemgroup"].Visible = false;
            this.dgvMain.Columns["iditemclass"].Visible = false;


        }

        public void PerformBind()
        {
            this.SuspendAllCellUpdates = true;

            if (Globals.glOpenSqlConn())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Globals.sqlconn;

                cmd.CommandText = "spGetAllImaster2";
                cmd.CommandType = CommandType.StoredProcedure;

                String likedesc = this.txtfilterdescription.Text.Trim() + "%";
                String likegroup = this.txtfilterGroup.Text.Trim() + "%";
                String likeclass = this.txtFilterClassification.Text.Trim() + "%";

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

            if (DTable.Rows.Count > 0)
            {
                this.CurrentRowIndex = 0;
                this.LoadRowData();
            }
            else
            {
                this.CurrentRowIndex = -1;
                this.ClearData();
            }


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

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvMain.CurrentRow;

            this.BindMainGrid();
            String name = txtSearch.Text.ToUpper();

            if (name != "") this.SearchName(name);
            else bindingNavigator1.MoveLastItem.PerformClick();

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

        private void txtClassification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // PUT THE DING OFF
                this.btnRefresh.PerformClick();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.deleteRow();
        }

        private void ClearData()
        {
            this.IsChanging = true;

            this.IsChanging = false;

        }
        private void LoadRowData()
        {


            if (this.CurrentRowIndex > -1 && this.CurrentRowIndex < dgvMain.Rows.Count)
            {
                this.IsChanging = true;
                //  try
                //  {

                txtDescription.Text
                     = dgvMain.Rows[this.CurrentRowIndex].Cells["description"].Value.ToString();

                chkActive.Checked
                    = dgvMain.Rows[this.CurrentRowIndex].Cells["active"].Value == null
                      ? false : bool.Parse(dgvMain.Rows[this.CurrentRowIndex].Cells["active"].Value.ToString());

                this.cbxitemgroup.SelectedValue
                    = dgvMain.Rows[this.CurrentRowIndex].Cells["iditemgroup"].Value.ToString();

                this.cbxItemClass.SelectedValue
                    = dgvMain.Rows[this.CurrentRowIndex].Cells["iditemclass"].Value.ToString();



                //  }
                //  catch
                //  {

                //     this.IsChanging = false;
                //    ClearData();
                // }
                // finally
                // {
                //     this.IsChanging = false;
                // }
                this.LoadRecordFromTable();
                this.IsChanging = false;
            }
            else ClearData();



        }
        private void LoadRecordFromTable()
        {
            if (Globals.glOpenSqlConn() && this.CurrentRowIndex > -1 && this.CurrentRowIndex < dgvMain.Rows.Count)
            {

                long id = dgvMain.Rows[this.CurrentRowIndex].Cells["id"].Value == null
                        ? 0 : long.Parse(dgvMain.Rows[this.CurrentRowIndex].Cells["id"].Value.ToString());
                float vl;
                DateTime dt;
                long intval;
                String stval;

                SqlCommand cmd = new SqlCommand("exec dbo.spImaster_GetItem " +
                     id.ToString(),
                     Globals.sqlconn);


                SqlDataAdapter cadapt = new SqlDataAdapter(cmd);
                DataSet cds = new DataSet();
                cadapt.Fill(cds);

                //MessageBox.Show("1.  "+cmd.CommandText + " rows:" + cds.Tables[0].Rows.Count.ToString());

                if (cds.Tables[0].Rows.Count == 1)
                {
                    //MessageBox.Show("2.  Inside if");

                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["vatpercent"].ToString().Trim());
                    txtvatpercent.Text = vl.ToString("N2");

                    txtCode.Text = cds.Tables[0].Rows[0]["code"].ToString();
                    txtUoM.Text = cds.Tables[0].Rows[0]["uom"].ToString();
                    txtUomPack.Text = cds.Tables[0].Rows[0]["uompack"].ToString();


                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["packfactor"].ToString().Trim());
                    txtPackFactor.Text = vl.ToString("N2");

                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["srp1"].ToString().Trim());
                    txtsrp1.Text = vl.ToString("N2");


                    // MessageBox.Show("3.  "+txtsrp1.Text);

                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["srp2"].ToString().Trim());
                    txtsrp2.Text = vl.ToString("N2");


                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["srp3"].ToString().Trim());
                    txtsrp3.Text = vl.ToString("N2");


                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["srp4"].ToString().Trim());
                    txtsrp4.Text = vl.ToString("N2");


                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["srp5"].ToString().Trim());
                    txtsrp5.Text = vl.ToString("N2");

                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["reorderlevel"].ToString().Trim());
                    txtReorderLevel.Text = vl.ToString("N2");

                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["reorderqty"].ToString().Trim());
                    txtReorderQty.Text = vl.ToString("N2");

                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["assigned_cost"].ToString().Trim());
                    txtAssigned_Cost.Text = vl.ToString("N2");

                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["lat_cost"].ToString().Trim());
                    txtLat_cost.Text = vl.ToString("N2");

                    dt = Globals.glStringtoDateTime(cds.Tables[0].Rows[0]["lat_rrdate"].ToString());
                    dtplat_rrdate.Value = dt;

                    vl = Globals.glStringtoFloat(cds.Tables[0].Rows[0]["lat_wac"].ToString().Trim());
                    txtlat_wac.Text = vl.ToString("N6");

                    txtlat_wacdoc.Text = cds.Tables[0].Rows[0]["lat_wacdoc"].ToString();

                    intval = Globals.glStringtoInt(cds.Tables[0].Rows[0]["lat_wacdocno"].ToString());
                    txtlat_wacdocno.Text = intval.ToString("N0");

                    dt = Globals.glStringtoDateTime(cds.Tables[0].Rows[0]["lat_wacdate"].ToString());
                    dtplat_wacdate.Value = dt;

                }
            }
            Globals.glCloseSqlConn();
        }

        private void SaveItem()
        {
            //
            this.IsChanging = true;
            if (this.CurrentRowIndex > -1 && this.CurrentRowIndex < dgvMain.Rows.Count)
            {
                DataGridViewRow dr = dgvMain.CurrentRow;

                long id = dr.Cells["id"].Value == null
                        ? 0 : long.Parse(dr.Cells["id"].Value.ToString());

                int active = chkActive.Checked ? 1 : 0;

                String code = txtCode.Text;
                String uom = txtUoM.Text;

                long iditemgroup = (long)cbxitemgroup.SelectedValue;
                long iditemclass = (long)cbxItemClass.SelectedValue;

                String uompack = txtUomPack.Text;

                float packfactor = float.Parse(txtPackFactor.Text == "" ? "0.00" : txtPackFactor.Text);
                float vatpercent = float.Parse(txtvatpercent.Text == "" ? "0.00" : txtvatpercent.Text);
                float srp1 = float.Parse(txtsrp1.Text == "" ? "0.00" : txtsrp1.Text);
                float srp2 = float.Parse(txtsrp2.Text == "" ? "0.00" : txtsrp2.Text);
                float srp3 = float.Parse(txtsrp3.Text == "" ? "0.00" : txtsrp3.Text);
                float srp4 = float.Parse(txtsrp4.Text == "" ? "0.00" : txtsrp4.Text);
                float srp5 = float.Parse(txtsrp5.Text == "" ? "0.00" : txtsrp5.Text);
                float reorderlevel = float.Parse(txtReorderLevel.Text == "" ? "0.00" : txtReorderLevel.Text);
                float reorderqty = float.Parse(txtReorderQty.Text == "" ? "0.00" : txtReorderQty.Text);
                float assigned_cost = float.Parse(txtAssigned_Cost.Text == "" ? "0.00" : txtAssigned_Cost.Text);
                // MessageBox.Show("id:"+id.ToString()+" srp1:" + srp1.ToString() + " srp2:" + srp2.ToString() + " srp3:" + srp3.ToString() + " srp4:" + srp4.ToString() + " srp5:" + srp5.ToString());

                if (Globals.glOpenSqlConn())
                {

                    SqlCommand cmd = new SqlCommand("dbo.spImasterSaveItem", Globals.sqlconn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@active", active);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@uom", uom);
                    cmd.Parameters.AddWithValue("@iditemgroup", iditemgroup);
                    cmd.Parameters.AddWithValue("@iditemclass", iditemclass);
                    cmd.Parameters.AddWithValue("@uompack", uompack);
                    cmd.Parameters.AddWithValue("@vatpercent", vatpercent);
                    cmd.Parameters.AddWithValue("@packfactor", packfactor);
                    cmd.Parameters.AddWithValue("@srp1", srp1);
                    cmd.Parameters.AddWithValue("@srp2", srp2);
                    cmd.Parameters.AddWithValue("@srp3", srp3);
                    cmd.Parameters.AddWithValue("@srp4", srp4);
                    cmd.Parameters.AddWithValue("@srp5", srp5);
                    cmd.Parameters.AddWithValue("@reorderlevel", reorderlevel);
                    cmd.Parameters.AddWithValue("@reorderqty", reorderqty);
                    cmd.Parameters.AddWithValue("@assigned_cost", assigned_cost);


                    /*
                    SqlCommand cmd = new SqlCommand("exec dbo.spImasterSaveItem "+
                        id.ToString() + ", " +
                        active.ToString() + ", " +
                        Globals.glQoutedSinglestr(code)+ ", " +
                        Globals.glQoutedSinglestr(uom) + ", " +
                        iditemgroup.ToString() + ", " +
                        iditemclass.ToString() + ", " +
                        Globals.glQoutedSinglestr(uompack) + ", " +
                        vatpercent.ToString() + ", " +
                        packfactor.ToString() + ", " +
                        srp1.ToString() + ", " +
                        srp2.ToString() + ", " +
                        srp3.ToString() + ", " +
                        srp4.ToString() + ", " +
                        srp5.ToString() + ", " +
                        reorderlevel.ToString() + ", " +
                        reorderqty.ToString() + ", " +
                        assigned_cost.ToString(),
                        Globals.sqlconn); ;

                    MessageBox.Show(cmd.CommandText);
                    */
                    cmd.ExecuteNonQuery();

                }
                Globals.glCloseSqlConn();

                this.IsChanging = false;

            }
        }
        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMain.RowCount > 0 && e.RowIndex > 0)
            {
                this.CurrentRowIndex = e.RowIndex;

                LoadRowData();
            }
        }



        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {

            this.CurrentRowIndex = int.Parse(this.bindingNavigatorPositionItem.Text) - 1;
            LoadRowData();

        }

        private void txtfilterdescription_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.btnRefresh.PerformClick();
            }

        }

        private void txtSearch_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.btnSearch.PerformClick(); //Select();

            }
        }

        private void cbxitemgroup_SelectedValueChanged(object sender, EventArgs e)
        {

            if (dgvMain.RowCount > 0)
            {
                this.dgvMain.Rows[this.CurrentRowIndex].Cells["iditemgroup"].Value
                   = cbxitemgroup.SelectedValue.ToString();

                this.dgvMain.Rows[this.CurrentRowIndex].Cells["groupname"].Value
                    = cbxitemgroup.Text;

                this.SaveItem();
            }
        }

        private void cbxItemClass_SelectedValueChanged(object sender, EventArgs e)
        {
            if (dgvMain.RowCount > 0)
            {

                this.dgvMain.Rows[this.CurrentRowIndex].Cells["iditemclass"].Value
                   = cbxItemClass.SelectedValue.ToString();

                this.dgvMain.Rows[this.CurrentRowIndex].Cells["classname"].Value
                    = cbxItemClass.Text;
                this.SaveItem();


            }
        }


        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvMain.RowCount > 0)
            {
                this.dgvMain.Rows[this.CurrentRowIndex].Cells["active"].Value
                   = chkActive.Checked;
                this.SaveItem();
            }
        }


        private void AddItemtoGrid(String descriptionitem, long iditem, long gidgroup, String ggroupname, long gidclass, String gclassname)
        {


            this.IsChanging = true;
            // Grab the new row!
            int rowpos = this.DTable.Rows.Count;
            DataRow newrow = DTable.NewRow();

            newrow["id"] = iditem;
            newrow["description"] = descriptionitem;
            newrow["active"] = this.activevalue;
            newrow["groupname"] = ggroupname;
            newrow["classname"] = gclassname;
            newrow["iditemgroup"] = gidgroup;
            newrow["iditemclass"] = gidclass;


            DTable.Rows.InsertAt(newrow, rowpos);
            DTable.AcceptChanges();

            this.IsChanging = false;
            this.bindingNavigatorMoveLastItem.PerformClick();

        }
        private void AddNewItem()
        {
            DialogResult rs;
            String description = "";

            rs = AskDialog.AskString("New Item Description", "Please type a value.", ref description);
            description = description.ToUpper();

            if (rs == DialogResult.OK && csMessageBox.Show("Add Item:" + description + "?", "Please confirm.",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (Globals.glOpenSqlConn())
                {
                    SqlCommand cmd = new SqlCommand("exec dbo.spImasterSaveItemDescription " +
                         "0, " +  // 0 id to insert
                         Globals.glQoutedSinglestr(description) + ", " +
                          this.activevalue.ToString(),
                         Globals.sqlconn);

                    SqlDataAdapter cadapt = new SqlDataAdapter(cmd);
                    DataSet cds = new DataSet();
                    cadapt.Fill(cds);

                    long lastid = 0;
                    String olddesc = description;
                    String resultmsg = "";
                    long idgroup, idclass;
                    String groupname = "";
                    String classname = "";

                    if (cds.Tables[0].Rows.Count == 1)
                    {
                        lastid = Int64.Parse(cds.Tables[0].Rows[0][0].ToString());
                        olddesc = cds.Tables[0].Rows[0][1].ToString();
                        resultmsg = cds.Tables[0].Rows[0][2].ToString();
                        idgroup = long.Parse(cds.Tables[0].Rows[0][3].ToString());
                        groupname = cds.Tables[0].Rows[0][4].ToString();
                        idclass = long.Parse(cds.Tables[0].Rows[0][5].ToString());
                        classname = cds.Tables[0].Rows[0][6].ToString();

                        if (lastid == -1)
                        {
                            csMessageBox.Show(resultmsg, "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            this.AddItemtoGrid(description, lastid, idgroup, groupname, idclass, classname);

                            this.LoadRowData();
                            this.dgvMain.Focus();
                        }
                    }
                }

            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewItem();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.btnAdd.PerformClick();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.btnAdd.PerformClick();
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            String description = this.txtDescription.Text.ToUpper();

            if (Globals.glOpenSqlConn())
            {
                long idval = (dgvMain.Rows[this.CurrentRowIndex].Cells["id"].Value == null
                       ? 0 : long.Parse(dgvMain.Rows[this.CurrentRowIndex].Cells["id"].Value.ToString()));

                SqlCommand cmd = new SqlCommand("exec dbo.spImasterSaveItemDescription " +
                     idval.ToString() + ", " +  // 0 id to insert
                     Globals.glQoutedSinglestr(description) + ", " +
                      this.activevalue.ToString(),
                     Globals.sqlconn);

                SqlDataAdapter cadapt = new SqlDataAdapter(cmd);
                DataSet cds = new DataSet();
                cadapt.Fill(cds);

                long lastid = 0;
                String olddesc = dgvMain.Rows[this.CurrentRowIndex].Cells["description"].Value == null
                       ? "" : dgvMain.Rows[this.CurrentRowIndex].Cells["description"].Value.ToString();

                String resultmsg = "";
                long idgroup, idclass;
                String groupname = "";
                String classname = "";

                if (cds.Tables[0].Rows.Count == 1)
                {
                    lastid = Int64.Parse(cds.Tables[0].Rows[0][0].ToString());
                    //olddesc = cds.Tables[0].Rows[0][1].ToString();
                    resultmsg = cds.Tables[0].Rows[0][2].ToString();
                    idgroup = long.Parse(cds.Tables[0].Rows[0][3].ToString());
                    groupname = cds.Tables[0].Rows[0][4].ToString();
                    idclass = long.Parse(cds.Tables[0].Rows[0][5].ToString());
                    classname = cds.Tables[0].Rows[0][6].ToString();

                    if (lastid == -1)
                    {
                        csMessageBox.Show(resultmsg, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtDescription.Text = olddesc;

                    }
                    else
                    {

                        this.dgvMain.Rows[this.CurrentRowIndex].Cells["description"].Value
                             = description;


                    }
                }
            }


        }

        private void AllEdit_Leave(object sender, EventArgs e)
        {
            this.SaveItem();
        }

    }
}
