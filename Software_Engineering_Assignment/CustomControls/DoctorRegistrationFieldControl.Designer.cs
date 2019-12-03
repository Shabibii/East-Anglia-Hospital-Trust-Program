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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.staffNameText = new System.Windows.Forms.Label();
            this.staffIdText = new System.Windows.Forms.Label();
            this.deregisterButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_Engineering_Assignment.Properties.Resources.yumminky_pc_43_512;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // staffNameText
            // 
            this.staffNameText.AutoSize = true;
            this.staffNameText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffNameText.Location = new System.Drawing.Point(110, 24);
            this.staffNameText.Name = "staffNameText";
            this.staffNameText.Size = new System.Drawing.Size(78, 17);
            this.staffNameText.TabIndex = 1;
            this.staffNameText.Text = "Staff Name";
            // 
            // staffIdText
            // 
            this.staffIdText.AutoSize = true;
            this.staffIdText.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIdText.Location = new System.Drawing.Point(110, 60);
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
            this.deregisterButton.Location = new System.Drawing.Point(358, 54);
            this.deregisterButton.Name = "deregisterButton";
            this.deregisterButton.Size = new System.Drawing.Size(72, 23);
            this.deregisterButton.TabIndex = 4;
            this.deregisterButton.Text = "Deregister";
            this.deregisterButton.UseVisualStyleBackColor = false;
            this.deregisterButton.Click += new System.EventHandler(this.UnregisterStaff_Click);
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
            this.registerButton.Click += new System.EventHandler(this.RegisterStaff_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(203, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date:";
            // 
            // DoctorRegistrationFieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.deregisterButton);
            this.Controls.Add(this.staffIdText);
            this.Controls.Add(this.staffNameText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DoctorRegistrationFieldControl";
            this.Size = new System.Drawing.Size(438, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label staffNameText;
        private System.Windows.Forms.Label staffIdText;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button registerButton;
        public System.Windows.Forms.Button deregisterButton;
    }
}
