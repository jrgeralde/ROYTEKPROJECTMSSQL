
namespace RoyTekProjectSQL
{
    partial class frmAskFloat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAskFloat));
            btnOK = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            StrBox = new TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.ButtonHighlight;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.Image = (Image)resources.GetObject("btnOK.Image");
            btnOK.ImageAlign = ContentAlignment.MiddleLeft;
            btnOK.Location = new Point(99, 51);
            btnOK.Margin = new Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(99, 48);
            btnOK.TabIndex = 1;
            btnOK.Text = "&OK";
            btnOK.TextAlign = ContentAlignment.MiddleRight;
            btnOK.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(205, 51);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 48);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "&Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(9, 16);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 27);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Enter Value";
            // 
            // StrBox
            // 
            StrBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StrBox.Location = new Point(128, 10);
            StrBox.Margin = new Padding(4, 3, 4, 3);
            StrBox.Name = "StrBox";
            StrBox.Size = new Size(258, 29);
            StrBox.TabIndex = 0;
            StrBox.KeyDown += StrBox_KeyDown;
            StrBox.KeyPress += StrBox_KeyPress;
            // 
            // frmAskFloat
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.OldLace;
            ClientSize = new Size(414, 111);
            ControlBox = false;
            Controls.Add(StrBox);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAskFloat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAskFloat";
            Load += frmAskFloat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox StrBox;
    }
}