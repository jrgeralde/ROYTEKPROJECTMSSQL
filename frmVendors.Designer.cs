
using System.Drawing;
using System.Windows.Forms;

namespace RoyTekProjectSQL
{
    partial class frmVendors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendors));
            dgvMain = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
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
            btnImport = new Button();
            imageList1 = new ImageList(components);
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            tabControl1 = new TabControl();
            tbInfo = new TabPage();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).BeginInit();
            bindingNavigator1.SuspendLayout();
            tabControl1.SuspendLayout();
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
            dgvMain.Location = new Point(927, -2);
            dgvMain.Margin = new Padding(4, 3, 4, 3);
            dgvMain.Name = "dgvMain";
            dgvMain.Size = new Size(576, 567);
            dgvMain.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem2, toolStripMenuItem1, searchToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(167, 92);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.ShortcutKeys = Keys.F3;
            toolStripMenuItem3.Size = new Size(166, 22);
            toolStripMenuItem3.Text = "Delete Record";
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
            // 
            // panel1
            // 
            panel1.Controls.Add(bindingNavigator1);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 570);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1504, 42);
            panel1.TabIndex = 2;
            // 
            // bindingNavigator1
            // 
            bindingNavigator1.AddNewItem = null;
            bindingNavigator1.CountItem = bindingNavigatorCountItem;
            bindingNavigator1.DeleteItem = null;
            bindingNavigator1.Dock = DockStyle.None;
            bindingNavigator1.Items.AddRange(new ToolStripItem[] { bindingNavigatorMoveFirstItem, bindingNavigatorMovePreviousItem, bindingNavigatorSeparator, bindingNavigatorPositionItem, bindingNavigatorCountItem, bindingNavigatorSeparator1, bindingNavigatorMoveNextItem, bindingNavigatorMoveLastItem, bindingNavigatorSeparator2 });
            bindingNavigator1.Location = new Point(768, 13);
            bindingNavigator1.MoveFirstItem = bindingNavigatorMoveFirstItem;
            bindingNavigator1.MoveLastItem = bindingNavigatorMoveLastItem;
            bindingNavigator1.MoveNextItem = bindingNavigatorMoveNextItem;
            bindingNavigator1.MovePreviousItem = bindingNavigatorMovePreviousItem;
            bindingNavigator1.Name = "bindingNavigator1";
            bindingNavigator1.PositionItem = bindingNavigatorPositionItem;
            bindingNavigator1.Size = new Size(217, 25);
            bindingNavigator1.TabIndex = 5;
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
            // btnImport
            // 
            btnImport.ImageAlign = ContentAlignment.MiddleLeft;
            btnImport.ImageIndex = 1;
            btnImport.ImageList = imageList1;
            btnImport.Location = new Point(1001, 13);
            btnImport.Margin = new Padding(4, 3, 4, 3);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(66, 23);
            btnImport.TabIndex = 4;
            btnImport.Text = "Import";
            btnImport.TextAlign = ContentAlignment.MiddleRight;
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "search-icon-png-9983.png");
            imageList1.Images.SetKeyName(1, "xls-icon-3379.png");
            imageList1.Images.SetKeyName(2, "REFRESH1 - Copy (2).bmp");
            imageList1.Images.SetKeyName(3, "REFRESH1 - Copy.bmp");
            // 
            // btnRefresh
            // 
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.ImageIndex = 3;
            btnRefresh.ImageList = imageList1;
            btnRefresh.Location = new Point(1075, 13);
            btnRefresh.Margin = new Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.ImageIndex = 0;
            btnSearch.ImageList = imageList1;
            btnSearch.Location = new Point(1454, 11);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(37, 23);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1158, 13);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(288, 23);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tbInfo);
            tabControl1.Location = new Point(0, 3);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(920, 562);
            tabControl1.TabIndex = 3;
            // 
            // tbInfo
            // 
            tbInfo.Location = new Point(4, 24);
            tbInfo.Margin = new Padding(4, 3, 4, 3);
            tbInfo.Name = "tbInfo";
            tbInfo.Padding = new Padding(4, 3, 4, 3);
            tbInfo.Size = new Size(912, 534);
            tbInfo.TabIndex = 0;
            tbInfo.Text = "Vendor Information";
            tbInfo.UseVisualStyleBackColor = true;
            // 
            // frmVendors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1504, 612);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(dgvMain);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(50, 50);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmVendors";
            StartPosition = FormStartPosition.Manual;
            Text = "Vendors";
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).EndInit();
            bindingNavigator1.ResumeLayout(false);
            bindingNavigator1.PerformLayout();
            tabControl1.ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tbInfo;
        private Button btnSearch;
        private ImageList imageList1;
        private TextBox txtSearch;
        private Button btnImport;
        private Button btnRefresh;
        private BindingNavigator bindingNavigator1;
        private ToolStripLabel bindingNavigatorCountItem;
        private ToolStripButton bindingNavigatorMoveFirstItem;
        private ToolStripButton bindingNavigatorMovePreviousItem;
        private ToolStripSeparator bindingNavigatorSeparator;
        private ToolStripTextBox bindingNavigatorPositionItem;
        private ToolStripSeparator bindingNavigatorSeparator1;
        private ToolStripButton bindingNavigatorMoveNextItem;
        private ToolStripButton bindingNavigatorMoveLastItem;
        private ToolStripSeparator bindingNavigatorSeparator2;
    }
}