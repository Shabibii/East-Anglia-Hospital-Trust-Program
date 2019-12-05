namespace Software_Engineering_Assignment.CustomControls
{
    partial class DoctorRegistrationFieldControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.staffIcon = new System.Windows.Forms.PictureBox();
            this.staffNameText = new System.Windows.Forms.Label();
            this.staffIdText = new System.Windows.Forms.Label();
            this.deregisterButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.dateRegisterActivity = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.staffIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // staffIcon
            // 
            this.staffIcon.Image = global::Software_Engineering_Assignment.Properties.Resources.yumminky_pc_43_512;
            this.staffIcon.Location = new System.Drawing.Point(3, 3);
            this.staffIcon.Name = "staffIcon";
            this.staffIcon.Size = new System.Drawing.Size(83, 94);
            this.staffIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffIcon.TabIndex = 0;
            this.staffIcon.TabStop = false;
            // 
            // staffNameText
            // 
            this.staffNameText.AutoSize = true;
            this.staffNameText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffNameText.Location = new System.Drawing.Point(103, 18);
            this.staffNameText.Name = "staffNameText";
            this.staffNameText.Size = new System.Drawing.Size(78, 17);
            this.staffNameText.TabIndex = 1;
            this.staffNameText.Text = "Staff Name";
            // 
            // staffIdText
            // 
            this.staffIdText.AutoSize = true;
            this.staffIdText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIdText.Location = new System.Drawing.Point(104, 59);
            this.staffIdText.Name = "staffIdText";
            this.staffIdText.Size = new System.Drawing.Size(57, 17);
            this.staffIdText.TabIndex = 2;
            this.staffIdText.Text = "Staff ID";
            // 
            // deregisterButton
            // 
            this.deregisterButton.BackColor = System.Drawing.Color.Red;
            this.deregisterButton.FlatAppearance.BorderSize = 0;
            this.deregisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deregisterButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deregisterButton.Location = new System.Drawing.Point(358, 57);
            this.deregisterButton.Name = "deregisterButton";
            this.deregisterButton.Size = new System.Drawing.Size(72, 23);
            this.deregisterButton.TabIndex = 4;
            this.deregisterButton.Text = "Deregister";
            this.deregisterButton.UseVisualStyleBackColor = false;
            this.deregisterButton.Click += new System.EventHandler(this.deregisterButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Green;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(358, 18);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(72, 23);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // dateRegisterActivity
            // 
            this.dateRegisterActivity.Location = new System.Drawing.Point(193, 39);
            this.dateRegisterActivity.Name = "dateRegisterActivity";
            this.dateRegisterActivity.Size = new System.Drawing.Size(135, 20);
            this.dateRegisterActivity.TabIndex = 8;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(244, 26);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(34, 15);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_Engineering_Assignment.Properties.Resources.icons8_lock_1003;
            this.pictureBox1.Location = new System.Drawing.Point(334, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Software_Engineering_Assignment.Properties.Resources.icons8_lock_1003;
            this.pictureBox2.Location = new System.Drawing.Point(334, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // DoctorRegistrationFieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateRegisterActivity);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.deregisterButton);
            this.Controls.Add(this.staffIdText);
            this.Controls.Add(this.staffNameText);
            this.Controls.Add(this.staffIcon);
            this.Name = "DoctorRegistrationFieldControl";
            this.Size = new System.Drawing.Size(438, 100);
            ((System.ComponentModel.ISupportInitialize)(this.staffIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox staffIcon;
        private System.Windows.Forms.Label staffNameText;
        private System.Windows.Forms.Label staffIdText;
        private System.Windows.Forms.DateTimePicker dateRegisterActivity;
        private System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.Button registerButton;
        public System.Windows.Forms.Button deregisterButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
