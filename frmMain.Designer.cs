
namespace RoyTekProjectSQL
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            MainMenu = new MenuStrip();
            SystemToolItem = new ToolStripMenuItem();
            toolStripEditUserProfile = new ToolStripMenuItem();
            toolStripChangePassword = new ToolStripMenuItem();
            LOGoutMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripSystem = new ToolStripMenuItem();
            editToolStripEditUserProfile = new ToolStripMenuItem();
            ToolStripChangeUserPassword = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            ToolStriplogoutUser = new ToolStripMenuItem();
            ToolStripexit = new ToolStripMenuItem();
            toolStripAdmin = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            rolesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            branchesToolStripMenuItem = new ToolStripMenuItem();
            dEMOSToolStripMenuItem = new ToolStripMenuItem();
            progressBarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            customMessageBoxOKToolStripMenuItem = new ToolStripMenuItem();
            customMessageBoxWarningToolStripMenuItem = new ToolStripMenuItem();
            customMessageBoxYesNoToolStripMenuItem = new ToolStripMenuItem();
            customMessageBoxYesNoCancelToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            askForAStringDialogBoxToolStripMenuItem = new ToolStripMenuItem();
            askForAPasswordDialogBoxToolStripMenuItem = new ToolStripMenuItem();
            askForADateValueToolStripMenuItem = new ToolStripMenuItem();
            askForAnIntegerToolStripMenuItem = new ToolStripMenuItem();
            askForADoubleValueToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            pickItemToolStripMenuItem = new ToolStripMenuItem();
            ToolStripTop = new ToolStrip();
            btnExit = new ToolStripButton();
            btnMinimize = new ToolStripButton();
            btnLockout = new ToolStripButton();
            btnLogout = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            btnVendor = new ToolStripButton();
            btnCustomers = new ToolStripButton();
            btnDepartment = new ToolStripButton();
            tspChangeBranch = new ToolStripButton();
            btnItems = new ToolStripDropDownButton();
            activeItemsToolStripMenuItem = new ToolStripMenuItem();
            inActiveItemsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            itemClassificationsToolStripMenuItem = new ToolStripMenuItem();
            priceCategoriesToolStripMenuItem = new ToolStripMenuItem();
            btnTransactions = new ToolStripDropDownButton();
            requestForItemToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            purchaseOrderToolStripMenuItem = new ToolStripMenuItem();
            receivingReportToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            warehouseIssuanceToolStripMenuItem = new ToolStripMenuItem();
            warehouseAdjustmentToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            branchTransferOutgoingToolStripMenuItem = new ToolStripMenuItem();
            branchTransferIncomingToolStripMenuItem = new ToolStripMenuItem();
            toolStripBottom = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtUserName = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            txtServer = new ToolStripTextBox();
            toolStripLabel3 = new ToolStripLabel();
            txtBranch = new ToolStripTextBox();
            MainMenu.SuspendLayout();
            ToolStripTop.SuspendLayout();
            toolStripBottom.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.Items.AddRange(new ToolStripItem[] { SystemToolItem, systemToolStripSystem, toolStripAdmin, dEMOSToolStripMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Padding = new Padding(7, 2, 0, 2);
            MainMenu.Size = new Size(1569, 24);
            MainMenu.TabIndex = 0;
            MainMenu.Text = "menuStrip1";
            // 
            // SystemToolItem
            // 
            SystemToolItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripEditUserProfile, toolStripChangePassword, LOGoutMenuItem, toolStripSeparator2, exitToolStripMenuItem });
            SystemToolItem.Name = "SystemToolItem";
            SystemToolItem.Size = new Size(12, 20);
            // 
            // toolStripEditUserProfile
            // 
            toolStripEditUserProfile.Image = (Image)resources.GetObject("toolStripEditUserProfile.Image");
            toolStripEditUserProfile.Name = "toolStripEditUserProfile";
            toolStripEditUserProfile.Size = new Size(194, 22);
            toolStripEditUserProfile.Text = "&Edit User Profile";
            toolStripEditUserProfile.Click += toolStripEditUserProfile_Click;
            // 
            // toolStripChangePassword
            // 
            toolStripChangePassword.Image = (Image)resources.GetObject("toolStripChangePassword.Image");
            toolStripChangePassword.Name = "toolStripChangePassword";
            toolStripChangePassword.Size = new Size(194, 22);
            toolStripChangePassword.Text = "Change User Password";
            toolStripChangePassword.Click += toolStripChangePassword_Click;
            // 
            // LOGoutMenuItem
            // 
            LOGoutMenuItem.Image = (Image)resources.GetObject("LOGoutMenuItem.Image");
            LOGoutMenuItem.ImageTransparentColor = Color.White;
            LOGoutMenuItem.Name = "LOGoutMenuItem";
            LOGoutMenuItem.Size = new Size(194, 22);
            LOGoutMenuItem.Text = "&Logout";
            LOGoutMenuItem.Click += LOGoutMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(191, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = (Image)resources.GetObject("exitToolStripMenuItem.Image");
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(194, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // systemToolStripSystem
            // 
            systemToolStripSystem.DropDownItems.AddRange(new ToolStripItem[] { editToolStripEditUserProfile, ToolStripChangeUserPassword, toolStripMenuItem2, ToolStriplogoutUser, ToolStripexit });
            systemToolStripSystem.Name = "systemToolStripSystem";
            systemToolStripSystem.Size = new Size(57, 20);
            systemToolStripSystem.Text = "System";
            // 
            // editToolStripEditUserProfile
            // 
            editToolStripEditUserProfile.Image = (Image)resources.GetObject("editToolStripEditUserProfile.Image");
            editToolStripEditUserProfile.Name = "editToolStripEditUserProfile";
            editToolStripEditUserProfile.Size = new Size(194, 22);
            editToolStripEditUserProfile.Text = "Edit User Profile";
            editToolStripEditUserProfile.Click += toolStripEditUserProfile_Click;
            // 
            // ToolStripChangeUserPassword
            // 
            ToolStripChangeUserPassword.Image = (Image)resources.GetObject("ToolStripChangeUserPassword.Image");
            ToolStripChangeUserPassword.Name = "ToolStripChangeUserPassword";
            ToolStripChangeUserPassword.Size = new Size(194, 22);
            ToolStripChangeUserPassword.Text = "Change User Password";
            ToolStripChangeUserPassword.Click += toolStripChangePassword_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(191, 6);
            // 
            // ToolStriplogoutUser
            // 
            ToolStriplogoutUser.Image = (Image)resources.GetObject("ToolStriplogoutUser.Image");
            ToolStriplogoutUser.Name = "ToolStriplogoutUser";
            ToolStriplogoutUser.Size = new Size(194, 22);
            ToolStriplogoutUser.Text = "Logout User";
            ToolStriplogoutUser.Visible = false;
            ToolStriplogoutUser.Click += LOGoutMenuItem_Click;
            // 
            // ToolStripexit
            // 
            ToolStripexit.Image = (Image)resources.GetObject("ToolStripexit.Image");
            ToolStripexit.Name = "ToolStripexit";
            ToolStripexit.Size = new Size(194, 22);
            ToolStripexit.Text = "Exit";
            ToolStripexit.Click += exitToolStripMenuItem_Click;
            // 
            // toolStripAdmin
            // 
            toolStripAdmin.DropDownItems.AddRange(new ToolStripItem[] { usersToolStripMenuItem, rolesToolStripMenuItem, toolStripMenuItem3, branchesToolStripMenuItem });
            toolStripAdmin.Name = "toolStripAdmin";
            toolStripAdmin.Size = new Size(55, 20);
            toolStripAdmin.Text = "Admin";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Image = (Image)resources.GetObject("usersToolStripMenuItem.Image");
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(122, 22);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // rolesToolStripMenuItem
            // 
            rolesToolStripMenuItem.Image = (Image)resources.GetObject("rolesToolStripMenuItem.Image");
            rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            rolesToolStripMenuItem.Size = new Size(122, 22);
            rolesToolStripMenuItem.Text = "Roles";
            rolesToolStripMenuItem.Click += rolesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(119, 6);
            // 
            // branchesToolStripMenuItem
            // 
            branchesToolStripMenuItem.Image = (Image)resources.GetObject("branchesToolStripMenuItem.Image");
            branchesToolStripMenuItem.Name = "branchesToolStripMenuItem";
            branchesToolStripMenuItem.Size = new Size(122, 22);
            branchesToolStripMenuItem.Text = "Branches";
            branchesToolStripMenuItem.Click += branchesToolStripMenuItem_Click;
            // 
            // dEMOSToolStripMenuItem
            // 
            dEMOSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { progressBarToolStripMenuItem, toolStripMenuItem1, customMessageBoxOKToolStripMenuItem, customMessageBoxWarningToolStripMenuItem, customMessageBoxYesNoToolStripMenuItem, customMessageBoxYesNoCancelToolStripMenuItem, toolStripSeparator1, askForAStringDialogBoxToolStripMenuItem, askForAPasswordDialogBoxToolStripMenuItem, askForADateValueToolStripMenuItem, askForAnIntegerToolStripMenuItem, askForADoubleValueToolStripMenuItem, toolStripMenuItem5, pickItemToolStripMenuItem });
            dEMOSToolStripMenuItem.Name = "dEMOSToolStripMenuItem";
            dEMOSToolStripMenuItem.Size = new Size(59, 20);
            dEMOSToolStripMenuItem.Text = "DEMOS";
            // 
            // progressBarToolStripMenuItem
            // 
            progressBarToolStripMenuItem.Name = "progressBarToolStripMenuItem";
            progressBarToolStripMenuItem.Size = new Size(265, 22);
            progressBarToolStripMenuItem.Text = "Indeterminate Progress Bar";
            progressBarToolStripMenuItem.Click += progressBarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(262, 6);
            // 
            // customMessageBoxOKToolStripMenuItem
            // 
            customMessageBoxOKToolStripMenuItem.Name = "customMessageBoxOKToolStripMenuItem";
            customMessageBoxOKToolStripMenuItem.Size = new Size(265, 22);
            customMessageBoxOKToolStripMenuItem.Text = "Custom Message Box (OK)";
            customMessageBoxOKToolStripMenuItem.Click += customMessageBoxOKToolStripMenuItem_Click;
            // 
            // customMessageBoxWarningToolStripMenuItem
            // 
            customMessageBoxWarningToolStripMenuItem.Name = "customMessageBoxWarningToolStripMenuItem";
            customMessageBoxWarningToolStripMenuItem.Size = new Size(265, 22);
            customMessageBoxWarningToolStripMenuItem.Text = "Custom Message Box (Warning)";
            customMessageBoxWarningToolStripMenuItem.Click += customMessageBoxWarningToolStripMenuItem_Click;
            // 
            // customMessageBoxYesNoToolStripMenuItem
            // 
            customMessageBoxYesNoToolStripMenuItem.Name = "customMessageBoxYesNoToolStripMenuItem";
            customMessageBoxYesNoToolStripMenuItem.Size = new Size(265, 22);
            customMessageBoxYesNoToolStripMenuItem.Text = "Custom Message Box (YesNo)";
            customMessageBoxYesNoToolStripMenuItem.Click += customMessageBoxYesNoToolStripMenuItem_Click;
            // 
            // customMessageBoxYesNoCancelToolStripMenuItem
            // 
            customMessageBoxYesNoCancelToolStripMenuItem.Name = "customMessageBoxYesNoCancelToolStripMenuItem";
            customMessageBoxYesNoCancelToolStripMenuItem.Size = new Size(265, 22);
            customMessageBoxYesNoCancelToolStripMenuItem.Text = "Custom MessageBox (YesNoCancel)";
            customMessageBoxYesNoCancelToolStripMenuItem.Click += customMessageBoxYesNoCancelToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(262, 6);
            // 
            // askForAStringDialogBoxToolStripMenuItem
            // 
            askForAStringDialogBoxToolStripMenuItem.Name = "askForAStringDialogBoxToolStripMenuItem";
            askForAStringDialogBoxToolStripMenuItem.Size = new Size(265, 22);
            askForAStringDialogBoxToolStripMenuItem.Text = "Ask for a String Dialog box";
            askForAStringDialogBoxToolStripMenuItem.Click += askForAStringDialogBoxToolStripMenuItem_Click;
            // 
            // askForAPasswordDialogBoxToolStripMenuItem
            // 
            askForAPasswordDialogBoxToolStripMenuItem.Name = "askForAPasswordDialogBoxToolStripMenuItem";
            askForAPasswordDialogBoxToolStripMenuItem.Size = new Size(265, 22);
            askForAPasswordDialogBoxToolStripMenuItem.Text = "Ask for  a Password Dialog box";
            askForAPasswordDialogBoxToolStripMenuItem.Click += askForAPasswordDialogBoxToolStripMenuItem_Click;
            // 
            // askForADateValueToolStripMenuItem
            // 
            askForADateValueToolStripMenuItem.Name = "askForADateValueToolStripMenuItem";
            askForADateValueToolStripMenuItem.Size = new Size(265, 22);
            askForADateValueToolStripMenuItem.Text = "Ask for a Date Value";
            askForADateValueToolStripMenuItem.Click += askForADateValueToolStripMenuItem_Click;
            // 
            // askForAnIntegerToolStripMenuItem
            // 
            askForAnIntegerToolStripMenuItem.Name = "askForAnIntegerToolStripMenuItem";
            askForAnIntegerToolStripMenuItem.Size = new Size(265, 22);
            askForAnIntegerToolStripMenuItem.Text = "Ask for an Integer";
            askForAnIntegerToolStripMenuItem.Click += askForAnIntegerToolStripMenuItem_Click;
            // 
            // askForADoubleValueToolStripMenuItem
            // 
            askForADoubleValueToolStripMenuItem.Name = "askForADoubleValueToolStripMenuItem";
            askForADoubleValueToolStripMenuItem.Size = new Size(265, 22);
            askForADoubleValueToolStripMenuItem.Text = "Ask for a Double Value";
            askForADoubleValueToolStripMenuItem.Click += askForADoubleValueToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(262, 6);
            // 
            // pickItemToolStripMenuItem
            // 
            pickItemToolStripMenuItem.Name = "pickItemToolStripMenuItem";
            pickItemToolStripMenuItem.Size = new Size(265, 22);
            pickItemToolStripMenuItem.Text = "Pick Item";
            pickItemToolStripMenuItem.Click += pickItemToolStripMenuItem_Click;
            // 
            // ToolStripTop
            // 
            ToolStripTop.Items.AddRange(new ToolStripItem[] { btnExit, btnMinimize, btnLockout, btnLogout, toolStripSeparator3, toolStripSeparator4, btnVendor, btnCustomers, btnDepartment, tspChangeBranch, btnItems, btnTransactions });
            ToolStripTop.Location = new Point(0, 24);
            ToolStripTop.Name = "ToolStripTop";
            ToolStripTop.Size = new Size(1569, 43);
            ToolStripTop.TabIndex = 1;
            ToolStripTop.Text = "toolStripTop";
            // 
            // btnExit
            // 
            btnExit.Alignment = ToolStripItemAlignment.Right;
            btnExit.AutoSize = false;
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageScaling = ToolStripItemImageScaling.None;
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(45, 40);
            btnExit.ToolTipText = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Alignment = ToolStripItemAlignment.Right;
            btnMinimize.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.ImageTransparentColor = Color.Magenta;
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(23, 40);
            btnMinimize.Text = "Minimize";
            btnMinimize.ToolTipText = "Minimize";
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnLockout
            // 
            btnLockout.Alignment = ToolStripItemAlignment.Right;
            btnLockout.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLockout.Image = (Image)resources.GetObject("btnLockout.Image");
            btnLockout.ImageTransparentColor = Color.Magenta;
            btnLockout.Name = "btnLockout";
            btnLockout.Size = new Size(23, 40);
            btnLockout.ToolTipText = "Lock Out";
            btnLockout.Click += btnLockout_Click;
            // 
            // btnLogout
            // 
            btnLogout.Alignment = ToolStripItemAlignment.Right;
            btnLogout.AutoSize = false;
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.TopCenter;
            btnLogout.ImageScaling = ToolStripItemImageScaling.None;
            btnLogout.ImageTransparentColor = Color.Magenta;
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(45, 40);
            btnLogout.TextImageRelation = TextImageRelation.Overlay;
            btnLogout.ToolTipText = "Logout User";
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 43);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 43);
            // 
            // btnVendor
            // 
            btnVendor.Image = (Image)resources.GetObject("btnVendor.Image");
            btnVendor.ImageTransparentColor = Color.Magenta;
            btnVendor.Name = "btnVendor";
            btnVendor.Size = new Size(69, 40);
            btnVendor.Text = "Vendors";
            btnVendor.Click += btnVendor_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Image = (Image)resources.GetObject("btnCustomers.Image");
            btnCustomers.ImageTransparentColor = Color.Magenta;
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(84, 40);
            btnCustomers.Text = "Customers";
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnDepartment
            // 
            btnDepartment.Image = (Image)resources.GetObject("btnDepartment.Image");
            btnDepartment.ImageTransparentColor = Color.Magenta;
            btnDepartment.Name = "btnDepartment";
            btnDepartment.Size = new Size(95, 40);
            btnDepartment.Text = "Departments";
            btnDepartment.Click += btnDepartment_Click;
            // 
            // tspChangeBranch
            // 
            tspChangeBranch.Alignment = ToolStripItemAlignment.Right;
            tspChangeBranch.Image = (Image)resources.GetObject("tspChangeBranch.Image");
            tspChangeBranch.ImageTransparentColor = Color.Magenta;
            tspChangeBranch.Name = "tspChangeBranch";
            tspChangeBranch.Size = new Size(108, 40);
            tspChangeBranch.Text = "Change Branch";
            tspChangeBranch.Click += tspChangeBranch_Click;
            // 
            // btnItems
            // 
            btnItems.Alignment = ToolStripItemAlignment.Right;
            btnItems.DropDownItems.AddRange(new ToolStripItem[] { activeItemsToolStripMenuItem, inActiveItemsToolStripMenuItem, toolStripMenuItem6, itemClassificationsToolStripMenuItem, priceCategoriesToolStripMenuItem });
            btnItems.Image = (Image)resources.GetObject("btnItems.Image");
            btnItems.ImageTransparentColor = Color.Magenta;
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(118, 40);
            btnItems.Text = "Inventory Items";
            // 
            // activeItemsToolStripMenuItem
            // 
            activeItemsToolStripMenuItem.Name = "activeItemsToolStripMenuItem";
            activeItemsToolStripMenuItem.Size = new Size(180, 22);
            activeItemsToolStripMenuItem.Text = "Active Items";
            activeItemsToolStripMenuItem.Click += activeItemsToolStripMenuItem_Click;
            // 
            // inActiveItemsToolStripMenuItem
            // 
            inActiveItemsToolStripMenuItem.Name = "inActiveItemsToolStripMenuItem";
            inActiveItemsToolStripMenuItem.Size = new Size(180, 22);
            inActiveItemsToolStripMenuItem.Text = "InActive Items";
            inActiveItemsToolStripMenuItem.Click += inActiveItemsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(177, 6);
            // 
            // itemClassificationsToolStripMenuItem
            // 
            itemClassificationsToolStripMenuItem.Name = "itemClassificationsToolStripMenuItem";
            itemClassificationsToolStripMenuItem.Size = new Size(180, 22);
            itemClassificationsToolStripMenuItem.Text = "Item Classifications";
            itemClassificationsToolStripMenuItem.Click += btnClassifications_Click;
            // 
            // priceCategoriesToolStripMenuItem
            // 
            priceCategoriesToolStripMenuItem.Name = "priceCategoriesToolStripMenuItem";
            priceCategoriesToolStripMenuItem.Size = new Size(180, 22);
            priceCategoriesToolStripMenuItem.Text = "Price Categories";
            priceCategoriesToolStripMenuItem.Click += priceCategoriesToolStripMenuItem_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.Alignment = ToolStripItemAlignment.Right;
            btnTransactions.DropDownItems.AddRange(new ToolStripItem[] { requestForItemToolStripMenuItem, toolStripSeparator5, purchaseOrderToolStripMenuItem, receivingReportToolStripMenuItem, toolStripMenuItem4, toolStripSeparator6, warehouseIssuanceToolStripMenuItem, warehouseAdjustmentToolStripMenuItem, toolStripSeparator7, branchTransferOutgoingToolStripMenuItem, branchTransferIncomingToolStripMenuItem });
            btnTransactions.Image = (Image)resources.GetObject("btnTransactions.Image");
            btnTransactions.ImageTransparentColor = Color.Magenta;
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(101, 40);
            btnTransactions.Text = "Transactions";
            // 
            // requestForItemToolStripMenuItem
            // 
            requestForItemToolStripMenuItem.Name = "requestForItemToolStripMenuItem";
            requestForItemToolStripMenuItem.Size = new Size(217, 22);
            requestForItemToolStripMenuItem.Text = "Request for Items";
            requestForItemToolStripMenuItem.ToolTipText = "Request for Items";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(214, 6);
            // 
            // purchaseOrderToolStripMenuItem
            // 
            purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            purchaseOrderToolStripMenuItem.Size = new Size(217, 22);
            purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            purchaseOrderToolStripMenuItem.Click += purchaseOrderToolStripMenuItem_Click;
            // 
            // receivingReportToolStripMenuItem
            // 
            receivingReportToolStripMenuItem.Name = "receivingReportToolStripMenuItem";
            receivingReportToolStripMenuItem.Size = new Size(217, 22);
            receivingReportToolStripMenuItem.Text = "Receiving Report";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(217, 22);
            toolStripMenuItem4.Text = "Purchase Returns";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(214, 6);
            // 
            // warehouseIssuanceToolStripMenuItem
            // 
            warehouseIssuanceToolStripMenuItem.Name = "warehouseIssuanceToolStripMenuItem";
            warehouseIssuanceToolStripMenuItem.Size = new Size(217, 22);
            warehouseIssuanceToolStripMenuItem.Text = "Warehouse Issuance";
            // 
            // warehouseAdjustmentToolStripMenuItem
            // 
            warehouseAdjustmentToolStripMenuItem.Name = "warehouseAdjustmentToolStripMenuItem";
            warehouseAdjustmentToolStripMenuItem.Size = new Size(217, 22);
            warehouseAdjustmentToolStripMenuItem.Text = "Warehouse Adjustment";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(214, 6);
            // 
            // branchTransferOutgoingToolStripMenuItem
            // 
            branchTransferOutgoingToolStripMenuItem.Name = "branchTransferOutgoingToolStripMenuItem";
            branchTransferOutgoingToolStripMenuItem.Size = new Size(217, 22);
            branchTransferOutgoingToolStripMenuItem.Text = "Branch Transfer - Outgoing";
            // 
            // branchTransferIncomingToolStripMenuItem
            // 
            branchTransferIncomingToolStripMenuItem.Name = "branchTransferIncomingToolStripMenuItem";
            branchTransferIncomingToolStripMenuItem.Size = new Size(217, 22);
            branchTransferIncomingToolStripMenuItem.Text = "Branch Transfer - Incoming";
            // 
            // toolStripBottom
            // 
            toolStripBottom.Dock = DockStyle.Bottom;
            toolStripBottom.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtUserName, toolStripLabel2, txtServer, toolStripLabel3, txtBranch });
            toolStripBottom.Location = new Point(0, 494);
            toolStripBottom.Name = "toolStripBottom";
            toolStripBottom.Size = new Size(1569, 25);
            toolStripBottom.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(33, 22);
            toolStripLabel1.Text = "User:";
            // 
            // txtUserName
            // 
            txtUserName.Name = "txtUserName";
            txtUserName.ReadOnly = true;
            txtUserName.Size = new Size(116, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(42, 22);
            toolStripLabel2.Text = "Server:";
            // 
            // txtServer
            // 
            txtServer.AutoSize = false;
            txtServer.Name = "txtServer";
            txtServer.ReadOnly = true;
            txtServer.Size = new Size(233, 23);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(44, 22);
            toolStripLabel3.Text = "Branch";
            // 
            // txtBranch
            // 
            txtBranch.Name = "txtBranch";
            txtBranch.ReadOnly = true;
            txtBranch.Size = new Size(116, 25);
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1569, 519);
            ControlBox = false;
            Controls.Add(toolStripBottom);
            Controls.Add(ToolStripTop);
            Controls.Add(MainMenu);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = MainMenu;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMain";
            Text = "RoyTek Project";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ToolStripTop.ResumeLayout(false);
            ToolStripTop.PerformLayout();
            toolStripBottom.ResumeLayout(false);
            toolStripBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem SystemToolItem;
        private System.Windows.Forms.ToolStripMenuItem LOGoutMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStripTop;
        private System.Windows.Forms.ToolStrip toolStripBottom;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditUserProfile;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtUserName;
        private System.Windows.Forms.ToolStripMenuItem dEMOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnLogout;
        private System.Windows.Forms.ToolStripMenuItem toolStripChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customMessageBoxOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customMessageBoxWarningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customMessageBoxYesNoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customMessageBoxYesNoCancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripAdmin;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripSystem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripEditUserProfile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripChangeUserPassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStriplogoutUser;
        private System.Windows.Forms.ToolStripMenuItem ToolStripexit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtServer;
        private System.Windows.Forms.ToolStripButton btnLockout;
        private System.Windows.Forms.ToolStripButton btnMinimize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem askForAStringDialogBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askForAPasswordDialogBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askForADateValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askForAnIntegerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askForADoubleValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem branchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnVendor;
        private System.Windows.Forms.ToolStripButton btnCustomers;
        private System.Windows.Forms.ToolStripButton btnDepartment;
        private System.Windows.Forms.ToolStripDropDownButton btnTransactions;
        private System.Windows.Forms.ToolStripMenuItem requestForItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem warehouseIssuanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehouseAdjustmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem branchTransferOutgoingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchTransferIncomingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripDropDownButton btnItems;
        private System.Windows.Forms.ToolStripMenuItem activeItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inActiveItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tspChangeBranch;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox txtBranch;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem pickItemToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem priceCategoriesToolStripMenuItem;
        private ToolStripMenuItem itemClassificationsToolStripMenuItem;
    }
}

