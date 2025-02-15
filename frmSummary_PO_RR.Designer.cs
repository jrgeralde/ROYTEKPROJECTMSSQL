
namespace RoyTekProjectSQL
{
    partial class frmSummary_PO_RR
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
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummary_PO_RR));
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dgvMain = new DataGridView();
            cID = new DataGridViewTextBoxColumn();
            cTrantype = new DataGridViewTextBoxColumn();
            cidBranch = new DataGridViewTextBoxColumn();
            cDirectory = new DataGridViewTextBoxColumn();
            cDocumentNo = new DataGridViewTextBoxColumn();
            cTrandate = new DataGridViewTextBoxColumn();
            cName = new DataGridViewTextBoxColumn();
            cAmount = new DataGridViewTextBoxColumn();
            cStatus = new DataGridViewTextBoxColumn();
            reference = new DataGridViewTextBoxColumn();
            remarks = new DataGridViewTextBoxColumn();
            cEditLogs = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            refreshToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            createNewToolStripMenuItem = new ToolStripMenuItem();
            retrieveDocNoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            pnlTop = new Panel();
            btnPrint = new Button();
            imageList1 = new ImageList(components);
            btnRetrieve = new Button();
            btnCreate = new Button();
            txtVendor = new TextBox();
            label2 = new Label();
            btnRefresh = new Button();
            pkrDateto = new DateTimePicker();
            label1 = new Label();
            pkrDatefrom = new DateTimePicker();
            dgvFooter = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            referenceFooter = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            pnlBottom = new Panel();
            label3 = new Label();
            bindingNavigator1 = new BindingNavigator(components);
            bindingNavigatorCountItem = new ToolStripLabel();
            bindingNavigatorMoveLastItem = new ToolStripButton();
            bindingNavigatorMoveNextItem = new ToolStripButton();
            bindingNavigatorSeparator = new ToolStripSeparator();
            bindingNavigatorPositionItem = new ToolStripTextBox();
            bindingNavigatorSeparator1 = new ToolStripSeparator();
            bindingNavigatorMovePreviousItem = new ToolStripButton();
            bindingNavigatorMoveFirstItem = new ToolStripButton();
            bindingNavigatorSeparator2 = new ToolStripSeparator();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            sqlCommandBuilder2 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            sqlCommandBuilder3 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            contextMenuStrip1.SuspendLayout();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFooter).BeginInit();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).BeginInit();
            bindingNavigator1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMain
            // 
            dgvMain.AllowUserToAddRows = false;
            dgvMain.AllowUserToResizeColumns = false;
            dgvMain.AllowUserToResizeRows = false;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { cID, cTrantype, cidBranch, cDirectory, cDocumentNo, cTrandate, cName, cAmount, cStatus, reference, remarks, cEditLogs });
            dgvMain.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Window;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle16;
            dgvMain.Location = new Point(0, 44);
            dgvMain.Margin = new Padding(4, 3, 4, 3);
            dgvMain.Name = "dgvMain";
            dgvMain.ReadOnly = true;
            dgvMain.ScrollBars = ScrollBars.Vertical;
            dgvMain.ShowCellToolTips = false;
            dgvMain.Size = new Size(1457, 561);
            dgvMain.TabIndex = 0;
            dgvMain.CellFormatting += dgvMain_CellFormatting;
            dgvMain.RowPostPaint += dgvMain_RowPostPaint;
            dgvMain.RowPrePaint += dgvMain_RowPrePaint;
            dgvMain.Scroll += dgvMain_Scroll;
            dgvMain.DoubleClick += dgvMain_DoubleClick;
            // 
            // cID
            // 
            cID.DataPropertyName = "id";
            cID.Frozen = true;
            cID.HeaderText = "ID";
            cID.Name = "cID";
            cID.ReadOnly = true;
            cID.Visible = false;
            // 
            // cTrantype
            // 
            cTrantype.DataPropertyName = "trantype";
            cTrantype.Frozen = true;
            cTrantype.HeaderText = "Doc. Type";
            cTrantype.Name = "cTrantype";
            cTrantype.ReadOnly = true;
            cTrantype.Visible = false;
            // 
            // cidBranch
            // 
            cidBranch.DataPropertyName = "idbranch";
            cidBranch.Frozen = true;
            cidBranch.HeaderText = "Branch ID";
            cidBranch.Name = "cidBranch";
            cidBranch.ReadOnly = true;
            cidBranch.Visible = false;
            // 
            // cDirectory
            // 
            cDirectory.DataPropertyName = "iddirectory";
            cDirectory.Frozen = true;
            cDirectory.HeaderText = "Directory ID";
            cDirectory.Name = "cDirectory";
            cDirectory.ReadOnly = true;
            cDirectory.Visible = false;
            // 
            // cDocumentNo
            // 
            cDocumentNo.DataPropertyName = "documentno";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cDocumentNo.DefaultCellStyle = dataGridViewCellStyle10;
            cDocumentNo.Frozen = true;
            cDocumentNo.HeaderText = "Doc. No.";
            cDocumentNo.Name = "cDocumentNo";
            cDocumentNo.ReadOnly = true;
            cDocumentNo.Width = 80;
            // 
            // cTrandate
            // 
            cTrandate.DataPropertyName = "trandate";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Maroon;
            dataGridViewCellStyle11.Format = "MM/dd/yyyy";
            dataGridViewCellStyle11.NullValue = null;
            cTrandate.DefaultCellStyle = dataGridViewCellStyle11;
            cTrandate.Frozen = true;
            cTrandate.HeaderText = "   Date";
            cTrandate.Name = "cTrandate";
            cTrandate.ReadOnly = true;
            // 
            // cName
            // 
            cName.DataPropertyName = "name";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Blue;
            cName.DefaultCellStyle = dataGridViewCellStyle12;
            cName.HeaderText = "                                 Vendor";
            cName.Name = "cName";
            cName.ReadOnly = true;
            cName.Width = 350;
            // 
            // cAmount
            // 
            cAmount.DataPropertyName = "amount";
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.Red;
            dataGridViewCellStyle13.Format = "N2";
            cAmount.DefaultCellStyle = dataGridViewCellStyle13;
            cAmount.HeaderText = "            Amount";
            cAmount.Name = "cAmount";
            cAmount.ReadOnly = true;
            cAmount.Width = 120;
            // 
            // cStatus
            // 
            cStatus.DataPropertyName = "status";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cStatus.DefaultCellStyle = dataGridViewCellStyle14;
            cStatus.HeaderText = "Status";
            cStatus.Name = "cStatus";
            cStatus.ReadOnly = true;
            cStatus.Width = 120;
            // 
            // reference
            // 
            reference.DataPropertyName = "reference";
            reference.HeaderText = "Reference";
            reference.Name = "reference";
            reference.ReadOnly = true;
            reference.Width = 150;
            // 
            // remarks
            // 
            remarks.DataPropertyName = "remarks";
            remarks.HeaderText = "                            Remarks";
            remarks.Name = "remarks";
            remarks.ReadOnly = true;
            remarks.Width = 300;
            // 
            // cEditLogs
            // 
            cEditLogs.DataPropertyName = "editlogs";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cEditLogs.DefaultCellStyle = dataGridViewCellStyle15;
            cEditLogs.HeaderText = "Edit Logs";
            cEditLogs.Name = "cEditLogs";
            cEditLogs.ReadOnly = true;
            cEditLogs.Width = 1000;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, toolStripSeparator1, createNewToolStripMenuItem, retrieveDocNoToolStripMenuItem, toolStripMenuItem1, printToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(185, 104);
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.ShortcutKeys = Keys.F5;
            refreshToolStripMenuItem.Size = new Size(184, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(181, 6);
            // 
            // createNewToolStripMenuItem
            // 
            createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            createNewToolStripMenuItem.ShortcutKeys = Keys.F2;
            createNewToolStripMenuItem.Size = new Size(184, 22);
            createNewToolStripMenuItem.Text = "Create New";
            createNewToolStripMenuItem.Click += createNewToolStripMenuItem_Click;
            // 
            // retrieveDocNoToolStripMenuItem
            // 
            retrieveDocNoToolStripMenuItem.Name = "retrieveDocNoToolStripMenuItem";
            retrieveDocNoToolStripMenuItem.ShortcutKeys = Keys.F9;
            retrieveDocNoToolStripMenuItem.Size = new Size(184, 22);
            retrieveDocNoToolStripMenuItem.Text = "Retrieve Doc. No.";
            retrieveDocNoToolStripMenuItem.Click += retrieveDocNoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(181, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(184, 22);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // pnlTop
            // 
            pnlTop.BorderStyle = BorderStyle.FixedSingle;
            pnlTop.Controls.Add(btnPrint);
            pnlTop.Controls.Add(btnRetrieve);
            pnlTop.Controls.Add(btnCreate);
            pnlTop.Controls.Add(txtVendor);
            pnlTop.Controls.Add(label2);
            pnlTop.Controls.Add(btnRefresh);
            pnlTop.Controls.Add(pkrDateto);
            pnlTop.Controls.Add(label1);
            pnlTop.Controls.Add(pkrDatefrom);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Margin = new Padding(4, 3, 4, 3);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1461, 41);
            pnlTop.TabIndex = 2;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.ButtonFace;
            btnPrint.ContextMenuStrip = contextMenuStrip1;
            btnPrint.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ImageAlign = ContentAlignment.TopLeft;
            btnPrint.ImageIndex = 5;
            btnPrint.ImageList = imageList1;
            btnPrint.Location = new Point(1230, 6);
            btnPrint.Margin = new Padding(4, 3, 4, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 29);
            btnPrint.TabIndex = 8;
            btnPrint.Text = "Print";
            btnPrint.TextAlign = ContentAlignment.TopRight;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "refresh-icon-10841.jpg");
            imageList1.Images.SetKeyName(1, "document-icon-36565.png");
            imageList1.Images.SetKeyName(2, "filter-icon-25213.png");
            imageList1.Images.SetKeyName(3, "open-book-icon-16358.png");
            imageList1.Images.SetKeyName(4, "printer-icon-1030.jpg");
            imageList1.Images.SetKeyName(5, "printer-icon-1023.png");
            imageList1.Images.SetKeyName(6, "REFRESH1 - Copy.bmp");
            // 
            // btnRetrieve
            // 
            btnRetrieve.BackColor = SystemColors.ButtonFace;
            btnRetrieve.ContextMenuStrip = contextMenuStrip1;
            btnRetrieve.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRetrieve.ImageAlign = ContentAlignment.MiddleLeft;
            btnRetrieve.ImageIndex = 3;
            btnRetrieve.ImageList = imageList1;
            btnRetrieve.Location = new Point(1146, 7);
            btnRetrieve.Margin = new Padding(4, 3, 4, 3);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(82, 29);
            btnRetrieve.TabIndex = 7;
            btnRetrieve.Text = "Retrieve";
            btnRetrieve.TextAlign = ContentAlignment.MiddleRight;
            btnRetrieve.UseVisualStyleBackColor = false;
            btnRetrieve.Click += btnRetrieve_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.ButtonFace;
            btnCreate.ContextMenuStrip = contextMenuStrip1;
            btnCreate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreate.ImageIndex = 1;
            btnCreate.ImageList = imageList1;
            btnCreate.Location = new Point(1063, 7);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 29);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.TextAlign = ContentAlignment.TopRight;
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtVendor
            // 
            txtVendor.AcceptsReturn = true;
            txtVendor.CharacterCasing = CharacterCasing.Upper;
            txtVendor.ContextMenuStrip = contextMenuStrip1;
            txtVendor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtVendor.Location = new Point(408, 6);
            txtVendor.Margin = new Padding(4, 3, 4, 3);
            txtVendor.Name = "txtVendor";
            txtVendor.Size = new Size(302, 25);
            txtVendor.TabIndex = 0;
            txtVendor.KeyDown += txtVendor_KeyDown;
            txtVendor.KeyUp += txtVendor_KeyUp;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ImageAlign = ContentAlignment.TopRight;
            label2.ImageIndex = 2;
            label2.ImageList = imageList1;
            label2.Location = new Point(275, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 5;
            label2.Text = "Filter Vendor";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ButtonFace;
            btnRefresh.ContextMenuStrip = contextMenuStrip1;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(972, 6);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(88, 30);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pkrDateto
            // 
            pkrDateto.ContextMenuStrip = contextMenuStrip1;
            pkrDateto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            pkrDateto.Format = DateTimePickerFormat.Short;
            pkrDateto.Location = new Point(855, 6);
            pkrDateto.Margin = new Padding(4, 3, 4, 3);
            pkrDateto.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            pkrDateto.Name = "pkrDateto";
            pkrDateto.Size = new Size(110, 25);
            pkrDateto.TabIndex = 2;
            pkrDateto.KeyDown += txtVendor_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(834, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "to";
            // 
            // pkrDatefrom
            // 
            pkrDatefrom.ContextMenuStrip = contextMenuStrip1;
            pkrDatefrom.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            pkrDatefrom.Format = DateTimePickerFormat.Short;
            pkrDatefrom.Location = new Point(715, 6);
            pkrDatefrom.Margin = new Padding(4, 3, 4, 3);
            pkrDatefrom.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            pkrDatefrom.Name = "pkrDatefrom";
            pkrDatefrom.Size = new Size(114, 25);
            pkrDatefrom.TabIndex = 1;
            pkrDatefrom.KeyDown += txtVendor_KeyDown;
            // 
            // dgvFooter
            // 
            dgvFooter.AllowUserToAddRows = false;
            dgvFooter.AllowUserToDeleteRows = false;
            dgvFooter.AllowUserToResizeColumns = false;
            dgvFooter.AllowUserToResizeRows = false;
            dgvFooter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFooter.ColumnHeadersVisible = false;
            dgvFooter.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, referenceFooter, Column10, Column11 });
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = SystemColors.Window;
            dataGridViewCellStyle17.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgvFooter.DefaultCellStyle = dataGridViewCellStyle17;
            dgvFooter.Location = new Point(0, 600);
            dgvFooter.Margin = new Padding(4, 3, 4, 3);
            dgvFooter.MultiSelect = false;
            dgvFooter.Name = "dgvFooter";
            dgvFooter.ReadOnly = true;
            dgvFooter.RowHeadersWidth = 55;
            dgvFooter.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvFooter.ScrollBars = ScrollBars.Horizontal;
            dgvFooter.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvFooter.ShowCellToolTips = false;
            dgvFooter.Size = new Size(1457, 50);
            dgvFooter.TabIndex = 3;
            dgvFooter.RowPostPaint += dgvFooter_RowPostPaint;
            dgvFooter.RowPrePaint += dgvFooter_RowPrePaint;
            dgvFooter.Scroll += dgvFooter_Scroll;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 140;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Column2";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.Frozen = true;
            Column3.HeaderText = "Column3";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Visible = false;
            // 
            // Column4
            // 
            Column4.Frozen = true;
            Column4.HeaderText = "Column4";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Visible = false;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Column5";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 87;
            // 
            // Column6
            // 
            Column6.Frozen = true;
            Column6.HeaderText = "Column6";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Column7";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 350;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "TOTALAMOUNT";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Red;
            dataGridViewCellStyle7.Format = "N2";
            Column8.DefaultCellStyle = dataGridViewCellStyle7;
            Column8.HeaderText = "TOTAL";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 120;
            // 
            // Column9
            // 
            Column9.HeaderText = "Column9";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 120;
            // 
            // referenceFooter
            // 
            referenceFooter.HeaderText = "Reference";
            referenceFooter.Name = "referenceFooter";
            referenceFooter.ReadOnly = true;
            referenceFooter.Width = 150;
            // 
            // Column10
            // 
            Column10.HeaderText = "Column10";
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 300;
            // 
            // Column11
            // 
            Column11.HeaderText = "Column11";
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 1000;
            // 
            // pnlBottom
            // 
            pnlBottom.BorderStyle = BorderStyle.FixedSingle;
            pnlBottom.Controls.Add(label3);
            pnlBottom.Controls.Add(bindingNavigator1);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 660);
            pnlBottom.Margin = new Padding(4, 3, 4, 3);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1461, 45);
            pnlBottom.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(13, 18);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(165, 13);
            label3.TabIndex = 3;
            label3.Text = "(*Double Click on Row to Open *)";
            // 
            // bindingNavigator1
            // 
            bindingNavigator1.AddNewItem = null;
            bindingNavigator1.CountItem = bindingNavigatorCountItem;
            bindingNavigator1.DeleteItem = null;
            bindingNavigator1.Dock = DockStyle.None;
            bindingNavigator1.Items.AddRange(new ToolStripItem[] { bindingNavigatorMoveLastItem, bindingNavigatorMoveNextItem, bindingNavigatorSeparator, bindingNavigatorCountItem, bindingNavigatorPositionItem, bindingNavigatorSeparator1, bindingNavigatorMovePreviousItem, bindingNavigatorMoveFirstItem, bindingNavigatorSeparator2 });
            bindingNavigator1.Location = new Point(1042, 7);
            bindingNavigator1.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bindingNavigator1.MoveLastItem = bindingNavigatorMoveLastItem;
            bindingNavigator1.MoveNextItem = bindingNavigatorMoveNextItem;
            bindingNavigator1.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bindingNavigator1.Name = "bindingNavigator1";
            bindingNavigator1.PositionItem = bindingNavigatorPositionItem;
            bindingNavigator1.Size = new Size(217, 25);
            bindingNavigator1.TabIndex = 2;
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
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            bindingNavigatorPositionItem.AccessibleName = "Position";
            bindingNavigatorPositionItem.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorPositionItem.AutoSize = false;
            bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            bindingNavigatorPositionItem.Size = new Size(58, 23);
            bindingNavigatorPositionItem.Text = "0";
            bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            bindingNavigatorSeparator2.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            bindingNavigatorSeparator2.Size = new Size(6, 25);
            // 
            // frmSummary_PO_RR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 705);
            Controls.Add(pnlBottom);
            Controls.Add(dgvFooter);
            Controls.Add(pnlTop);
            Controls.Add(dgvMain);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmSummary_PO_RR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase Orders";
            Load += frmSummary_PO_RR_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFooter).EndInit();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).EndInit();
            bindingNavigator1.ResumeLayout(false);
            bindingNavigator1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.DateTimePicker pkrDatefrom;
        private System.Windows.Forms.DateTimePicker pkrDateto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.DataGridView dgvFooter;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retrieveDocNoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label3;
        private DataGridViewTextBoxColumn cID;
        private DataGridViewTextBoxColumn cTrantype;
        private DataGridViewTextBoxColumn cidBranch;
        private DataGridViewTextBoxColumn cDirectory;
        private DataGridViewTextBoxColumn cDocumentNo;
        private DataGridViewTextBoxColumn cTrandate;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn cAmount;
        private DataGridViewTextBoxColumn cStatus;
        private DataGridViewTextBoxColumn reference;
        private DataGridViewTextBoxColumn remarks;
        private DataGridViewTextBoxColumn cEditLogs;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn referenceFooter;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder2;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder3;
    }
}