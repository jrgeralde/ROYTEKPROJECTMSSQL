
namespace RoyTekProjectSQL
{
    partial class frmImaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImaster));
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            bindingNavigator1 = new BindingNavigator(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            bindingNavigatorCountItem = new ToolStripLabel();
            bindingNavigatorSeparator1 = new ToolStripSeparator();
            bindingNavigatorMoveLastItem = new ToolStripButton();
            bindingNavigatorMoveNextItem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            bindingNavigatorPositionItem = new ToolStripTextBox();
            bindingNavigatorSeparator2 = new ToolStripSeparator();
            bindingNavigatorMovePreviousItem = new ToolStripButton();
            bindingNavigatorMoveFirstItem = new ToolStripButton();
            bindingNavigatorSeparator = new ToolStripSeparator();
            btnSearch = new ToolStripButton();
            txtSearch = new ToolStripTextBox();
            btnRefresh = new ToolStripButton();
            lbldescription = new ToolStripLabel();
            toolStripLabel1 = new ToolStripLabel();
            txtdescription = new ToolStripTextBox();
            toolStripLabel3 = new ToolStripLabel();
            txtGroup = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            txtClassification = new ToolStripTextBox();
            dgvMain = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            refreshToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem1 = new ToolStripMenuItem();
            id = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            active = new DataGridViewCheckBoxColumn();
            code = new DataGridViewTextBoxColumn();
            uom = new DataGridViewTextBoxColumn();
            cbxitemgroup = new DataGridViewComboBoxColumn();
            cbxItemClass = new DataGridViewComboBoxColumn();
            uompack = new DataGridViewTextBoxColumn();
            packfactor = new DataGridViewTextBoxColumn();
            vatpercent = new DataGridViewTextBoxColumn();
            srp1 = new DataGridViewTextBoxColumn();
            srp2 = new DataGridViewTextBoxColumn();
            srp3 = new DataGridViewTextBoxColumn();
            srp4 = new DataGridViewTextBoxColumn();
            srp5 = new DataGridViewTextBoxColumn();
            iditemgroup = new DataGridViewTextBoxColumn();
            iditemclass = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).BeginInit();
            bindingNavigator1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // bindingNavigator1
            // 
            bindingNavigator1.AddNewItem = null;
            bindingNavigator1.ContextMenuStrip = contextMenuStrip1;
            bindingNavigator1.CountItem = bindingNavigatorCountItem;
            bindingNavigator1.DeleteItem = null;
            bindingNavigator1.Dock = DockStyle.Bottom;
            bindingNavigator1.Items.AddRange(new ToolStripItem[] { bindingNavigatorSeparator1, bindingNavigatorMoveLastItem, bindingNavigatorMoveNextItem, toolStripSeparator1, bindingNavigatorCountItem, bindingNavigatorPositionItem, bindingNavigatorSeparator2, bindingNavigatorMovePreviousItem, bindingNavigatorMoveFirstItem, bindingNavigatorSeparator, btnSearch, txtSearch, btnRefresh, lbldescription, toolStripLabel1, txtdescription, toolStripLabel3, txtGroup, toolStripLabel2, txtClassification });
            bindingNavigator1.Location = new Point(0, 659);
            bindingNavigator1.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bindingNavigator1.MoveLastItem = bindingNavigatorMoveLastItem;
            bindingNavigator1.MoveNextItem = bindingNavigatorMoveNextItem;
            bindingNavigator1.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bindingNavigator1.Name = "bindingNavigator1";
            bindingNavigator1.PositionItem = bindingNavigatorPositionItem;
            bindingNavigator1.Size = new Size(1396, 25);
            bindingNavigator1.TabIndex = 0;
            bindingNavigator1.Text = "bindingNavigator1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem1, searchToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(167, 70);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.F3;
            toolStripMenuItem2.Size = new Size(166, 22);
            toolStripMenuItem2.Text = "Delete Record";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeys = Keys.F5;
            toolStripMenuItem1.Size = new Size(166, 22);
            toolStripMenuItem1.Text = "Refresh";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.ShortcutKeys = Keys.F6;
            searchToolStripMenuItem.Size = new Size(166, 22);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // bindingNavigatorCountItem
            // 
            bindingNavigatorCountItem.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            bindingNavigatorCountItem.Size = new Size(35, 22);
            bindingNavigatorCountItem.Text = "of {0}";
            bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new Size(6, 25);
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
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new Size(6, 25);
            // 
            // btnSearch
            // 
            btnSearch.Alignment = ToolStripItemAlignment.Right;
            btnSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageTransparentColor = Color.Magenta;
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(23, 22);
            btnSearch.ToolTipText = "Search Role Name";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.AcceptsReturn = true;
            txtSearch.Alignment = ToolStripItemAlignment.Right;
            txtSearch.AutoSize = false;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.CharacterCasing = CharacterCasing.Upper;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(175, 23);
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnRefresh
            // 
            btnRefresh.Alignment = ToolStripItemAlignment.Right;
            btnRefresh.AutoSize = false;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageAlign = ContentAlignment.TopLeft;
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 22);
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.TopCenter;
            btnRefresh.ToolTipText = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lbldescription
            // 
            lbldescription.Name = "lbldescription";
            lbldescription.Size = new Size(0, 22);
            lbldescription.ToolTipText = "Description Filter";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Image = (Image)resources.GetObject("toolStripLabel1.Image");
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(112, 22);
            toolStripLabel1.Text = "Filter Description";
            // 
            // txtdescription
            // 
            txtdescription.AcceptsTab = true;
            txtdescription.AutoSize = false;
            txtdescription.BorderStyle = BorderStyle.FixedSingle;
            txtdescription.CharacterCasing = CharacterCasing.Upper;
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(233, 23);
            txtdescription.ToolTipText = "Description Filter";
            txtdescription.KeyDown += txtdescription_KeyDown;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(67, 22);
            toolStripLabel3.Text = "Item Group";
            // 
            // txtGroup
            // 
            txtGroup.AutoSize = false;
            txtGroup.BorderStyle = BorderStyle.FixedSingle;
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(116, 23);
            txtGroup.KeyDown += txtdescription_KeyDown;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(77, 22);
            toolStripLabel2.Text = "Classification";
            // 
            // txtClassification
            // 
            txtClassification.AcceptsTab = true;
            txtClassification.AutoSize = false;
            txtClassification.BorderStyle = BorderStyle.FixedSingle;
            txtClassification.CharacterCasing = CharacterCasing.Upper;
            txtClassification.Name = "txtClassification";
            txtClassification.Size = new Size(175, 23);
            txtClassification.ToolTipText = "Classification Filter";
            txtClassification.KeyDown += txtClassification_KeyDown;
            txtClassification.KeyPress += txtClassification_KeyPress;
            txtClassification.KeyUp += txtClassification_KeyUp;
            // 
            // dgvMain
            // 
            dgvMain.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Columns.AddRange(new DataGridViewColumn[] { id, description, active, code, uom, cbxitemgroup, cbxItemClass, uompack, packfactor, vatpercent, srp1, srp2, srp3, srp4, srp5, iditemgroup, iditemclass });
            dgvMain.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle8;
            dgvMain.Location = new Point(0, 2);
            dgvMain.Margin = new Padding(4, 3, 4, 3);
            dgvMain.Name = "dgvMain";
            dgvMain.ShowCellToolTips = false;
            dgvMain.Size = new Size(1396, 650);
            dgvMain.TabIndex = 1;
            dgvMain.TabStop = false;
            dgvMain.CellValueChanged += dgvMain_CellValueChanged;
            dgvMain.RowPostPaint += dgvMain_RowPostPaint;
            dgvMain.RowPrePaint += dgvMain_RowPrePaint;
            dgvMain.UserDeletingRow += dgvMain_UserDeletingRow;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, searchToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(133, 48);
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.ShortcutKeys = Keys.F5;
            refreshToolStripMenuItem.Size = new Size(132, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += btnRefresh_Click;
            // 
            // searchToolStripMenuItem1
            // 
            searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            searchToolStripMenuItem1.ShortcutKeys = Keys.F6;
            searchToolStripMenuItem1.Size = new Size(132, 22);
            searchToolStripMenuItem1.Text = "Search";
            searchToolStripMenuItem1.Click += searchToolStripMenuItem_Click;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.Frozen = true;
            id.HeaderText = "id";
            id.Name = "id";
            id.Visible = false;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            description.Frozen = true;
            description.HeaderText = "Item Description";
            description.Name = "description";
            // 
            // active
            // 
            active.DataPropertyName = "active";
            active.Frozen = true;
            active.HeaderText = "Active";
            active.Name = "active";
            // 
            // code
            // 
            code.DataPropertyName = "code";
            code.HeaderText = "Item Code";
            code.Name = "code";
            // 
            // uom
            // 
            uom.DataPropertyName = "uom";
            uom.HeaderText = "Unit";
            uom.Name = "uom";
            // 
            // cbxitemgroup
            // 
            cbxitemgroup.DataPropertyName = "iditemgroup";
            cbxitemgroup.HeaderText = "Item Group";
            cbxitemgroup.Name = "cbxitemgroup";
            cbxitemgroup.Width = 150;
            // 
            // cbxItemClass
            // 
            cbxItemClass.DataPropertyName = "iditemclass";
            cbxItemClass.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            cbxItemClass.HeaderText = "                        Item Classification";
            cbxItemClass.Name = "cbxItemClass";
            cbxItemClass.Width = 250;
            // 
            // uompack
            // 
            uompack.DataPropertyName = "uompack";
            uompack.HeaderText = "Package Unit";
            uompack.Name = "uompack";
            // 
            // packfactor
            // 
            packfactor.DataPropertyName = "packfactor";
            dataGridViewCellStyle1.Format = "N2";
            packfactor.DefaultCellStyle = dataGridViewCellStyle1;
            packfactor.HeaderText = "Pkg Factor";
            packfactor.Name = "packfactor";
            // 
            // vatpercent
            // 
            vatpercent.DataPropertyName = "vatpercent";
            dataGridViewCellStyle2.Format = "N2";
            vatpercent.DefaultCellStyle = dataGridViewCellStyle2;
            vatpercent.HeaderText = "VAT Percent";
            vatpercent.Name = "vatpercent";
            // 
            // srp1
            // 
            srp1.DataPropertyName = "srp1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.Format = "N2";
            srp1.DefaultCellStyle = dataGridViewCellStyle3;
            srp1.HeaderText = "Selling Price #1";
            srp1.Name = "srp1";
            // 
            // srp2
            // 
            srp2.DataPropertyName = "srp2";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.Format = "N2";
            srp2.DefaultCellStyle = dataGridViewCellStyle4;
            srp2.HeaderText = "Selling Price #2";
            srp2.Name = "srp2";
            // 
            // srp3
            // 
            srp3.DataPropertyName = "srp3";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.Format = "N2";
            srp3.DefaultCellStyle = dataGridViewCellStyle5;
            srp3.HeaderText = "Selling Price #3";
            srp3.Name = "srp3";
            // 
            // srp4
            // 
            srp4.DataPropertyName = "srp4";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.Format = "N2";
            srp4.DefaultCellStyle = dataGridViewCellStyle6;
            srp4.HeaderText = "Selling Price #4";
            srp4.Name = "srp4";
            // 
            // srp5
            // 
            srp5.DataPropertyName = "srp5";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.Format = "N2";
            srp5.DefaultCellStyle = dataGridViewCellStyle7;
            srp5.HeaderText = "Selling Price #5";
            srp5.Name = "srp5";
            // 
            // iditemgroup
            // 
            iditemgroup.DataPropertyName = "iditemgroup";
            iditemgroup.HeaderText = "Item Group";
            iditemgroup.Name = "iditemgroup";
            iditemgroup.Visible = false;
            // 
            // iditemclass
            // 
            iditemclass.DataPropertyName = "iditemclass";
            iditemclass.HeaderText = "Class ID";
            iditemclass.Name = "iditemclass";
            iditemclass.Visible = false;
            // 
            // frmImaster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1396, 684);
            Controls.Add(dgvMain);
            Controls.Add(bindingNavigator1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(80, 50);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmImaster";
            StartPosition = FormStartPosition.Manual;
            Text = "Item Master List";
            Load += frmImaster_Load;
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).EndInit();
            bindingNavigator1.ResumeLayout(false);
            bindingNavigator1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lbldescription;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtdescription;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtClassification;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtGroup;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn description;
        private DataGridViewCheckBoxColumn active;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn uom;
        private DataGridViewComboBoxColumn cbxitemgroup;
        private DataGridViewComboBoxColumn cbxItemClass;
        private DataGridViewTextBoxColumn uompack;
        private DataGridViewTextBoxColumn packfactor;
        private DataGridViewTextBoxColumn vatpercent;
        private DataGridViewTextBoxColumn srp1;
        private DataGridViewTextBoxColumn srp2;
        private DataGridViewTextBoxColumn srp3;
        private DataGridViewTextBoxColumn srp4;
        private DataGridViewTextBoxColumn srp5;
        private DataGridViewTextBoxColumn iditemgroup;
        private DataGridViewTextBoxColumn iditemclass;
    }
}