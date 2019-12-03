namespace Software_Engineering_Assignment.CustomControls
{
    partial class OnCallStaffControl
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
            this.onCallStaffLabel = new System.Windows.Forms.Label();
            this.calendarOnCallStaff = new System.Windows.Forms.MonthCalendar();
            this.StaffOncallList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // onCallStaffLabel
            // 
            this.onCallStaffLabel.AutoSize = true;
            this.onCallStaffLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onCallStaffLabel.Location = new System.Drawing.Point(0, 9);
            this.onCallStaffLabel.Name = "onCallStaffLabel";
            this.onCallStaffLabel.Size = new System.Drawing.Size(79, 15);
            this.onCallStaffLabel.TabIndex = 1;
            this.onCallStaffLabel.Text = "On Call Staff";
            // 
            // calendarOnCallStaff
            // 
            this.calendarOnCallStaff.Location = new System.Drawing.Point(264, 9);
            this.calendarOnCallStaff.Name = "calendarOnCallStaff";
            this.calendarOnCallStaff.TabIndex = 2;
            this.calendarOnCallStaff.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarOnCallStaff_DateChanged);
            // 
            // StaffOncallList
            // 
            this.StaffOncallList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StaffOncallList.HideSelection = false;
            this.StaffOncallList.Location = new System.Drawing.Point(0, 27);
            this.StaffOncallList.Name = "StaffOncallList";
            this.StaffOncallList.Size = new System.Drawing.Size(252, 261);
            this.StaffOncallList.TabIndex = 3;
            this.StaffOncallList.UseCompatibleStateImageBehavior = false;
            // 
            // OnCallStaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.StaffOncallList);
            this.Controls.Add(this.calendarOnCallStaff);
            this.Controls.Add(this.onCallStaffLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "OnCallStaffControl";
            this.Size = new System.Drawing.Size(500, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label onCallStaffLabel;
        private System.Windows.Forms.MonthCalendar calendarOnCallStaff;
        public System.Windows.Forms.ListView StaffOncallList;
    }
}
