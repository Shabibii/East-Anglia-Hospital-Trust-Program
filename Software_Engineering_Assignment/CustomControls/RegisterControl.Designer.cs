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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.onCallStaffList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshDisplayData = new System.Windows.Forms.Timer(this.components);
            this.Staff_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(475, 332);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Event Log:";
            // 
            // onCallStaffList
            // 
            this.onCallStaffList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.onCallStaffList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.onCallStaffList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Staff_Name});
            this.onCallStaffList.Location = new System.Drawing.Point(0, 356);
            this.onCallStaffList.MultiSelect = false;
            this.onCallStaffList.Name = "onCallStaffList";
            this.onCallStaffList.Size = new System.Drawing.Size(475, 140);
            this.onCallStaffList.TabIndex = 1;
            this.onCallStaffList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "On Call Staff:";
            // 
            // refreshDisplayData
            // 
            this.refreshDisplayData.Interval = 2000;
            this.refreshDisplayData.Tick += new System.EventHandler(this.RefreshDisplayData_Tick);
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onCallStaffList);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(475, 557);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(475, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView onCallStaffList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer refreshDisplayData;
        private System.Windows.Forms.ColumnHeader Staff_Name;
    }
}
