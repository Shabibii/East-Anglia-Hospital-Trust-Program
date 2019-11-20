namespace Software_Engineering_Assignment.Pages
{
    partial class ManagementPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvManagementInfo = new System.Windows.Forms.DataGridView();
            this.lblManagementTitle = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnManagementBack = new System.Windows.Forms.Button();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.tbxPatientID = new System.Windows.Forms.TextBox();
            this.dtpManagement = new System.Windows.Forms.DateTimePicker();
            this.tbxStaffID = new System.Windows.Forms.TextBox();
            this.lbxEventType = new System.Windows.Forms.ListBox();
            this.cbxEventType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagementInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManagementInfo
            // 
            this.dgvManagementInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagementInfo.Location = new System.Drawing.Point(20, 39);
            this.dgvManagementInfo.Name = "dgvManagementInfo";
            this.dgvManagementInfo.RowHeadersWidth = 51;
            this.dgvManagementInfo.RowTemplate.Height = 24;
            this.dgvManagementInfo.Size = new System.Drawing.Size(950, 661);
            this.dgvManagementInfo.TabIndex = 0;
            // 
            // lblManagementTitle
            // 
            this.lblManagementTitle.AutoSize = true;
            this.lblManagementTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagementTitle.Location = new System.Drawing.Point(464, 11);
            this.lblManagementTitle.Name = "lblManagementTitle";
            this.lblManagementTitle.Size = new System.Drawing.Size(121, 24);
            this.lblManagementTitle.TabIndex = 1;
            this.lblManagementTitle.Text = "Management";
            // 
            // lblEventType
            // 
            this.lblEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(1001, 66);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(84, 17);
            this.lblEventType.TabIndex = 2;
            this.lblEventType.Text = "Event Type:";
            // 
            // lblStaffID
            // 
            this.lblStaffID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(1001, 103);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(58, 17);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Staff ID:";
            this.lblStaffID.Click += new System.EventHandler(this.lblStaffID_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(1001, 186);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1150, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnManagementBack
            // 
            this.btnManagementBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManagementBack.Location = new System.Drawing.Point(1150, 643);
            this.btnManagementBack.Name = "btnManagementBack";
            this.btnManagementBack.Size = new System.Drawing.Size(155, 57);
            this.btnManagementBack.TabIndex = 9;
            this.btnManagementBack.Text = "Back";
            this.btnManagementBack.UseVisualStyleBackColor = true;
            this.btnManagementBack.Click += new System.EventHandler(this.btnManagementBack_Click);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(1001, 145);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(73, 17);
            this.lblPatientID.TabIndex = 10;
            this.lblPatientID.Text = "Patient ID:";
            // 
            // tbxPatientID
            // 
            this.tbxPatientID.Location = new System.Drawing.Point(1097, 140);
            this.tbxPatientID.Name = "tbxPatientID";
            this.tbxPatientID.Size = new System.Drawing.Size(208, 22);
            this.tbxPatientID.TabIndex = 11;
            // 
            // dtpManagement
            // 
            this.dtpManagement.Location = new System.Drawing.Point(1097, 181);
            this.dtpManagement.Name = "dtpManagement";
            this.dtpManagement.Size = new System.Drawing.Size(208, 22);
            this.dtpManagement.TabIndex = 12;
            // 
            // tbxStaffID
            // 
            this.tbxStaffID.Location = new System.Drawing.Point(1097, 100);
            this.tbxStaffID.Name = "tbxStaffID";
            this.tbxStaffID.Size = new System.Drawing.Size(208, 22);
            this.tbxStaffID.TabIndex = 13;
            // 
            // lbxEventType
            // 
            this.lbxEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxEventType.FormattingEnabled = true;
            this.lbxEventType.ItemHeight = 16;
            this.lbxEventType.Items.AddRange(new object[] {
            "Alarms",
            "ProgramLogs"});
            this.lbxEventType.Location = new System.Drawing.Point(1097, 66);
            this.lbxEventType.Name = "lbxEventType";
            this.lbxEventType.Size = new System.Drawing.Size(208, 20);
            this.lbxEventType.TabIndex = 3;
            // 
            // cbxEventType
            // 
            this.cbxEventType.FormattingEnabled = true;
            this.cbxEventType.Items.AddRange(new object[] {
            "Alarms",
            "ProgramLogs"});
            this.cbxEventType.Location = new System.Drawing.Point(1097, 299);
            this.cbxEventType.Name = "cbxEventType";
            this.cbxEventType.Size = new System.Drawing.Size(208, 24);
            this.cbxEventType.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1160, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 88);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxEventType);
            this.Controls.Add(this.tbxStaffID);
            this.Controls.Add(this.dtpManagement);
            this.Controls.Add(this.tbxPatientID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.btnManagementBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lbxEventType);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.lblManagementTitle);
            this.Controls.Add(this.dgvManagementInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManagementPage";
            this.Size = new System.Drawing.Size(1347, 732);
            this.Load += new System.EventHandler(this.ManagementPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagementInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvManagementInfo;
        private System.Windows.Forms.Label lblManagementTitle;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnManagementBack;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox tbxPatientID;
        private System.Windows.Forms.DateTimePicker dtpManagement;
        private System.Windows.Forms.TextBox tbxStaffID;
        private System.Windows.Forms.ListBox lbxEventType;
        private System.Windows.Forms.ComboBox cbxEventType;
        private System.Windows.Forms.Button button1;
    }
}