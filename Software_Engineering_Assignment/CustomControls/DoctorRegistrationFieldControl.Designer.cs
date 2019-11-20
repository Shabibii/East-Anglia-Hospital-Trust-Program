namespace Software_Engineering_Assignment.CustomControls
{
    partial class doctorRegistrationFieldControl
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
            this.doctorName = new System.Windows.Forms.Label();
            this.staffId = new System.Windows.Forms.Label();
            this.deregisterButton = new System.Windows.Forms.Button();
            this.registerButton1 = new System.Windows.Forms.Button();
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
            // doctorName
            // 
            this.doctorName.AutoSize = true;
            this.doctorName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorName.Location = new System.Drawing.Point(110, 24);
            this.doctorName.Name = "doctorName";
            this.doctorName.Size = new System.Drawing.Size(78, 17);
            this.doctorName.TabIndex = 1;
            this.doctorName.Text = "Staff Name";
            // 
            // staffId
            // 
            this.staffId.AutoSize = true;
            this.staffId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffId.Location = new System.Drawing.Point(110, 60);
            this.staffId.Name = "staffId";
            this.staffId.Size = new System.Drawing.Size(57, 17);
            this.staffId.TabIndex = 2;
            this.staffId.Text = "Staff ID";
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
            this.deregisterButton.Click += new System.EventHandler(this.unregisterStaff);
            // 
            // registerButton1
            // 
            this.registerButton1.BackColor = System.Drawing.Color.Green;
            this.registerButton1.FlatAppearance.BorderSize = 0;
            this.registerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton1.Location = new System.Drawing.Point(358, 18);
            this.registerButton1.Name = "registerButton1";
            this.registerButton1.Size = new System.Drawing.Size(72, 23);
            this.registerButton1.TabIndex = 5;
            this.registerButton1.Text = "Register";
            this.registerButton1.UseVisualStyleBackColor = false;
            this.registerButton1.Click += new System.EventHandler(this.registerStaff);
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
            // doctorRegistrationFieldControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.registerButton1);
            this.Controls.Add(this.deregisterButton);
            this.Controls.Add(this.staffId);
            this.Controls.Add(this.doctorName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "doctorRegistrationFieldControl";
            this.Size = new System.Drawing.Size(438, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label doctorName;
        private System.Windows.Forms.Label staffId;
        private System.Windows.Forms.Button deregisterButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button registerButton1;        
    }
}
