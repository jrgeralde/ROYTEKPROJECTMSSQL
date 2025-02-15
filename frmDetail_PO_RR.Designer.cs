
namespace RoyTekProjectSQL
{
    partial class frmDetail_PO_RR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetail_PO_RR));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabPage1 = new TabPage();
            txtStatus = new TextBox();
            label7 = new Label();
            txtReference = new customControls.royTextBox();
            contextMenuStrip2 = new ContextMenuStrip(components);
            searchByDescriptionToolStripMenuItem1 = new ToolStripMenuItem();
            searchByCodeToolStripMenuItem1 = new ToolStripMenuItem();
            label5 = new Label();
            txtRemarks = new customControls.royTextBox();
            dtpTrandate = new customControls.royDateTimePicker();
            txtDocumentNo = new customControls.royTextBox();
            btnSearchDir = new Button();
            imageList1 = new ImageList(components);
            txtName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabControl2 = new TabControl();
            tbItems = new TabPage();
            dgvFooter = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            idImaster = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            uom = new DataGridViewTextBoxColumn();
            unitamt = new DataGridViewTextBoxColumn();
            totalamt = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            pnlDetail = new Panel();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnCode = new RadioButton();
            btnDescription = new RadioButton();
            btnRefresh = new Button();
            bindingNavigator1 = new BindingNavigator(components);
            bindingNavigatorCountItem = new ToolStripLabel();
            bindingNavigatorMoveFirstItem = new ToolStripButton();
            bindingNavigatorMovePreviousItem = new ToolStripButton();
            bindingNavigatorSeparator = new ToolStripSeparator();
            bindingNavigatorPositionItem = new ToolStripTextBox();
            bindingNavigatorSeparator1 = new ToolStripSeparator();
            bindingNavigatorMoveNextItem = new ToolStripButton();
            bindingNavigatorMoveLastItem = new ToolStripButton();
            bindingNavigatorSeparator2 = new ToolStripSeparator();
            btnRemove = new ToolStripButton();
            dgvMain = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ChangeNameMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            searchByDescriptionToolStripMenuItem = new ToolStripMenuItem();
            searchByCodeToolStripMenuItem = new ToolStripMenuItem();
            tbEditLogs = new TabPage();
            rhbtxtEditLogs = new RichTextBox();
            pnlBottom = new Panel();
            toolTip1 = new ToolTip(components);
            tabPage1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabControl2.SuspendLayout();
            tbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFooter).BeginInit();
            pnlDetail.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).BeginInit();
            bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            contextMenuStrip1.SuspendLayout();
            tbEditLogs.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.ButtonFace;
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(txtStatus);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtReference);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtRemarks);
            tabPage1.Controls.Add(dtpTrandate);
            tabPage1.Controls.Add(txtDocumentNo);
            tabPage1.Controls.Add(btnSearchDir);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.ForeColor = SystemColors.InfoText;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(1285, 116);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Purchase Order Details";
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtStatus.Location = new Point(1032, 63);
            txtStatus.Margin = new Padding(4, 3, 4, 3);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(237, 25);
            txtStatus.TabIndex = 102;
            txtStatus.TabStop = false;
            txtStatus.TextChanged += txtStatus_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(958, 72);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 101;
            label7.Text = "Status";
            // 
            // txtReference
            // 
            txtReference.ContextMenuStrip = contextMenuStrip2;
            txtReference.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtReference.ForeColor = Color.Blue;
            txtReference.Location = new Point(1031, 21);
            txtReference.Margin = new Padding(4, 3, 4, 3);
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(238, 25);
            txtReference.TabIndex = 2;
            txtReference.Leave += txtRemarks_Leave;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { searchByDescriptionToolStripMenuItem1, searchByCodeToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(208, 48);
            // 
            // searchByDescriptionToolStripMenuItem1
            // 
            searchByDescriptionToolStripMenuItem1.Name = "searchByDescriptionToolStripMenuItem1";
            searchByDescriptionToolStripMenuItem1.ShortcutKeys = Keys.F6;
            searchByDescriptionToolStripMenuItem1.Size = new Size(207, 22);
            searchByDescriptionToolStripMenuItem1.Text = "Search by Description";
            searchByDescriptionToolStripMenuItem1.Click += searchByDescriptionToolStripMenuItem_Click;
            // 
            // searchByCodeToolStripMenuItem1
            // 
            searchByCodeToolStripMenuItem1.Name = "searchByCodeToolStripMenuItem1";
            searchByCodeToolStripMenuItem1.ShortcutKeys = Keys.F7;
            searchByCodeToolStripMenuItem1.Size = new Size(207, 22);
            searchByCodeToolStripMenuItem1.Text = "Search by Code";
            searchByCodeToolStripMenuItem1.Click += searchByCodeToolStripMenuItem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(958, 28);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 31;
            label5.Text = "Reference";
            // 
            // txtRemarks
            // 
            txtRemarks.ContextMenuStrip = contextMenuStrip2;
            txtRemarks.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtRemarks.ForeColor = Color.Blue;
            txtRemarks.Location = new Point(96, 63);
            txtRemarks.Margin = new Padding(4, 3, 4, 3);
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(824, 25);
            txtRemarks.TabIndex = 3;
            txtRemarks.Leave += txtRemarks_Leave;
            // 
            // dtpTrandate
            // 
            dtpTrandate.ContextMenuStrip = contextMenuStrip2;
            dtpTrandate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTrandate.Format = DateTimePickerFormat.Short;
            dtpTrandate.Location = new Point(297, 21);
            dtpTrandate.Margin = new Padding(4, 3, 4, 3);
            dtpTrandate.Name = "dtpTrandate";
            dtpTrandate.Size = new Size(134, 25);
            dtpTrandate.TabIndex = 0;
            dtpTrandate.ValueChanged += txtRemarks_Leave;
            dtpTrandate.Leave += txtRemarks_Leave;
            // 
            // txtDocumentNo
            // 
            txtDocumentNo.ContextMenuStrip = contextMenuStrip2;
            txtDocumentNo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDocumentNo.ForeColor = Color.Blue;
            txtDocumentNo.Location = new Point(96, 22);
            txtDocumentNo.Margin = new Padding(4, 3, 4, 3);
            txtDocumentNo.Name = "txtDocumentNo";
            txtDocumentNo.ReadOnly = true;
            txtDocumentNo.Size = new Size(118, 25);
            txtDocumentNo.TabIndex = 100;
            txtDocumentNo.TabStop = false;
            txtDocumentNo.TextAlign = HorizontalAlignment.Right;
            txtDocumentNo.Leave += txtRemarks_Leave;
            // 
            // btnSearchDir
            // 
            btnSearchDir.ContextMenuStrip = contextMenuStrip2;
            btnSearchDir.ImageIndex = 0;
            btnSearchDir.ImageList = imageList1;
            btnSearchDir.Location = new Point(922, 20);
            btnSearchDir.Margin = new Padding(4, 3, 4, 3);
            btnSearchDir.Name = "btnSearchDir";
            btnSearchDir.Size = new Size(29, 27);
            btnSearchDir.TabIndex = 1;
            btnSearchDir.UseVisualStyleBackColor = true;
            btnSearchDir.Click += btnSearchDir_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "search-icon-png-9983.png");
            imageList1.Images.SetKeyName(1, "refresh-icon-10850.png");
            imageList1.Images.SetKeyName(2, "REFRESH1 - Copy (2).bmp");
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.ForeColor = SystemColors.Highlight;
            txtName.Location = new Point(533, 21);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(387, 25);
            txtName.TabIndex = 30;
            txtName.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 15;
            label3.Text = "Vendor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 14;
            label1.Text = "Remarks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(230, 29);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 11;
            label4.Text = "Order Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 31);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 10;
            label2.Text = "Order No.";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(4, 3);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1293, 144);
            tabControl1.TabIndex = 0;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tbItems);
            tabControl2.Controls.Add(tbEditLogs);
            tabControl2.Location = new Point(4, 152);
            tabControl2.Margin = new Padding(4, 3, 4, 3);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1290, 505);
            tabControl2.TabIndex = 1;
            // 
            // tbItems
            // 
            tbItems.Controls.Add(dgvFooter);
            tbItems.Controls.Add(pnlDetail);
            tbItems.Controls.Add(dgvMain);
            tbItems.Location = new Point(4, 24);
            tbItems.Margin = new Padding(4, 3, 4, 3);
            tbItems.Name = "tbItems";
            tbItems.Padding = new Padding(4, 3, 4, 3);
            tbItems.Size = new Size(1282, 477);
            tbItems.TabIndex = 0;
            tbItems.Text = "Items";
            tbItems.UseVisualStyleBackColor = true;
            // 
            // dgvFooter
            // 
            dgvFooter.AllowUserToAddRows = false;
            dgvFooter.AllowUserToDeleteRows = false;
            dgvFooter.AllowUserToResizeColumns = false;
            dgvFooter.AllowUserToResizeRows = false;
            dgvFooter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFooter.ColumnHeadersVisible = false;
            dgvFooter.Columns.AddRange(new DataGridViewColumn[] { id, idImaster, description, qty, uom, unitamt, totalamt, Column8, Column9, Column10, Column11 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvFooter.DefaultCellStyle = dataGridViewCellStyle3;
            dgvFooter.Location = new Point(4, 364);
            dgvFooter.Margin = new Padding(4, 3, 4, 3);
            dgvFooter.MultiSelect = false;
            dgvFooter.Name = "dgvFooter";
            dgvFooter.ReadOnly = true;
            dgvFooter.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvFooter.ScrollBars = ScrollBars.Horizontal;
            dgvFooter.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvFooter.ShowCellToolTips = false;
            dgvFooter.Size = new Size(1274, 27);
            dgvFooter.TabIndex = 4;
            dgvFooter.Scroll += dgvFooter_Scroll;
            // 
            // id
            // 
            id.Frozen = true;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 140;
            // 
            // idImaster
            // 
            idImaster.Frozen = true;
            idImaster.HeaderText = "idImaster";
            idImaster.Name = "idImaster";
            idImaster.ReadOnly = true;
            idImaster.Visible = false;
            idImaster.Width = 120;
            // 
            // description
            // 
            description.Frozen = true;
            description.HeaderText = "Description";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // qty
            // 
            qty.Frozen = true;
            qty.HeaderText = "qty";
            qty.Name = "qty";
            qty.ReadOnly = true;
            // 
            // uom
            // 
            uom.Frozen = true;
            uom.HeaderText = "uom";
            uom.Name = "uom";
            uom.ReadOnly = true;
            uom.Width = 87;
            // 
            // unitamt
            // 
            unitamt.Frozen = true;
            unitamt.HeaderText = "unitamt";
            unitamt.Name = "unitamt";
            unitamt.ReadOnly = true;
            // 
            // totalamt
            // 
            totalamt.DataPropertyName = "totalamt";
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            totalamt.DefaultCellStyle = dataGridViewCellStyle1;
            totalamt.HeaderText = "totalamt";
            totalamt.Name = "totalamt";
            totalamt.ReadOnly = true;
            totalamt.Width = 300;
            // 
            // Column8
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.Format = "N2";
            Column8.DefaultCellStyle = dataGridViewCellStyle2;
            Column8.HeaderText = "Column8";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Visible = false;
            Column8.Width = 120;
            // 
            // Column9
            // 
            Column9.HeaderText = "Column9";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Visible = false;
            Column9.Width = 120;
            // 
            // Column10
            // 
            Column10.HeaderText = "Column10";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Visible = false;
            Column10.Width = 300;
            // 
            // Column11
            // 
            Column11.HeaderText = "Column11";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Visible = false;
            Column11.Width = 1000;
            // 
            // pnlDetail
            // 
            pnlDetail.BackColor = SystemColors.ButtonFace;
            pnlDetail.BorderStyle = BorderStyle.FixedSingle;
            pnlDetail.Controls.Add(label6);
            pnlDetail.Controls.Add(groupBox1);
            pnlDetail.Controls.Add(btnRefresh);
            pnlDetail.Controls.Add(bindingNavigator1);
            pnlDetail.Dock = DockStyle.Bottom;
            pnlDetail.Location = new Point(4, 415);
            pnlDetail.Margin = new Padding(4, 3, 4, 3);
            pnlDetail.Name = "pnlDetail";
            pnlDetail.Size = new Size(1274, 59);
            pnlDetail.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(568, 23);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 3;
            label6.Text = "Search Items by";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCode);
            groupBox1.Controls.Add(btnDescription);
            groupBox1.Location = new Point(672, 14);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(191, 29);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnCode
            // 
            btnCode.AutoSize = true;
            btnCode.Location = new Point(120, 6);
            btnCode.Margin = new Padding(4, 3, 4, 3);
            btnCode.Name = "btnCode";
            btnCode.Size = new Size(53, 19);
            btnCode.TabIndex = 1;
            btnCode.TabStop = true;
            btnCode.Text = "Code";
            btnCode.UseVisualStyleBackColor = true;
            // 
            // btnDescription
            // 
            btnDescription.AutoSize = true;
            btnDescription.Checked = true;
            btnDescription.Location = new Point(9, 6);
            btnDescription.Margin = new Padding(4, 3, 4, 3);
            btnDescription.Name = "btnDescription";
            btnDescription.Size = new Size(85, 19);
            btnDescription.TabIndex = 0;
            btnDescription.TabStop = true;
            btnDescription.Text = "Description";
            btnDescription.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonHighlight;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.Location = new Point(1160, 16);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(43, 27);
            btnRefresh.TabIndex = 1;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // bindingNavigator1
            // 
            bindingNavigator1.AddNewItem = null;
            bindingNavigator1.CountItem = bindingNavigatorCountItem;
            bindingNavigator1.DeleteItem = null;
            bindingNavigator1.Dock = DockStyle.None;
            bindingNavigator1.Items.AddRange(new ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2, btnRemove });
            bindingNavigator1.Location = new Point(886, 14);
            bindingNavigator1.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bindingNavigator1.MoveLastItem = bindingNavigatorMoveLastItem;
            bindingNavigator1.MoveNextItem = bindingNavigatorMoveNextItem;
            bindingNavigator1.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bindingNavigator1.Name = "bindingNavigator1";
            bindingNavigator1.PositionItem = bindingNavigatorPositionItem;
            bindingNavigator1.Size = new Size(240, 25);
            bindingNavigator1.TabIndex = 0;
            bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new Size(35, 22);
            bindingNavigatorCountItem.Text = "of {0}";
            bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            bindingNavigatorMoveFirstItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveFirstItem.Image = (Image)resources.GetObject("bindingNavigatorMoveFirstItem.Image");
            bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveFirstItem.Size = new Size(23, 22);
            bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            bindingNavigatorMovePreviousItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMovePreviousItem.Image = (Image)resources.GetObject("bindingNavigatorMovePreviousItem.Image");
            bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMovePreviousItem.Size = new Size(23, 22);
            bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AccessibleName = "Position";
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new Size(58, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            bindingNavigatorMoveNextItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveNextItem.Image = (Image)resources.GetObject("bindingNavigatorMoveNextItem.Image");
            bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveNextItem.Size = new Size(23, 22);
            bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            bindingNavigatorMoveLastItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bindingNavigatorMoveLastItem.Image = (Image)resources.GetObject("bindingNavigatorMoveLastItem.Image");
            bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            bindingNavigatorMoveLastItem.Size = new Size(23, 22);
            bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new Size(6, 25);
            // 
            // btnRemove
            // 
            btnRemove.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRemove.Image = (Image)resources.GetObject("btnRemove.Image");
            btnRemove.ImageTransparentColor = Color.Magenta;
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(23, 22);
            btnRemove.Click += btnRemove_Click;
            // 
            // dgvMain
            // 
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMain.Location = new Point(4, 3);
            dgvMain.Margin = new Padding(4, 3, 4, 3);
            dgvMain.Name = "dgvMain";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dgvMain.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvMain.ShowCellToolTips = false;
            dgvMain.Size = new Size(1274, 361);
            dgvMain.TabIndex = 0;
            dgvMain.CancelRowEdit += dgvMain_CancelRowEdit;
            dgvMain.CellBeginEdit += dgvMain_CellBeginEdit;
            dgvMain.CellEndEdit += dgvMain_CellEndEdit;
            dgvMain.DataError += dgvMain_DataError;
            dgvMain.RowPostPaint += dgvMain_RowPostPaint;
            dgvMain.RowPrePaint += dgvMain_RowPrePaint;
            dgvMain.Scroll += dgvMain_Scroll;
            dgvMain.UserDeletingRow += dgvMain_UserDeletingRow;
            dgvMain.KeyDown += dgvMain_KeyDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, ChangeNameMenuItem, toolStripMenuItem1, searchByDescriptionToolStripMenuItem, searchByCodeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(208, 98);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.F3;
            deleteToolStripMenuItem.Size = new Size(207, 22);
            deleteToolStripMenuItem.Text = "Delete Record";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // ChangeNameMenuItem
            // 
            ChangeNameMenuItem.Name = "ChangeNameMenuItem";
            ChangeNameMenuItem.ShortcutKeys = Keys.F4;
            ChangeNameMenuItem.Size = new Size(207, 22);
            ChangeNameMenuItem.Text = "Change Vendor";
            ChangeNameMenuItem.Click += ChangeNameMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(204, 6);
            // 
            // searchByDescriptionToolStripMenuItem
            // 
            searchByDescriptionToolStripMenuItem.Name = "searchByDescriptionToolStripMenuItem";
            searchByDescriptionToolStripMenuItem.ShortcutKeys = Keys.F6;
            searchByDescriptionToolStripMenuItem.Size = new Size(207, 22);
            searchByDescriptionToolStripMenuItem.Text = "Search by Description";
            searchByDescriptionToolStripMenuItem.Click += searchByDescriptionToolStripMenuItem_Click;
            // 
            // searchByCodeToolStripMenuItem
            // 
            searchByCodeToolStripMenuItem.Name = "searchByCodeToolStripMenuItem";
            searchByCodeToolStripMenuItem.ShortcutKeys = Keys.F7;
            searchByCodeToolStripMenuItem.Size = new Size(207, 22);
            searchByCodeToolStripMenuItem.Text = "Search by Code";
            searchByCodeToolStripMenuItem.Click += searchByCodeToolStripMenuItem_Click;
            // 
            // tbEditLogs
            // 
            tbEditLogs.Controls.Add(rhbtxtEditLogs);
            tbEditLogs.Location = new Point(4, 24);
            tbEditLogs.Margin = new Padding(4, 3, 4, 3);
            tbEditLogs.Name = "tbEditLogs";
            tbEditLogs.Padding = new Padding(4, 3, 4, 3);
            tbEditLogs.Size = new Size(1282, 477);
            tbEditLogs.TabIndex = 1;
            tbEditLogs.Text = "Edit Logs";
            tbEditLogs.UseVisualStyleBackColor = true;
            // 
            // rhbtxtEditLogs
            // 
            rhbtxtEditLogs.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rhbtxtEditLogs.Location = new Point(202, 78);
            rhbtxtEditLogs.Margin = new Padding(4, 3, 4, 3);
            rhbtxtEditLogs.Name = "rhbtxtEditLogs";
            rhbtxtEditLogs.Size = new Size(809, 284);
            rhbtxtEditLogs.TabIndex = 0;
            rhbtxtEditLogs.Text = "";
            // 
            // pnlBottom
            // 
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 665);
            pnlBottom.Margin = new Padding(4, 3, 4, 3);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1293, 53);
            pnlBottom.TabIndex = 2;
            // 
            // frmDetail_PO_RR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 718);
            Controls.Add(pnlBottom);
            Controls.Add(tabControl2);
            Controls.Add(tabControl1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDetail_PO_RR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase Order";
            Load += frmDetail_PO_RR_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            contextMenuStrip2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tbItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFooter).EndInit();
            pnlDetail.ResumeLayout(false);
            pnlDetail.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).EndInit();
            bindingNavigator1.ResumeLayout(false);
            bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            tbEditLogs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbItems;
        private System.Windows.Forms.TabPage tbEditLogs;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.RichTextBox rhbtxtEditLogs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDetail;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton btnRemove;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnSearchDir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem ChangeNameMenuItem;
        private System.Windows.Forms.Button btnRefresh;
        private customControls.royTextBox txtDocumentNo;
        private customControls.royDateTimePicker dtpTrandate;
        private customControls.royTextBox txtRemarks;
        private System.Windows.Forms.DataGridView dgvFooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idImaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn uom;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private customControls.royTextBox txtReference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnCode;
        private System.Windows.Forms.RadioButton btnDescription;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchByDescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByCodeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem searchByDescriptionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchByCodeToolStripMenuItem1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStatus;
        private ToolTip toolTip1;
    }
}