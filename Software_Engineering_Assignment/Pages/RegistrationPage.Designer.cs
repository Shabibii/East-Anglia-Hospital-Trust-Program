namespace Software_Engineering_Assignment.Pages
{
    partial class RegistrationPage
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
            this.backButton = new System.Windows.Forms.Button();
            this.staffRegistrationControl = new Software_Engineering_Assignment.CustomControls.StaffRegistrationControl();
            this.unregisteredStaffControl = new Software_Engineering_Assignment.CustomControls.UnregisteredStaffControl();
            this.staffOnCallControl = new Software_Engineering_Assignment.CustomControls.OnCallStaffControl();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backButton.Location = new System.Drawing.Point(923, 552);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(64, 28);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // staffRegistrationControl
            // 
            this.staffRegistrationControl.BackColor = System.Drawing.Color.White;
            this.staffRegistrationControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staffRegistrationControl.Location = new System.Drawing.Point(523, 3);
            this.staffRegistrationControl.Name = "staffRegistrationControl";
            this.staffRegistrationControl.Size = new System.Drawing.Size(464, 531);
            this.staffRegistrationControl.TabIndex = 2;
            // 
            // unregisteredStaffControl
            // 
            this.unregisteredStaffControl.BackColor = System.Drawing.Color.White;
            this.unregisteredStaffControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.unregisteredStaffControl.Location = new System.Drawing.Point(3, 300);
            this.unregisteredStaffControl.Name = "unregisteredStaffControl";
            this.unregisteredStaffControl.Size = new System.Drawing.Size(500, 291);
            this.unregisteredStaffControl.TabIndex = 1;
            // 
            // staffOnCallControl
            // 
            this.staffOnCallControl.BackColor = System.Drawing.Color.White;
            this.staffOnCallControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.staffOnCallControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.staffOnCallControl.Location = new System.Drawing.Point(3, 3);
            this.staffOnCallControl.Name = "staffOnCallControl";
            this.staffOnCallControl.Size = new System.Drawing.Size(500, 291);
            this.staffOnCallControl.TabIndex = 0;
            // 
            // RegistrationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.staffRegistrationControl);
            this.Controls.Add(this.unregisteredStaffControl);
            this.Controls.Add(this.staffOnCallControl);
            this.Name = "RegistrationPage";
            this.Size = new System.Drawing.Size(1010, 595);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.OnCallStaffControl staffOnCallControl;
        private CustomControls.UnregisteredStaffControl unregisteredStaffControl;
        private CustomControls.StaffRegistrationControl staffRegistrationControl;
        private System.Windows.Forms.Button backButton;
    }
}
