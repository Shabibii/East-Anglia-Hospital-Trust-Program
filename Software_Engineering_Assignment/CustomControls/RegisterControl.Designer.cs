namespace Software_Engineering_Assignment
{
    partial class RegisterControl
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
            this.components = new System.ComponentModel.Container();
            this.onCallStaffList = new System.Windows.Forms.ListView();
            this.Staff_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.onCallStaffLabel = new System.Windows.Forms.Label();
            this.refreshDisplayData = new System.Windows.Forms.Timer(this.components);
            this.eventLog = new System.Windows.Forms.TreeView();
            this.eventLogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // onCallStaffList
            // 
            this.onCallStaffList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.onCallStaffList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onCallStaffList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Staff_Name});
            this.onCallStaffList.HideSelection = false;
            this.onCallStaffList.Location = new System.Drawing.Point(0, 356);
            this.onCallStaffList.MultiSelect = false;
            this.onCallStaffList.Name = "onCallStaffList";
            this.onCallStaffList.Size = new System.Drawing.Size(475, 140);
            this.onCallStaffList.TabIndex = 1;
            this.onCallStaffList.UseCompatibleStateImageBehavior = false;
            // 
            // onCallStaffLabel
            // 
            this.onCallStaffLabel.AutoSize = true;
            this.onCallStaffLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onCallStaffLabel.Location = new System.Drawing.Point(3, 339);
            this.onCallStaffLabel.Name = "onCallStaffLabel";
            this.onCallStaffLabel.Size = new System.Drawing.Size(70, 14);
            this.onCallStaffLabel.TabIndex = 2;
            this.onCallStaffLabel.Text = "On Call Staff:";
            // 
            // refreshDisplayData
            // 
            this.refreshDisplayData.Interval = 4000;
            this.refreshDisplayData.Tick += new System.EventHandler(this.RefreshDisplayData_Tick);
            // 
            // eventLog
            // 
            this.eventLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.eventLog.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLog.Location = new System.Drawing.Point(0, 17);
            this.eventLog.Name = "eventLog";
            this.eventLog.PathSeparator = "";
            this.eventLog.ShowLines = false;
            this.eventLog.ShowPlusMinus = false;
            this.eventLog.ShowRootLines = false;
            this.eventLog.Size = new System.Drawing.Size(475, 319);
            this.eventLog.TabIndex = 3;
            // 
            // eventLogLabel
            // 
            this.eventLogLabel.AutoSize = true;
            this.eventLogLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLogLabel.Location = new System.Drawing.Point(3, 0);
            this.eventLogLabel.Name = "eventLogLabel";
            this.eventLogLabel.Size = new System.Drawing.Size(59, 14);
            this.eventLogLabel.TabIndex = 4;
            this.eventLogLabel.Text = "Event Log:";
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.eventLogLabel);
            this.Controls.Add(this.eventLog);
            this.Controls.Add(this.onCallStaffLabel);
            this.Controls.Add(this.onCallStaffList);
            this.MaximumSize = new System.Drawing.Size(475, 557);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(475, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView onCallStaffList;
        private System.Windows.Forms.Label onCallStaffLabel;
        private System.Windows.Forms.Timer refreshDisplayData;
        private System.Windows.Forms.ColumnHeader Staff_Name;
        private System.Windows.Forms.TreeView eventLog;
        private System.Windows.Forms.Label eventLogLabel;
    }
}
