
namespace RoyTekProjectSQL
{
    partial class frmMessageOK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageOK));
            pictureBox = new PictureBox();
            btnOK = new Button();
            txtMessage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(14, 14);
            pictureBox.Margin = new Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(124, 78);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.ButtonHighlight;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.Image = (Image)resources.GetObject("btnOK.Image");
            btnOK.ImageAlign = ContentAlignment.MiddleLeft;
            btnOK.Location = new Point(636, 113);
            btnOK.Margin = new Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(99, 51);
            btnOK.TabIndex = 0;
            btnOK.Text = "&Ok";
            btnOK.TextAlign = ContentAlignment.MiddleRight;
            btnOK.UseVisualStyleBackColor = false;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.OldLace;
            txtMessage.BorderStyle = BorderStyle.None;
            txtMessage.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.ForeColor = SystemColors.HotTrack;
            txtMessage.Location = new Point(145, 14);
            txtMessage.Margin = new Padding(4, 3, 4, 3);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(590, 78);
            txtMessage.TabIndex = 1;
            // 
            // frmMessageOK
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.OldLace;
            ClientSize = new Size(749, 178);
            ControlBox = false;
            Controls.Add(txtMessage);
            Controls.Add(btnOK);
            Controls.Add(pictureBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMessageOK";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmMessageOK";
            KeyDown += frmMessageOK_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMessage;
    }
}