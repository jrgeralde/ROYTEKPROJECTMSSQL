
namespace RoyTekProjectSQL
{
    partial class frmMessageYesNoCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageYesNoCancel));
            pictureBox = new PictureBox();
            btnYes = new Button();
            btnNo = new Button();
            btnCancel = new Button();
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
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // btnYes
            // 
            btnYes.BackColor = SystemColors.ButtonHighlight;
            btnYes.DialogResult = DialogResult.Yes;
            btnYes.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnYes.Image = (Image)resources.GetObject("btnYes.Image");
            btnYes.ImageAlign = ContentAlignment.MiddleLeft;
            btnYes.Location = new Point(265, 113);
            btnYes.Margin = new Padding(4, 3, 4, 3);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(99, 51);
            btnYes.TabIndex = 2;
            btnYes.Text = "&Yes";
            btnYes.TextAlign = ContentAlignment.MiddleRight;
            btnYes.UseVisualStyleBackColor = false;
            btnYes.KeyUp += btnYes_KeyUp;
            // 
            // btnNo
            // 
            btnNo.BackColor = SystemColors.ButtonHighlight;
            btnNo.DialogResult = DialogResult.No;
            btnNo.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNo.Image = (Image)resources.GetObject("btnNo.Image");
            btnNo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNo.Location = new Point(371, 113);
            btnNo.Margin = new Padding(4, 3, 4, 3);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(99, 51);
            btnNo.TabIndex = 5;
            btnNo.Text = "&No";
            btnNo.TextAlign = ContentAlignment.MiddleRight;
            btnNo.UseVisualStyleBackColor = false;
            btnNo.KeyUp += btnNo_KeyUp;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonHighlight;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(477, 113);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 51);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.OldLace;
            txtMessage.BorderStyle = BorderStyle.None;
            txtMessage.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.ForeColor = SystemColors.HotTrack;
            txtMessage.Location = new Point(144, 14);
            txtMessage.Margin = new Padding(4, 3, 4, 3);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ReadOnly = true;
            txtMessage.Size = new Size(454, 78);
            txtMessage.TabIndex = 7;
            txtMessage.Text = "Message";
            // 
            // frmMessageYesNoCancel
            // 
            AcceptButton = btnYes;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(623, 178);
            ControlBox = false;
            Controls.Add(txtMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(pictureBox);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMessageYesNoCancel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmMessageYesNoCancel";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMessage;
    }
}