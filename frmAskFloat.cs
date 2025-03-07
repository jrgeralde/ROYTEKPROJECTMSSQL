﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoyTekProjectSQL
{
    public partial class frmAskFloat : Form
    {
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
        public frmAskFloat()
        {
            InitializeComponent();
            SetTheme();

        }

        public string Title
        {
            get { return this.lblTitle.Text; }
            set { this.lblTitle.Text = value; }
        }
        public Double FloatValue
        {
            get { return Double.Parse(this.StrBox.Text); }
            set { this.StrBox.Text = value.ToString(); }
        }

        public String formatstr;
        public String FormatStr
        {
            get { return this.formatstr; }
            set { this.formatstr = value; }
        }
        private void StrBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsControl(ch) && !char.IsDigit(ch)
                && ch != 8 && ch != 127 && ch != '.' && ch != '-')
            {
                e.Handled = true;
            }

            // limit decimal points to only  one
            if ((ch == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // limit - negative signs to only  one
            if ((ch == '-'))
            {
                if ((sender as TextBox).Text.IndexOf('-') > -1)
                    e.Handled = true;
            }
        }

        private void frmAskFloat_Load(object sender, EventArgs e)
        {
            double dvalue;

            if (this.formatstr != "")
            {
                dvalue = Double.Parse(this.StrBox.Text);
                this.StrBox.Text = dvalue.ToString(this.formatstr);

            }
        }

        private void StrBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true; // PUT THE DING OFF
                this.btnCancel.PerformClick();

            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // PUT THE DING OFF
                this.btnOK.PerformClick();
            }
        }
    }
}
