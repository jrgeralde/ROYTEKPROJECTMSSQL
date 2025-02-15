
namespace RoyTekProjectSQL
{
    partial class frmDirectory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirectory));
            dgvMain = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            bindingNavigator1 = new BindingNavigator(components);
            bindingNavigatorCountItem = new ToolStripLabel();
            bindingNavigatorMoveLastItem = new ToolStripButton();
            bindingNavigatorMoveNextItem = new ToolStripButton();
            bindingNavigatorSeparator1 = new ToolStripSeparator();
            bindingNavigatorSeparator = new ToolStripSeparator();
            bindingNavigatorMovePreviousItem = new ToolStripButton();
            bindingNavigatorMoveFirstItem = new ToolStripButton();
            bindingNavigatorSeparator2 = new ToolStripSeparator();
            btnSearch = new ToolStripButton();
            txtSearch = new ToolStripTextBox();
            btnRefresh = new ToolStripButton();
            btnImport = new ToolStripButton();
            bindingNavigatorPositionItem = new ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).BeginInit();
            bindingNavigator1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMain
            // 
            dgvMain.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvMain.DefaultCellStyle = dataGridViewCellStyle1;
            dgvMain.Location = new Point(2, -180);
            dgvMain.Margin = new Padding(4, 3, 4, 3);
            dgvMain.Name = "dgvMain";
            dgvMain.Size = new Size(1540, 745);
            dgvMain.TabIndex = 1;
            dgvMain.CellValueChanged += dgvMain_CellValueChanged;
            dgvMain.RowPostPaint += dgvMain_RowPostPaint;
            dgvMain.RowPrePaint += dgvMain_RowPrePaint;
            dgvMain.UserDeletingRow += dgvMain_UserDeletingRow;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem2, toolStripMenuItem1, searchToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(167, 92);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.ShortcutKeys = Keys.F3;
            toolStripMenuItem3.Size = new Size(166, 22);
            toolStripMenuItem3.Text = "Delete Record";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.F5;
            toolStripMenuItem2.Size = new Size(166, 22);
            toolStripMenuItem2.Text = "Refresh";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeys = Keys.F5;
            toolStripMenuItem1.Size = new Size(166, 22);
            toolStripMenuItem1.Text = "Refresh";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.ShortcutKeys = Keys.F6;
            searchToolStripMenuItem.Size = new Size(166, 22);
            searchToolStripMenuItem.Text = "Search";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(bindingNavigator1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 571);
            panel1.Name = "panel1";
            panel1.Size = new Size(1542, 41);
            panel1.TabIndex = 2;
            // 
            // bindingNavigator1
            // 
            bindingNavigator1.AddNewItem = null;
            bindingNavigator1.CountItem = bindingNavigatorCountItem;
            bindingNavigator1.DeleteItem = null;
            bindingNavigator1.Dock = DockStyle.None;
            bindingNavigator1.Items.AddRange(new ToolStripItem[] { btnSearch, txtSearch, btnRefresh, btnImport });
            bindingNavigator1.Location = new Point(892, 11);
            bindingNavigator1.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bindingNavigator1.MoveLastItem = bindingNavigatorMoveLastItem;
            bindingNavigator1.MoveNextItem = bindingNavigatorMoveNextItem;
            bindingNavigator1.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bindingNavigator1.Name = "bindingNavigator1";
            bindingNavigator1.PositionItem = bindingNavigatorPositionItem;
            bindingNavigator1.Size = new Size(409, 25);
            bindingNavigator1.TabIndex = 0;
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
            // bindingNavigatorSeparator1
            // 
            bindingNavigatorSeparator1.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            bindingNavigatorSeparator1.Size = new Size(6, 25);
            // 
            // bindingNavigatorSeparator
            // 
            bindingNavigatorSeparator.Alignment = ToolStripItemAlignment.Right;
            bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            bindingNavigatorSeparator.Size = new Size(6, 25);
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
            // btnImport
            // 
            btnImport.Alignment = ToolStripItemAlignment.Right;
            btnImport.Image = (Image)resources.GetObject("btnImport.Image");
            btnImport.ImageTransparentColor = Color.Magenta;
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(122, 22);
            btnImport.Text = "Import from Excel";
            btnImport.Click += btnImport_Click;
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
            // frmDirectory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1542, 612);
            Controls.Add(panel1);
            Controls.Add(dgvMain);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(50, 50);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmDirectory";
            StartPosition = FormStartPosition.Manual;
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Panel panel1;
        private BindingNavigator bindingNavigator1;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
        private ToolStripButton btnSearch;
        private ToolStripTextBox txtSearch;
        private ToolStripButton btnRefresh;
        private ToolStripButton btnImport;
        private ToolStripTextBox bindingNavigatorPositionItem;
    }
}