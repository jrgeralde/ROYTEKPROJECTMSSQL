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
    public partial class frmMessageYesNoCancel : Form
    {
        public frmMessageYesNoCancel()
        {
            InitializeComponent();
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
            this.txtMessage.BackColor = Globals.gDialogBackgroundColor;

        }
        public Image MessageIcon
        {
            get { return this.pictureBox.Image; }
            set { this.pictureBox.Image = value; }
        }

        public string Message
        {
            get { return this.txtMessage.Text; }
            set { this.txtMessage.Text = value; }
        }

        private void btnYes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.btnCancel.PerformClick();


        }

        private void btnNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.btnCancel.PerformClick();

        }
    }
}
