namespace Software_Engineering_Assignment.CustomControls
{
    partial class UnregisteredStaffControl
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
            this.calendarUnregistered = new System.Windows.Forms.MonthCalendar();
            this.unregisteredStaffLabel = new System.Windows.Forms.Label();
            this.staffUnregisterList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // calendarUnregistered
            // 
            this.calendarUnregistered.Location = new System.Drawing.Point(264, 9);
            this.calendarUnregistered.Name = "calendarUnregistered";
            this.calendarUnregistered.TabIndex = 5;
            // 
            // unregisteredStaffLabel
            // 
            this.unregisteredStaffLabel.AutoSize = true;
            this.unregisteredStaffLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unregisteredStaffLabel.Location = new System.Drawing.Point(5, 6);
            this.unregisteredStaffLabel.Name = "unregisteredStaffLabel";
            this.unregisteredStaffLabel.Size = new System.Drawing.Size(104, 15);
            this.unregisteredStaffLabel.TabIndex = 4;
            this.unregisteredStaffLabel.Text = "Unregistered Staff";
            // 
            // staffUnregisterList
            // 
            this.staffUnregisterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffUnregisterList.HideSelection = false;
            this.staffUnregisterList.Location = new System.Drawing.Point(3, 24);
            this.staffUnregisterList.Name = "staffUnregisterList";
            this.staffUnregisterList.Size = new System.Drawing.Size(246, 264);
            this.staffUnregisterList.TabIndex = 6;
            this.staffUnregisterList.UseCompatibleStateImageBehavior = false;
            // 
            // UnregisteredStaffControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.staffUnregisterList);
            this.Controls.Add(this.calendarUnregistered);
            this.Controls.Add(this.unregisteredStaffLabel);
            this.Name = "UnregisteredStaffControl";
            this.Size = new System.Drawing.Size(500, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarUnregistered;
        private System.Windows.Forms.Label unregisteredStaffLabel;
        public System.Windows.Forms.ListView staffUnregisterList;
    }
}
