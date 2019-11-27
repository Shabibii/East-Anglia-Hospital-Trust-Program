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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.staffUnregisterList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(269, 6);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unregistered Staff";
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
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Name = "UnregisteredStaffControl";
            this.Size = new System.Drawing.Size(500, 291);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView staffUnregisterList;
    }
}
