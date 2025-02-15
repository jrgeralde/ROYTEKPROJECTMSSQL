﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.Sql;
using Microsoft.Data.SqlClient;


using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyTekProjectSQL
{
    public partial class frmLockout : Form
    {
        // public int lockoutresult = 0;

        public frmLockout(String lname)
        {
            InitializeComponent();

            this.txtLoginName.Text = lname;
            SetTheme();
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


        public void SetTheme()
        {
            this.BackColor = Globals.gDialogBackgroundColor;

        }
        private void btnShowHide_Click(object sender, EventArgs e)
        {

            if (this.btnShowHide.Text == "Show")
            {
                this.btnShowHide.Text = "Hide";
                this.btnShowHide.ImageIndex = 1;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.btnShowHide.Text = "Show";
                this.btnShowHide.ImageIndex = 0;
                this.txtPassword.PasswordChar = '●';

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            String HashedPwd = "", ActualPwd = "", pwd = "";

            this.DialogResult = DialogResult.OK;

            if (this.txtLoginName.Text == "")
            {
                csMessageBox.Show("Please provide user name!", "Warning.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.DialogResult = DialogResult.None;
                this.txtLoginName.Focus();
            }
            else
            {
                try

                {
                    //Open SqlConnection

                    if (Globals.glOpenSqlConn())
                    {
                        SqlCommand cmd = new SqlCommand("Select id,loginname,password from USERS where LoginName=@LoginName and Active=1", Globals.sqlconn);
                        cmd.Parameters.AddWithValue("@LoginName", this.txtLoginName.Text);

                        SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();

                        adapt.Fill(ds);

                        int count = ds.Tables[0].Rows.Count;

                        if (count == 1)
                        {
                            pwd = this.txtPassword.Text.Trim();

                            HashedPwd = ds.Tables[0].Rows[0][2].ToString();
                            ActualPwd = Globals.DecodeFrom64(HashedPwd);

                            if (pwd == ActualPwd)
                            {
                                Globals.gIdUser = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());

                                Globals.gLoginName = ds.Tables[0].Rows[0][1].ToString();

                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                csMessageBox.Show("Please provide a valid password.", "Login Failed.",
                                    MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

                                this.DialogResult = DialogResult.None;
                                this.txtPassword.Focus();
                            }

                        }
                        else
                        {

                            csMessageBox.Show("Please provide a valid login name.", "Login Failed.",
                                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

                            this.DialogResult = DialogResult.None;
                            this.txtLoginName.Focus();
                        }

                    }
                }  // try

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } // else
        } // function

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.btnLogin.PerformClick();

            }
        }
    } // class
} // namespace
