
namespace RoyTekProjectSQL
{
    partial class frmImaster2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImaster2));
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            dgvMain = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            active = new DataGridViewCheckBoxColumn();
            groupname = new DataGridViewTextBoxColumn();
            classname = new DataGridViewTextBoxColumn();
            contextMenuStrip2 = new ContextMenuStrip(components);
            toolStripMenuItem4 = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem1 = new ToolStripMenuItem();
            tabItem = new TabControl();
            tabDetails = new TabPage();
            txtlat_wac = new customControls.royN6TextBox();
            label25 = new Label();
            txtsrp5 = new customControls.royN2TextBox();
            label24 = new Label();
            txtsrp4 = new customControls.royN2TextBox();
            label23 = new Label();
            txtsrp3 = new customControls.royN2TextBox();
            label22 = new Label();
            txtsrp2 = new customControls.royN2TextBox();
            label21 = new Label();
            txtsrp1 = new customControls.royN2TextBox();
            label20 = new Label();
            txtlat_wacdoc = new customControls.royTextBox();
            label19 = new Label();
            dtplat_wacdate = new customControls.royDateTimePicker();
            label17 = new Label();
            btnOpenWACDocument = new Button();
            imageList1 = new ImageList(components);
            label18 = new Label();
            txtlat_wacdocno = new customControls.royN0TextBox();
            label16 = new Label();
            txtAssigned_Cost = new customControls.royN2TextBox();
            dtplat_rrdate = new customControls.royDateTimePicker();
            label15 = new Label();
            btnOpenRR = new Button();
            label14 = new Label();
            txtLat_rr = new customControls.royN0TextBox();
            txtLat_cost = new customControls.royN2TextBox();
            label13 = new Label();
            label12 = new Label();
            txtReorderQty = new customControls.royN2TextBox();
            label11 = new Label();
            txtReorderLevel = new customControls.royN2TextBox();
            txtvatpercent = new customControls.royN2TextBox();
            label10 = new Label();
            txtCode = new customControls.royTextBox();
            label9 = new Label();
            txtPackFactor = new customControls.royN2TextBox();
            label8 = new Label();
            chkActive = new customControls.royCheckBox();
            cbxItemClass = new customControls.royComboBox();
            cbxitemgroup = new customControls.royComboBox();
            label7 = new Label();
            label6 = new Label();
            txtUomPack = new customControls.royTextBox();
            txtUoM = new customControls.royTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtDescription = new customControls.royTextBox();
            pnlBottom = new Panel();
            btnAdd = new Button();
            bindingNavigator1 = new BindingNavigator(components);
            bindingNavigatorCountItem = new ToolStripLabel();
            bindingNavigatorMoveLastItem = new ToolStripButton();
            bindingNavigatorMoveNextItem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            bindingNavigatorPositionItem = new ToolStripTextBox();
            bindingNavigatorSeparator2 = new ToolStripSeparator();
            bindingNavigatorMovePreviousItem = new ToolStripButton();
            bindingNavigatorMoveFirstItem = new ToolStripButton();
            lbldescription = new ToolStripLabel();
            btnSearch = new Button();
            txtSearch = new customControls.royTextBox();
            btnRefresh = new Button();
            label1 = new Label();
            txtFilterClassification = new customControls.royTextBox();
            txtfilterGroup = new customControls.royTextBox();
            lblGroup = new Label();
            txtfilterdescription = new customControls.royTextBox();
            lblFilterItem = new Label();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            contextMenuStrip2.SuspendLayout();
            tabItem.SuspendLayout();
            tabDetails.SuspendLayout();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).BeginInit();
            bindingNavigator1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem2, toolStripMenuItem1, searchToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(170, 92);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.ShortcutKeys = Keys.F1;
            toolStripMenuItem3.Size = new Size(169, 22);
            toolStripMenuItem3.Text = "Add New Item";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.F3;
            toolStripMenuItem2.Size = new Size(169, 22);
            toolStripMenuItem2.Text = "Delete Item";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeys = Keys.F5;
            toolStripMenuItem1.Size = new Size(169, 22);
            toolStripMenuItem1.Text = "Refresh";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.ShortcutKeys = Keys.F6;
            searchToolStripMenuItem.Size = new Size(169, 22);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { id, description, active, groupname, classname });
            dgvMain.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMain.Location = new Point(678, 2);
            dgvMain.Margin = new Padding(4, 3, 4, 3);
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.ShowCellToolTips = false;
            dgvMain.Size = new Size(804, 650);
            dgvMain.TabIndex = 1;
            dgvMain.TabStop = false;
            dgvMain.CellClick += dgvMain_CellClick;
            dgvMain.RowPostPaint += dgvMain_RowPostPaint;
            dgvMain.RowPrePaint += dgvMain_RowPrePaint;
            dgvMain.UserDeletingRow += dgvMain_UserDeletingRow;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.Frozen = true;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            dataGridViewCellStyle1.ForeColor = Color.Blue;
            description.DefaultCellStyle = dataGridViewCellStyle1;
            description.Frozen = true;
            description.HeaderText = "Item Description";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // active
            // 
            active.DataPropertyName = "active";
            active.Frozen = true;
            active.HeaderText = "Active";
            active.Name = "active";
            active.ReadOnly = true;
            // 
            // groupname
            // 
            groupname.DataPropertyName = "groupname";
            groupname.Frozen = true;
            groupname.HeaderText = "Item Group";
            groupname.Name = "groupname";
            groupname.ReadOnly = true;
            // 
            // classname
            // 
            classname.DataPropertyName = "classname";
            classname.Frozen = true;
            classname.HeaderText = "Item Classification";
            classname.Name = "classname";
            classname.ReadOnly = true;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem4, refreshToolStripMenuItem, searchToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(170, 70);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.ShortcutKeys = Keys.F1;
            toolStripMenuItem4.Size = new Size(169, 22);
            toolStripMenuItem4.Text = "Add New Item";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.ShortcutKeys = Keys.F5;
            refreshToolStripMenuItem.Size = new Size(169, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += btnRefresh_Click;
            // 
            // searchToolStripMenuItem1
            // 
            searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            searchToolStripMenuItem1.ShortcutKeys = Keys.F6;
            searchToolStripMenuItem1.Size = new Size(169, 22);
            searchToolStripMenuItem1.Text = "Search";
            searchToolStripMenuItem1.Click += searchToolStripMenuItem_Click;
            // 
            // tabItem
            // 
            tabItem.Controls.Add(tabDetails);
            tabItem.Location = new Point(2, 2);
            tabItem.Margin = new Padding(4, 3, 4, 3);
            tabItem.Name = "tabItem";
            tabItem.SelectedIndex = 0;
            tabItem.Size = new Size(675, 650);
            tabItem.TabIndex = 2;
            // 
            // tabDetails
            // 
            tabDetails.BackColor = SystemColors.ButtonFace;
            tabDetails.Controls.Add(txtlat_wac);
            tabDetails.Controls.Add(label25);
            tabDetails.Controls.Add(txtsrp5);
            tabDetails.Controls.Add(label24);
            tabDetails.Controls.Add(txtsrp4);
            tabDetails.Controls.Add(label23);
            tabDetails.Controls.Add(txtsrp3);
            tabDetails.Controls.Add(label22);
            tabDetails.Controls.Add(txtsrp2);
            tabDetails.Controls.Add(label21);
            tabDetails.Controls.Add(txtsrp1);
            tabDetails.Controls.Add(label20);
            tabDetails.Controls.Add(txtlat_wacdoc);
            tabDetails.Controls.Add(label19);
            tabDetails.Controls.Add(dtplat_wacdate);
            tabDetails.Controls.Add(label17);
            tabDetails.Controls.Add(btnOpenWACDocument);
            tabDetails.Controls.Add(label18);
            tabDetails.Controls.Add(txtlat_wacdocno);
            tabDetails.Controls.Add(label16);
            tabDetails.Controls.Add(txtAssigned_Cost);
            tabDetails.Controls.Add(dtplat_rrdate);
            tabDetails.Controls.Add(label15);
            tabDetails.Controls.Add(btnOpenRR);
            tabDetails.Controls.Add(label14);
            tabDetails.Controls.Add(txtLat_rr);
            tabDetails.Controls.Add(txtLat_cost);
            tabDetails.Controls.Add(label13);
            tabDetails.Controls.Add(label12);
            tabDetails.Controls.Add(txtReorderQty);
            tabDetails.Controls.Add(label11);
            tabDetails.Controls.Add(txtReorderLevel);
            tabDetails.Controls.Add(txtvatpercent);
            tabDetails.Controls.Add(label10);
            tabDetails.Controls.Add(txtCode);
            tabDetails.Controls.Add(label9);
            tabDetails.Controls.Add(txtPackFactor);
            tabDetails.Controls.Add(label8);
            tabDetails.Controls.Add(chkActive);
            tabDetails.Controls.Add(cbxItemClass);
            tabDetails.Controls.Add(cbxitemgroup);
            tabDetails.Controls.Add(label7);
            tabDetails.Controls.Add(label6);
            tabDetails.Controls.Add(txtUomPack);
            tabDetails.Controls.Add(txtUoM);
            tabDetails.Controls.Add(label5);
            tabDetails.Controls.Add(label4);
            tabDetails.Controls.Add(label3);
            tabDetails.Controls.Add(label2);
            tabDetails.Controls.Add(txtDescription);
            tabDetails.Location = new Point(4, 24);
            tabDetails.Margin = new Padding(4, 3, 4, 3);
            tabDetails.Name = "tabDetails";
            tabDetails.Padding = new Padding(4, 3, 4, 3);
            tabDetails.Size = new Size(667, 622);
            tabDetails.TabIndex = 0;
            tabDetails.Text = "Item Details";
            // 
            // txtlat_wac
            // 
            txtlat_wac.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtlat_wac.Location = new Point(22, 404);
            txtlat_wac.Name = "txtlat_wac";
            txtlat_wac.ReadOnly = true;
            txtlat_wac.Size = new Size(101, 25);
            txtlat_wac.TabIndex = 105;
            txtlat_wac.TabStop = false;
            txtlat_wac.TextAlign = HorizontalAlignment.Right;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(474, 190);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(43, 15);
            label25.TabIndex = 104;
            label25.Text = "SRP #5";
            // 
            // txtsrp5
            // 
            txtsrp5.ContextMenuStrip = contextMenuStrip2;
            txtsrp5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtsrp5.Location = new Point(474, 208);
            txtsrp5.Name = "txtsrp5";
            txtsrp5.Size = new Size(107, 25);
            txtsrp5.TabIndex = 13;
            txtsrp5.TextAlign = HorizontalAlignment.Right;
            txtsrp5.Leave += AllEdit_Leave;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(361, 190);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(43, 15);
            label24.TabIndex = 102;
            label24.Text = "SRP #4";
            // 
            // txtsrp4
            // 
            txtsrp4.ContextMenuStrip = contextMenuStrip2;
            txtsrp4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtsrp4.Location = new Point(361, 208);
            txtsrp4.Name = "txtsrp4";
            txtsrp4.Size = new Size(107, 25);
            txtsrp4.TabIndex = 12;
            txtsrp4.TextAlign = HorizontalAlignment.Right;
            txtsrp4.Leave += AllEdit_Leave;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(246, 190);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(43, 15);
            label23.TabIndex = 100;
            label23.Text = "SRP #3";
            // 
            // txtsrp3
            // 
            txtsrp3.ContextMenuStrip = contextMenuStrip2;
            txtsrp3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtsrp3.Location = new Point(247, 208);
            txtsrp3.Name = "txtsrp3";
            txtsrp3.Size = new Size(107, 25);
            txtsrp3.TabIndex = 11;
            txtsrp3.TextAlign = HorizontalAlignment.Right;
            txtsrp3.Leave += AllEdit_Leave;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(133, 190);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(43, 15);
            label22.TabIndex = 98;
            label22.Text = "SRP #2";
            // 
            // txtsrp2
            // 
            txtsrp2.ContextMenuStrip = contextMenuStrip2;
            txtsrp2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtsrp2.Location = new Point(134, 208);
            txtsrp2.Name = "txtsrp2";
            txtsrp2.Size = new Size(107, 25);
            txtsrp2.TabIndex = 10;
            txtsrp2.TextAlign = HorizontalAlignment.Right;
            txtsrp2.Leave += AllEdit_Leave;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(20, 190);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(43, 15);
            label21.TabIndex = 96;
            label21.Text = "SRP #1";
            // 
            // txtsrp1
            // 
            txtsrp1.ContextMenuStrip = contextMenuStrip2;
            txtsrp1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtsrp1.Location = new Point(22, 208);
            txtsrp1.Name = "txtsrp1";
            txtsrp1.Size = new Size(107, 25);
            txtsrp1.TabIndex = 9;
            txtsrp1.TextAlign = HorizontalAlignment.Right;
            txtsrp1.Leave += AllEdit_Leave;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(125, 386);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(63, 15);
            label20.TabIndex = 94;
            label20.Text = "Document";
            // 
            // txtlat_wacdoc
            // 
            txtlat_wacdoc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtlat_wacdoc.Location = new Point(126, 404);
            txtlat_wacdoc.Margin = new Padding(4, 3, 4, 3);
            txtlat_wacdoc.Name = "txtlat_wacdoc";
            txtlat_wacdoc.ReadOnly = true;
            txtlat_wacdoc.Size = new Size(62, 25);
            txtlat_wacdoc.TabIndex = 92;
            txtlat_wacdoc.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(18, 386);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(112, 15);
            label19.TabIndex = 91;
            label19.Text = "Latest Wt. Ave. Cost";
            // 
            // dtplat_wacdate
            // 
            dtplat_wacdate.Enabled = false;
            dtplat_wacdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dtplat_wacdate.Format = DateTimePickerFormat.Short;
            dtplat_wacdate.Location = new Point(325, 404);
            dtplat_wacdate.Name = "dtplat_wacdate";
            dtplat_wacdate.Size = new Size(119, 25);
            dtplat_wacdate.TabIndex = 90;
            dtplat_wacdate.TabStop = false;
            dtplat_wacdate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(325, 386);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(95, 15);
            label17.TabIndex = 89;
            label17.Text = "Latest WAC Date";
            // 
            // btnOpenWACDocument
            // 
            btnOpenWACDocument.ImageIndex = 4;
            btnOpenWACDocument.ImageList = imageList1;
            btnOpenWACDocument.Location = new Point(294, 404);
            btnOpenWACDocument.Name = "btnOpenWACDocument";
            btnOpenWACDocument.Size = new Size(26, 26);
            btnOpenWACDocument.TabIndex = 88;
            btnOpenWACDocument.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "filter-icon-25213.png");
            imageList1.Images.SetKeyName(1, "search-icon-png-9983.png");
            imageList1.Images.SetKeyName(2, "REFRESH1 - Copy (2).bmp");
            imageList1.Images.SetKeyName(3, "pencil-text.png");
            imageList1.Images.SetKeyName(4, "open-book-icon-16354.png");
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(193, 386);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(117, 15);
            label18.TabIndex = 87;
            label18.Text = "Latest WAC Doc. No.";
            // 
            // txtlat_wacdocno
            // 
            txtlat_wacdocno.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtlat_wacdocno.Location = new Point(193, 404);
            txtlat_wacdocno.Name = "txtlat_wacdocno";
            txtlat_wacdocno.ReadOnly = true;
            txtlat_wacdocno.Size = new Size(100, 25);
            txtlat_wacdocno.TabIndex = 86;
            txtlat_wacdocno.TabStop = false;
            txtlat_wacdocno.TextAlign = HorizontalAlignment.Right;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(247, 251);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(82, 15);
            label16.TabIndex = 84;
            label16.Text = "Assigned Cost";
            // 
            // txtAssigned_Cost
            // 
            txtAssigned_Cost.ContextMenuStrip = contextMenuStrip2;
            txtAssigned_Cost.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtAssigned_Cost.Location = new Point(248, 269);
            txtAssigned_Cost.Name = "txtAssigned_Cost";
            txtAssigned_Cost.Size = new Size(102, 25);
            txtAssigned_Cost.TabIndex = 16;
            txtAssigned_Cost.TextAlign = HorizontalAlignment.Right;
            txtAssigned_Cost.Leave += AllEdit_Leave;
            // 
            // dtplat_rrdate
            // 
            dtplat_rrdate.Enabled = false;
            dtplat_rrdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dtplat_rrdate.Format = DateTimePickerFormat.Short;
            dtplat_rrdate.Location = new Point(260, 335);
            dtplat_rrdate.Name = "dtplat_rrdate";
            dtplat_rrdate.Size = new Size(119, 25);
            dtplat_rrdate.TabIndex = 82;
            dtplat_rrdate.TabStop = false;
            dtplat_rrdate.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(260, 317);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(82, 15);
            label15.TabIndex = 81;
            label15.Text = "Latest RR Date";
            // 
            // btnOpenRR
            // 
            btnOpenRR.ImageIndex = 4;
            btnOpenRR.ImageList = imageList1;
            btnOpenRR.Location = new Point(229, 335);
            btnOpenRR.Name = "btnOpenRR";
            btnOpenRR.Size = new Size(26, 26);
            btnOpenRR.TabIndex = 80;
            btnOpenRR.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(125, 317);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(55, 15);
            label14.TabIndex = 79;
            label14.Text = "Latest RR";
            // 
            // txtLat_rr
            // 
            txtLat_rr.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtLat_rr.Location = new Point(125, 335);
            txtLat_rr.Name = "txtLat_rr";
            txtLat_rr.ReadOnly = true;
            txtLat_rr.Size = new Size(100, 25);
            txtLat_rr.TabIndex = 78;
            txtLat_rr.TabStop = false;
            txtLat_rr.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLat_cost
            // 
            txtLat_cost.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtLat_cost.Location = new Point(22, 335);
            txtLat_cost.Name = "txtLat_cost";
            txtLat_cost.ReadOnly = true;
            txtLat_cost.Size = new Size(102, 25);
            txtLat_cost.TabIndex = 77;
            txtLat_cost.TabStop = false;
            txtLat_cost.TextAlign = HorizontalAlignment.Right;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 317);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(65, 15);
            label13.TabIndex = 76;
            label13.Text = "Latest Cost";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(133, 251);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 75;
            label12.Text = "Reorder Qty";
            // 
            // txtReorderQty
            // 
            txtReorderQty.ContextMenuStrip = contextMenuStrip2;
            txtReorderQty.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtReorderQty.Location = new Point(134, 269);
            txtReorderQty.Name = "txtReorderQty";
            txtReorderQty.Size = new Size(108, 25);
            txtReorderQty.TabIndex = 15;
            txtReorderQty.TextAlign = HorizontalAlignment.Right;
            txtReorderQty.Leave += AllEdit_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 251);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(78, 15);
            label11.TabIndex = 73;
            label11.Text = "Reorder Level";
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.ContextMenuStrip = contextMenuStrip2;
            txtReorderLevel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtReorderLevel.Location = new Point(22, 269);
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(106, 25);
            txtReorderLevel.TabIndex = 14;
            txtReorderLevel.TextAlign = HorizontalAlignment.Right;
            txtReorderLevel.Leave += AllEdit_Leave;
            // 
            // txtvatpercent
            // 
            txtvatpercent.ContextMenuStrip = contextMenuStrip2;
            txtvatpercent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtvatpercent.Location = new Point(500, 83);
            txtvatpercent.Name = "txtvatpercent";
            txtvatpercent.Size = new Size(63, 25);
            txtvatpercent.TabIndex = 5;
            txtvatpercent.TextAlign = HorizontalAlignment.Right;
            txtvatpercent.Leave += AllEdit_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(498, 67);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 71;
            label10.Text = "VAT %";
            // 
            // txtCode
            // 
            txtCode.ContextMenuStrip = contextMenuStrip2;
            txtCode.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCode.Location = new Point(506, 30);
            txtCode.Margin = new Padding(4, 3, 4, 3);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(152, 25);
            txtCode.TabIndex = 2;
            txtCode.Leave += AllEdit_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(501, 12);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 69;
            label9.Text = "Item Code";
            // 
            // txtPackFactor
            // 
            txtPackFactor.ContextMenuStrip = contextMenuStrip2;
            txtPackFactor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPackFactor.Location = new Point(229, 142);
            txtPackFactor.Name = "txtPackFactor";
            txtPackFactor.Size = new Size(85, 25);
            txtPackFactor.TabIndex = 8;
            txtPackFactor.TextAlign = HorizontalAlignment.Right;
            txtPackFactor.Leave += AllEdit_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(460, 12);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 67;
            label8.Text = "Active";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.ContextMenuStrip = contextMenuStrip2;
            chkActive.Location = new Point(476, 37);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(15, 14);
            chkActive.TabIndex = 1;
            chkActive.UseVisualStyleBackColor = true;
            chkActive.Click += chkActive_CheckedChanged;
            // 
            // cbxItemClass
            // 
            cbxItemClass.ContextMenuStrip = contextMenuStrip2;
            cbxItemClass.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbxItemClass.FormattingEnabled = true;
            cbxItemClass.Location = new Point(191, 84);
            cbxItemClass.Name = "cbxItemClass";
            cbxItemClass.Size = new Size(189, 25);
            cbxItemClass.TabIndex = 4;
            cbxItemClass.SelectedValueChanged += cbxItemClass_SelectedValueChanged;
            // 
            // cbxitemgroup
            // 
            cbxitemgroup.ContextMenuStrip = contextMenuStrip2;
            cbxitemgroup.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbxitemgroup.FormattingEnabled = true;
            cbxitemgroup.Location = new Point(22, 84);
            cbxitemgroup.Name = "cbxitemgroup";
            cbxitemgroup.Size = new Size(162, 25);
            cbxitemgroup.TabIndex = 3;
            cbxitemgroup.SelectedValueChanged += cbxitemgroup_SelectedValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(228, 124);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 61;
            label7.Text = "Packing Factor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(124, 124);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 60;
            label6.Text = "Packaged Unit";
            // 
            // txtUomPack
            // 
            txtUomPack.ContextMenuStrip = contextMenuStrip2;
            txtUomPack.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUomPack.Location = new Point(125, 142);
            txtUomPack.Margin = new Padding(4, 3, 4, 3);
            txtUomPack.Name = "txtUomPack";
            txtUomPack.Size = new Size(96, 25);
            txtUomPack.TabIndex = 7;
            txtUomPack.Leave += AllEdit_Leave;
            // 
            // txtUoM
            // 
            txtUoM.ContextMenuStrip = contextMenuStrip2;
            txtUoM.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUoM.Location = new Point(22, 142);
            txtUoM.Margin = new Padding(4, 3, 4, 3);
            txtUoM.Name = "txtUoM";
            txtUoM.Size = new Size(96, 25);
            txtUoM.TabIndex = 6;
            txtUoM.Leave += AllEdit_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 124);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 57;
            label5.Text = "Unit of Measure";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 66);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 56;
            label4.Text = "Item Classification";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ContextMenuStrip = contextMenuStrip2;
            label3.Location = new Point(22, 66);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 55;
            label3.Text = "Item Group";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 54;
            label2.Text = "Item Description";
            // 
            // txtDescription
            // 
            txtDescription.CharacterCasing = CharacterCasing.Upper;
            txtDescription.ContextMenuStrip = contextMenuStrip2;
            txtDescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDescription.Location = new Point(22, 31);
            txtDescription.Margin = new Padding(4, 3, 4, 3);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(446, 25);
            txtDescription.TabIndex = 0;
            txtDescription.Leave += txtDescription_Leave;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.Transparent;
            pnlBottom.BorderStyle = BorderStyle.FixedSingle;
            pnlBottom.Controls.Add(btnAdd);
            pnlBottom.Controls.Add(bindingNavigator1);
            pnlBottom.Controls.Add(btnSearch);
            pnlBottom.Controls.Add(txtSearch);
            pnlBottom.Controls.Add(btnRefresh);
            pnlBottom.Controls.Add(label1);
            pnlBottom.Controls.Add(txtFilterClassification);
            pnlBottom.Controls.Add(txtfilterGroup);
            pnlBottom.Controls.Add(lblGroup);
            pnlBottom.Controls.Add(txtfilterdescription);
            pnlBottom.Controls.Add(lblFilterItem);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 662);
            pnlBottom.Margin = new Padding(4, 3, 4, 3);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1484, 45);
            pnlBottom.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.ImageIndex = 3;
            btnAdd.ImageList = imageList1;
            btnAdd.Location = new Point(1362, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 26);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add New Item";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // bindingNavigator1
            // 
            bindingNavigator1.AddNewItem = null;
            bindingNavigator1.ContextMenuStrip = contextMenuStrip1;
            bindingNavigator1.CountItem = bindingNavigatorCountItem;
            bindingNavigator1.DeleteItem = null;
            bindingNavigator1.Dock = DockStyle.None;
            bindingNavigator1.Items.AddRange(new ToolStripItem[] { bindingNavigatorMoveLastItem, bindingNavigatorMoveNextItem, toolStripSeparator1, bindingNavigatorCountItem, bindingNavigatorPositionItem, bindingNavigatorSeparator2, bindingNavigatorMovePreviousItem, bindingNavigatorMoveFirstItem, lbldescription });
            bindingNavigator1.Location = new Point(12, 10);
            bindingNavigator1.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bindingNavigator1.MoveLastItem = bindingNavigatorMoveLastItem;
            bindingNavigator1.MoveNextItem = bindingNavigatorMoveNextItem;
            bindingNavigator1.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bindingNavigator1.Name = "bindingNavigator1";
            bindingNavigator1.PositionItem = bindingNavigatorPositionItem;
            bindingNavigator1.Size = new Size(191, 25);
            bindingNavigator1.TabIndex = 9;
            bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new Size(35, 22);
            bindingNavigatorCountItem.Text = "of {0}";
            bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new Size(23, 22);
            bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new Size(23, 22);
            bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator1.AutoSize = false;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(10, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AccessibleName = "Position";
            bindingNavigatorPositionItem.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new Size(34, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Current position";
            bindingNavigatorPositionItem.TextChanged += bindingNavigatorPositionItem_TextChanged;
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new Size(6, 25);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new Size(23, 22);
            bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new Size(23, 22);
            bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // lbldescription
            // 
            lbldescription.Name = "lbldescription";
            lbldescription.Size = new Size(0, 22);
            lbldescription.ToolTipText = "Description Filter";
            // 
            // btnSearch
            // 
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.ImageIndex = 1;
            btnSearch.ImageList = imageList1;
            btnSearch.Location = new Point(1325, 2);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(33, 27);
            btnSearch.TabIndex = 8;
            btnSearch.TabStop = false;
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.CharacterCasing = CharacterCasing.Upper;
            txtSearch.ContextMenuStrip = contextMenuStrip2;
            txtSearch.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearch.Location = new Point(1124, 4);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(198, 25);
            txtSearch.TabIndex = 7;
            txtSearch.TabStop = false;
            txtSearch.PreviewKeyDown += txtSearch_PreviewKeyDown;
            // 
            // btnRefresh
            // 
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.ImageIndex = 2;
            btnRefresh.ImageList = imageList1;
            btnRefresh.Location = new Point(1046, 4);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(73, 25);
            btnRefresh.TabIndex = 6;
            btnRefresh.TabStop = false;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(809, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 5;
            label1.Text = "Classification";
            // 
            // txtFilterClassification
            // 
            txtFilterClassification.CharacterCasing = CharacterCasing.Upper;
            txtFilterClassification.ContextMenuStrip = contextMenuStrip2;
            txtFilterClassification.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtFilterClassification.Location = new Point(887, 5);
            txtFilterClassification.Margin = new Padding(4, 3, 4, 3);
            txtFilterClassification.Name = "txtFilterClassification";
            txtFilterClassification.Size = new Size(154, 25);
            txtFilterClassification.TabIndex = 4;
            txtFilterClassification.TabStop = false;
            txtFilterClassification.PreviewKeyDown += txtfilterdescription_PreviewKeyDown;
            // 
            // txtfilterGroup
            // 
            txtfilterGroup.CharacterCasing = CharacterCasing.Upper;
            txtfilterGroup.ContextMenuStrip = contextMenuStrip2;
            txtfilterGroup.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtfilterGroup.Location = new Point(676, 4);
            txtfilterGroup.Margin = new Padding(4, 3, 4, 3);
            txtfilterGroup.Name = "txtfilterGroup";
            txtfilterGroup.Size = new Size(128, 25);
            txtfilterGroup.TabIndex = 3;
            txtfilterGroup.TabStop = false;
            txtfilterGroup.KeyDown += txtClassification_KeyDown;
            txtfilterGroup.PreviewKeyDown += txtfilterdescription_PreviewKeyDown;
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Location = new Point(609, 14);
            lblGroup.Margin = new Padding(4, 0, 4, 0);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(67, 15);
            lblGroup.TabIndex = 2;
            lblGroup.Text = "Item Group";
            // 
            // txtfilterdescription
            // 
            txtfilterdescription.CharacterCasing = CharacterCasing.Upper;
            txtfilterdescription.ContextMenuStrip = contextMenuStrip2;
            txtfilterdescription.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtfilterdescription.Location = new Point(335, 5);
            txtfilterdescription.Margin = new Padding(4, 3, 4, 3);
            txtfilterdescription.Name = "txtfilterdescription";
            txtfilterdescription.Size = new Size(270, 25);
            txtfilterdescription.TabIndex = 1;
            txtfilterdescription.TabStop = false;
            txtfilterdescription.KeyUp += txtClassification_KeyDown;
            txtfilterdescription.PreviewKeyDown += txtfilterdescription_PreviewKeyDown;
            // 
            // lblFilterItem
            // 
            lblFilterItem.ImageAlign = ContentAlignment.MiddleLeft;
            lblFilterItem.ImageIndex = 0;
            lblFilterItem.ImageList = imageList1;
            lblFilterItem.Location = new Point(213, 8);
            lblFilterItem.Margin = new Padding(4, 0, 4, 0);
            lblFilterItem.Name = "lblFilterItem";
            lblFilterItem.Size = new Size(120, 27);
            lblFilterItem.TabIndex = 0;
            lblFilterItem.Text = "Filter Description";
            lblFilterItem.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmImaster2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1484, 707);
            Controls.Add(pnlBottom);
            Controls.Add(tabItem);
            Controls.Add(dgvMain);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(80, 50);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmImaster2";
            StartPosition = FormStartPosition.Manual;
            Text = "Item Master List";
            Load += frmImaster2_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            tabItem.ResumeLayout(false);
            tabDetails.ResumeLayout(false);
            tabDetails.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).EndInit();
            bindingNavigator1.ResumeLayout(false);
            bindingNavigator1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabItem;
        private System.Windows.Forms.TabPage tabDetails;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblFilterItem;
        private customControls.royTextBox txtfilterdescription;
        private customControls.royTextBox txtfilterGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label label1;
        private customControls.royTextBox txtFilterClassification;
        private System.Windows.Forms.Button btnRefresh;
        private customControls.royTextBox txtSearch;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripLabel lbldescription;
        private System.Windows.Forms.Button btnSearch;
        private customControls.royTextBox txtDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupname;
        private System.Windows.Forms.DataGridViewTextBoxColumn classname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private customControls.royTextBox txtUomPack;
        private customControls.royTextBox txtUoM;
        private System.Windows.Forms.Label label5;
        private customControls.royComboBox cbxitemgroup;
        private customControls.royComboBox cbxItemClass;
        private Label label8;
        private customControls.royCheckBox chkActive;
        private customControls.royN2TextBox txtPackFactor;
        private Button btnAdd;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private customControls.royTextBox txtCode;
        private Label label9;
        private customControls.royN2TextBox txtvatpercent;
        private Label label10;
        private Label label14;
        private customControls.royN0TextBox txtLat_rr;
        private customControls.royN2TextBox txtLat_cost;
        private Label label13;
        private Label label12;
        private customControls.royN2TextBox txtReorderQty;
        private Label label11;
        private customControls.royN2TextBox txtReorderLevel;
        private customControls.royDateTimePicker dtplat_rrdate;
        private Label label15;
        private Button btnOpenRR;
        private Label label20;
        private customControls.royTextBox txtlat_wacdoc;
        private Label label19;
        private customControls.royDateTimePicker dtplat_wacdate;
        private Label label17;
        private Button btnOpenWACDocument;
        private Label label18;
        private customControls.royN0TextBox txtlat_wacdocno;
        private Label label16;
        private customControls.royN2TextBox txtAssigned_Cost;
        private Label label21;
        private customControls.royN2TextBox txtsrp1;
        private Label label22;
        private customControls.royN2TextBox txtsrp2;
        private Label label25;
        private customControls.royN2TextBox txtsrp5;
        private Label label24;
        private customControls.royN2TextBox txtsrp4;
        private Label label23;
        private customControls.royN2TextBox txtsrp3;
        private customControls.royN6TextBox txtlat_wac;
    }
}