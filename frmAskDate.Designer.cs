
namespace RoyTekProjectSQL
{
    partial class frmAskDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAskDate));
            btnOK = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            imageList1 = new ImageList(components);
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.ButtonHighlight;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.Image = (Image)resources.GetObject("btnOK.Image");
            btnOK.ImageAlign = ContentAlignment.MiddleLeft;
            btnOK.Location = new Point(46, 55);
            btnOK.Margin = new Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(99, 46);
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
            btnCancel.Location = new Point(152, 55);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 46);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "&Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(18, 18);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(107, 27);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Date Value";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "eye-icon-1463.png");
            imageList1.Images.SetKeyName(1, "ClosedEye.jpg");
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(128, 12);
            dateTimePicker1.Margin = new Padding(4, 3, 4, 3);
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 29);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // frmAskDate
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.OldLace;
            ClientSize = new Size(327, 112);
            ControlBox = false;
            Controls.Add(dateTimePicker1);
            Controls.Add(lblTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAskDate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAskDate";
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}