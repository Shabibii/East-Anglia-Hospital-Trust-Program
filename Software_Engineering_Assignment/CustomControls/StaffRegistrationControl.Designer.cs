namespace Software_Engineering_Assignment.CustomControls
{
    partial class StaffRegistrationControl
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
            this.searchBoxLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.staffRegisterList = new System.Windows.Forms.FlowLayoutPanel();
            this.searchStaffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBoxLabel
            // 
            this.searchBoxLabel.AutoSize = true;
            this.searchBoxLabel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxLabel.Location = new System.Drawing.Point(64, 12);
            this.searchBoxLabel.Name = "searchBoxLabel";
            this.searchBoxLabel.Size = new System.Drawing.Size(148, 15);
            this.searchBoxLabel.TabIndex = 0;
            this.searchBoxLabel.Text = "Search by Name / Staff ID:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(218, 10);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(130, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // staffRegisterList
            // 
            this.staffRegisterList.AutoScroll = true;
            this.staffRegisterList.Location = new System.Drawing.Point(0, 46);
            this.staffRegisterList.Name = "staffRegisterList";
            this.staffRegisterList.Size = new System.Drawing.Size(461, 489);
            this.staffRegisterList.TabIndex = 2;
            // 
            // searchStaffButton
            // 
            this.searchStaffButton.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.searchStaffButton.Location = new System.Drawing.Point(354, 10);
            this.searchStaffButton.Name = "searchStaffButton";
            this.searchStaffButton.Size = new System.Drawing.Size(70, 20);
            this.searchStaffButton.TabIndex = 3;
            this.searchStaffButton.Text = "Search";
            this.searchStaffButton.UseVisualStyleBackColor = true;
            this.searchStaffButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // StaffRegistrationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.searchStaffButton);
            this.Controls.Add(this.staffRegisterList);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchBoxLabel);
            this.Name = "StaffRegistrationControl";
            this.Size = new System.Drawing.Size(464, 538);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchBoxLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.FlowLayoutPanel staffRegisterList;
        private System.Windows.Forms.Button searchStaffButton;
    }
}
