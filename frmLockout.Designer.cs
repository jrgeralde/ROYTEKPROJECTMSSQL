
namespace RoyTekProjectSQL
{
    partial class frmLockout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLockout));
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtLoginName = new TextBox();
            txtPassword = new TextBox();
            btnShowHide = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogin.DialogResult = DialogResult.OK;
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Green;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new Point(324, 88);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 47);
            btnLogin.TabIndex = 2;
            btnLogin.TextAlign = ContentAlignment.TopCenter;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(10, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 16);
            label1.TabIndex = 2;
            label1.Text = "Login Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(10, 46);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 16);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtLoginName
            // 
            txtLoginName.CharacterCasing = CharacterCasing.Upper;
            txtLoginName.Enabled = false;
            txtLoginName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLoginName.Location = new Point(115, 12);
            txtLoginName.Margin = new Padding(4, 3, 4, 3);
            txtLoginName.Name = "txtLoginName";
            txtLoginName.ReadOnly = true;
            txtLoginName.Size = new Size(201, 22);
            txtLoginName.TabIndex = 0;
            txtLoginName.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(115, 43);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(201, 22);
            txtPassword.TabIndex = 0;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnShowHide
            // 
            btnShowHide.BackColor = SystemColors.ButtonHighlight;
            btnShowHide.ImageAlign = ContentAlignment.MiddleLeft;
            btnShowHide.ImageIndex = 0;
            btnShowHide.ImageList = imageList1;
            btnShowHide.Location = new Point(324, 43);
            btnShowHide.Margin = new Padding(4, 3, 4, 3);
            btnShowHide.Name = "btnShowHide";
            btnShowHide.Size = new Size(82, 28);
            btnShowHide.TabIndex = 6;
            btnShowHide.TabStop = false;
            btnShowHide.Text = "Show";
            btnShowHide.UseVisualStyleBackColor = false;
            btnShowHide.Click += btnShowHide_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "eye-icon-1463.png");
            imageList1.Images.SetKeyName(1, "ClosedEye.jpg");
            // 
            // frmLockout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.OldLace;
            ClientSize = new Size(416, 145);
            ControlBox = false;
            Controls.Add(btnShowHide);
            Controls.Add(txtPassword);
            Controls.Add(txtLoginName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLockout";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lock Out User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.ImageList imageList1;
    }
}