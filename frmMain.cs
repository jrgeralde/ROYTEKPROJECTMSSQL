using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyTekProjectSQL
{
    public partial class frmMain : Form
    {
        frmLogin fm;   // login form
        public frmMain()
        {
            InitializeComponent();
            Globals.glInitializeVariables();
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            bool mustchangepwd = false;

            Globals.glInitializeVariables();
            Globals.gLoginName = "";

            frmLogin frm = new frmLogin();

            if (frm.ShowDialog() == DialogResult.Abort)
            {

                this.Close();
            }

            // frm = null;
            frm.Dispose();
            if (Globals.gLoginName != null)
            {
                this.txtUserName.Text = Globals.gLoginName;
            }

            if (Globals.gdbServerName != null)
            {
                this.txtServer.Text = Globals.gdbServerName;
            }

            Globals.glSetUserInitialBranch();
            this.txtBranch.Text = Globals.gBranchName;
            this.Text = Globals.gBranchName + " Branch";


            this.glSetSizeToDesktop();
            this.BringToFront();

            Globals.glUserMustChangePwd(Globals.gIdUser, ref mustchangepwd);

            if (mustchangepwd)
            {
                csMessageBox.Show("You are advised to change password",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.toolStripChangePassword.PerformClick();

                Globals.glRemoveMustChangePwd(Globals.gIdUser);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (csMessageBox.Show("Exit from this application?", "Please confirm.",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void LOGoutMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dgresult;

            this.fm = new frmLogin();

            dgresult = this.fm.ShowDialog();

            if (dgresult == DialogResult.Abort)
                this.Close();

            if (dgresult == DialogResult.OK)
            {
                if (Globals.gLoginName != null)
                    this.txtUserName.Text = Globals.gLoginName;

                if (Globals.gdbServerName != null)
                    this.txtServer.Text = Globals.gdbServerName;
            }

            Globals.glSetUserInitialBranch();
            this.txtBranch.Text = Globals.gBranchName;

            this.glSetSizeToDesktop();
            this.BringToFront();
        }

        void TestDelay()
        {
            Thread.Sleep(10000);
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmWait frm = new frmWait(TestDelay, "Test delay..."))
            {
                frm.ShowDialog(this);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.exitToolStripMenuItem.PerformClick();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.LOGoutMenuItem.PerformClick();
        }

        private frmUserProfile UserProfilefrm;
        private void toolStripEditUserProfile_Click(object sender, EventArgs e)
        {
            if (UserProfilefrm == null)
            {
                UserProfilefrm = new frmUserProfile();
                UserProfilefrm.MdiParent = this;

                UserProfilefrm.FormClosed += UserProfilefrm_FormClosed;

                UserProfilefrm.Show();
            }
            else UserProfilefrm.Activate();

            this.txtUserName.Text = Globals.gLoginName;

        }

        private void UserProfilefrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserProfilefrm.Dispose();

            this.txtUserName.Text = Globals.gLoginName;
        }

        public void updatetxtusername(String uname)
        {
            this.txtUserName.Text = Globals.gLoginName;
        }


        private frmChangePassword ChangePasswordfrm;

        private void toolStripChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordfrm = new frmChangePassword(Globals.gIdUser, Globals.gLoginName);
            ChangePasswordfrm.FormClosed += ChangePasswordfrm_FormClosed;

            ChangePasswordfrm.ShowDialog();
        }

        private void ChangePasswordfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChangePasswordfrm.Dispose();
        }

        private void customMessageBoxOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csMessageBox.Show("This a sample OK Message Box.", "Information",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customMessageBoxWarningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csMessageBox.Show("This a sample Warning Message Box.", "Warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void customMessageBoxYesNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csMessageBox.Show("This a sample YesNo Message Box.", "Please confirm.",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void customMessageBoxYesNoCancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            csMessageBox.Show("This a sample YesNoCancel Message Box.", "Please confirm.",
                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public frmUsers Usersfrm;
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Usersfrm == null)
            {
                Usersfrm = new frmUsers();
                Usersfrm.MdiParent = this;

                Usersfrm.FormClosed += Usersfrm_FormClosed;

                Usersfrm.Show();
            }
            else Usersfrm.Activate();
        }


        private void Usersfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Usersfrm.Dispose();
            Usersfrm = null;
        }




        private frmRoles Rolesfrm;

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] RolestoUse = new String[] { "ADMIN", "PROGADMIN" };

            if (Globals.gCheckUserRole(Globals.gIdUser, ref RolestoUse))
            {
                if (Rolesfrm == null)
                {
                    Rolesfrm = new frmRoles();
                    Rolesfrm.MdiParent = this;

                    Rolesfrm.FormClosed += Rolesfrm_FormClosed;
                    Rolesfrm.Show();
                }
                else Rolesfrm.Activate();

            }
            else csMessageBox.Show("You are not allowed to use this portion.",
              "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Rolesfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Rolesfrm.Dispose();
            Rolesfrm = null;
        }

        public void DisposeAllChildren(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
            return;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Globals.sqlconn != null) Globals.glCloseSqlConn();
        }

        private frmLockout fm2;
        private void btnLockout_Click(object sender, EventArgs e)
        {
            this.fm2 = new frmLockout(Globals.gLoginName);
            //fm2.LockOutResult = Globals.gLoginCannotEnter;

            if ((fm2.ShowDialog() == DialogResult.Abort) && (Globals.gLoginName != null))
            {
                //this.txtUserName.Text = Globals.gLoginName;
                this.txtServer.Text = Globals.gdbServerName;
            }

            this.glSetSizeToDesktop();
            this.BringToFront();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void askForAStringDialogBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            String retvalue = "";

            rs = AskDialog.AskString("Sample String", "Please type a value.", ref retvalue);
        }

        private void askForAPasswordDialogBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            String retvalue = "";

            rs = AskDialog.AskPassword("Please type a password.", ref retvalue);

        }

        private void askForADateValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            DateTime retvalue = Globals.glServerDatetime();

            rs = AskDialog.AskDate("Please type a date value.", ref retvalue);
        }

        private void askForAnIntegerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            long retvalue = 0;

            rs = AskDialog.AskInt("Please type an integer value .", 0, ref retvalue);


            csMessageBox.Show("The integer encoded is:" + retvalue.ToString("N0"), "Result",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void askForADoubleValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            double retvalue = 0;

            rs = AskDialog.AskFloat("Please type a float value .", "N4", 23323.232, ref retvalue);

            csMessageBox.Show("The float encoded is:" + retvalue.ToString("N4"), "Result",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private frmBranches Branchesfrm;
        private void branchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] RolestoUse = new String[] { "ADMIN", "PROGADMIN" };

            if (Globals.gCheckUserRole(Globals.gIdUser, ref RolestoUse))
            {
                if (Branchesfrm == null)
                {
                    Branchesfrm = new frmBranches();
                    Branchesfrm.MdiParent = this;

                    Branchesfrm.FormClosed += Branchesfrm_FormClosed;

                    Branchesfrm.Show();
                }
                else Branchesfrm.Activate();
            }
            else csMessageBox.Show("You are not allowed to use this portion.",
             "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Branchesfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Branchesfrm.Dispose();
            Branchesfrm = null;
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            frmDirectory Directoryfrm = new frmDirectory(Globals.gtypeVendor, Globals.gtitleVendor);
            Directoryfrm.MdiParent = this;

            Directoryfrm.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmDirectory Directoryfrm = new frmDirectory(Globals.gtypeCustomer, Globals.gtitleCustomer);
            Directoryfrm.MdiParent = this;

            Directoryfrm.Show();
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            frmDirectory Directoryfrm = new frmDirectory(Globals.gtypeDepartment, Globals.gtitleDepartment);
            Directoryfrm.MdiParent = this;

            Directoryfrm.Show();

        }

        private frmItemClasses ItemClassesfrm;
        private void btnClassifications_Click(object sender, EventArgs e)
        {

            if (ItemClassesfrm == null)
            {
                ItemClassesfrm = new frmItemClasses();
                ItemClassesfrm.MdiParent = this;

                ItemClassesfrm.FormClosed += ItemClassesfrm_FormClosed;

                ItemClassesfrm.Show();
            }
            else ItemClassesfrm.Activate();

        }

        private void ItemClassesfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ItemClassesfrm.Dispose();
            ItemClassesfrm = null;
        }

        //  private frmImaster2 Imaster2frm;
        private frmImaster2 Imaster2frm;
        private frmImaster2 ImasterinActivefrm;
        private void activeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Imaster2frm = new frmImaster2(1);
            Imaster2frm.MdiParent = this;

            Imaster2frm.FormClosed += Imasterfrm2_FormClosed;

            Imaster2frm.Show();

        }

        private void Imasterfrm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Imaster2frm.Dispose();
        }

        private void inActiveItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ImasterinActivefrm = new frmImaster2(0);
            ImasterinActivefrm.MdiParent = this;

            ImasterinActivefrm.FormClosed += ImasterinActivefrm_FormClosed;

            ImasterinActivefrm.Show();

        }

        private void ImasterinActivefrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ImasterinActivefrm.Dispose();
        }

        public frmPickUserBranch PickUserBranchfrm;

        private void tspChangeBranch_Click(object sender, EventArgs e)
        {

            if (PickUserBranchfrm == null)
            {
                PickUserBranchfrm = new frmPickUserBranch(Globals.gIdUser);
                // PickUserBranchfrm.MdiParent = this;

                PickUserBranchfrm.FormClosed += PickUserBranchfrm_FormClosed; ;

                PickUserBranchfrm.ShowDialog();

            }
            else PickUserBranchfrm.Activate();
        }

        private void PickUserBranchfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.txtBranch.Text = Globals.gBranchName;
            this.Text = Globals.gBranchName + " Branch";
            PickUserBranchfrm = null;
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummary_PO_RR Summary_PO_RRfrm = new frmSummary_PO_RR(
                Globals.gIdBranch, Globals.gBranchName,
                Globals.gPurchaseOrderType, Globals.gPurchaseOrderTitle);

            Summary_PO_RRfrm.MdiParent = this;

            Summary_PO_RRfrm.Show();

        }

        private void pickItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String lkstr = "";
            DialogResult rst, rst2;


            long iditem = 0;
            String itemdescription = "";
            String itemcode = "";
            String itemuom = "";
            float itemlat_cost = 0;
            String itemuompack = "";
            int itempackfactor = 0;
            float vatpercent = 0, srp1 = 0, srp2 = 0, srp3 = 0, srp4 = 0, srp5 = 0;

            rst = AskDialog.AskString("Search Items for:", "Search Items", ref lkstr);

            if (rst == DialogResult.OK)
            {
                rst2 = PickItem.Show(Globals.SearchbyName, "%" + lkstr.ToUpper().Trim() + "%",
                    ref iditem,
                    ref itemdescription,
                    ref itemcode,
                    ref itemuom,
                    ref itemlat_cost,
                    ref itemuompack,
                    ref itempackfactor,
                    ref vatpercent,
                    ref srp1,
                    ref srp2,
                    ref srp3,
                    ref srp4,
                    ref srp5
                    );

                if (rst2 == DialogResult.OK)
                {
                    MessageBox.Show("Item Picked:" + itemdescription);
                }
                else
                {
                    MessageBox.Show("Item pick is cancelled.");
                }


            }
        }

        private frmPriceCategories PriceCategoriesfrm;

        private void priceCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (PriceCategoriesfrm == null)
            {
                PriceCategoriesfrm = new frmPriceCategories();
                PriceCategoriesfrm.MdiParent = this;

                PriceCategoriesfrm.FormClosed += PriceCategoriesfrm_FormClosed;

                PriceCategoriesfrm.Show();
            }
            else PriceCategoriesfrm.Activate();

        }

        private void PriceCategoriesfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PriceCategoriesfrm.Dispose();
            PriceCategoriesfrm = null;
        }

    }
}
