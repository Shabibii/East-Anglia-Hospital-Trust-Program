namespace Software_Engineering_Assignment.Pages
{
    partial class RegisterationPage
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
            this.button2 = new System.Windows.Forms.Button();
            this.staffRegistrationControl1 = new Software_Engineering_Assignment.CustomControls.StaffRegistrationControl();
            this.unavailableStaff1 = new Software_Engineering_Assignment.CustomControls.UnregisteredStaffControl();
            this.staffAvailabilityControl1 = new Software_Engineering_Assignment.CustomControls.OnCallStaffControl();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(923, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // staffRegistrationControl1
            // 
            this.staffRegistrationControl1.BackColor = System.Drawing.Color.White;
            this.staffRegistrationControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staffRegistrationControl1.Location = new System.Drawing.Point(523, 3);
            this.staffRegistrationControl1.Name = "staffRegistrationControl1";
            this.staffRegistrationControl1.Size = new System.Drawing.Size(464, 531);
            this.staffRegistrationControl1.TabIndex = 2;
            // 
            // unavailableStaff1
            // 
            this.unavailableStaff1.BackColor = System.Drawing.Color.White;
            this.unavailableStaff1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unavailableStaff1.Location = new System.Drawing.Point(3, 300);
            this.unavailableStaff1.Name = "unavailableStaff1";
            this.unavailableStaff1.Size = new System.Drawing.Size(500, 291);
            this.unavailableStaff1.TabIndex = 1;
            // 
            // staffAvailabilityControl1
            // 
            this.staffAvailabilityControl1.BackColor = System.Drawing.Color.White;
            this.staffAvailabilityControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.staffAvailabilityControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.staffAvailabilityControl1.Location = new System.Drawing.Point(3, 3);
            this.staffAvailabilityControl1.Name = "staffAvailabilityControl1";
            this.staffAvailabilityControl1.Size = new System.Drawing.Size(500, 291);
            this.staffAvailabilityControl1.TabIndex = 0;
            // 
            // RegisterationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.staffRegistrationControl1);
            this.Controls.Add(this.unavailableStaff1);
            this.Controls.Add(this.staffAvailabilityControl1);
            this.Name = "RegisterationPage";
            this.Size = new System.Drawing.Size(1010, 595);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.OnCallStaffControl staffAvailabilityControl1;
        private CustomControls.UnregisteredStaffControl unavailableStaff1;
        private CustomControls.StaffRegistrationControl staffRegistrationControl1;
        private System.Windows.Forms.Button button2;
    }
}
