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
            this.cbxEventType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateType = new System.Windows.Forms.Label();
            this.rbtAnyDay = new System.Windows.Forms.RadioButton();
            this.rbtSelectDay = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagementInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvManagementInfo
            // 
            this.dgvManagementInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagementInfo.Location = new System.Drawing.Point(15, 32);
            this.dgvManagementInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvManagementInfo.Name = "dgvManagementInfo";
            this.dgvManagementInfo.RowHeadersWidth = 51;
            this.dgvManagementInfo.RowTemplate.Height = 24;
            this.dgvManagementInfo.Size = new System.Drawing.Size(712, 537);
            this.dgvManagementInfo.TabIndex = 0;
            // 
            // lblManagementTitle
            // 
            this.lblManagementTitle.AutoSize = true;
            this.lblManagementTitle.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagementTitle.Location = new System.Drawing.Point(348, 9);
            this.lblManagementTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManagementTitle.Name = "lblManagementTitle";
            this.lblManagementTitle.Size = new System.Drawing.Size(104, 19);
            this.lblManagementTitle.TabIndex = 1;
            this.lblManagementTitle.Text = "Management";
            // 
            // lblEventType
            // 
            this.lblEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(751, 54);
            this.lblEventType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(65, 13);
            this.lblEventType.TabIndex = 2;
            this.lblEventType.Text = "Event Type:";
            // 
            // lblStaffID
            // 
            this.lblStaffID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(751, 84);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(46, 13);
            this.lblStaffID.TabIndex = 4;
            this.lblStaffID.Text = "Staff ID:";
            this.lblStaffID.Click += new System.EventHandler(this.lblStaffID_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(751, 178);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date:";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(865, 210);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 19);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnManagementBack
            // 
            this.btnManagementBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManagementBack.Location = new System.Drawing.Point(862, 522);
            this.btnManagementBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManagementBack.Name = "btnManagementBack";
            this.btnManagementBack.Size = new System.Drawing.Size(116, 46);
            this.btnManagementBack.TabIndex = 9;
            this.btnManagementBack.Text = "Back";
            this.btnManagementBack.UseVisualStyleBackColor = true;
            this.btnManagementBack.Click += new System.EventHandler(this.btnManagementBack_Click);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(751, 118);
            this.lblPatientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(57, 13);
            this.lblPatientID.TabIndex = 10;
            this.lblPatientID.Text = "Patient ID:";
            // 
            // tbxPatientID
            // 
            this.tbxPatientID.Location = new System.Drawing.Point(823, 114);
            this.tbxPatientID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPatientID.Name = "tbxPatientID";
            this.tbxPatientID.Size = new System.Drawing.Size(157, 20);
            this.tbxPatientID.TabIndex = 11;
            // 
            // dtpManagement
            // 
            this.dtpManagement.Enabled = false;
            this.dtpManagement.Location = new System.Drawing.Point(823, 174);
            this.dtpManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpManagement.Name = "dtpManagement";
            this.dtpManagement.Size = new System.Drawing.Size(157, 20);
            this.dtpManagement.TabIndex = 12;
            // 
            // tbxStaffID
            // 
            this.tbxStaffID.Location = new System.Drawing.Point(823, 81);
            this.tbxStaffID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxStaffID.Name = "tbxStaffID";
            this.tbxStaffID.Size = new System.Drawing.Size(157, 20);
            this.tbxStaffID.TabIndex = 13;
            // 
            // cbxEventType
            // 
            this.cbxEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEventType.FormattingEnabled = true;
            this.cbxEventType.Items.AddRange(new object[] {
            "Alarms",
            "ProgramLogs"});
            this.cbxEventType.Location = new System.Drawing.Point(823, 50);
            this.cbxEventType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEventType.Name = "cbxEventType";
            this.cbxEventType.Size = new System.Drawing.Size(157, 21);
            this.cbxEventType.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDateType
            // 
            this.lblDateType.AutoSize = true;
            this.lblDateType.Location = new System.Drawing.Point(750, 150);
            this.lblDateType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateType.Name = "lblDateType";
            this.lblDateType.Size = new System.Drawing.Size(33, 13);
            this.lblDateType.TabIndex = 16;
            this.lblDateType.Text = "Time:";
            // 
            // rbtAnyDay
            // 
            this.rbtAnyDay.AutoSize = true;
            this.rbtAnyDay.Location = new System.Drawing.Point(823, 149);
            this.rbtAnyDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtAnyDay.Name = "rbtAnyDay";
            this.rbtAnyDay.Size = new System.Drawing.Size(43, 17);
            this.rbtAnyDay.TabIndex = 17;
            this.rbtAnyDay.TabStop = true;
            this.rbtAnyDay.Text = "Any";
            this.rbtAnyDay.UseVisualStyleBackColor = true;
            this.rbtAnyDay.CheckedChanged += new System.EventHandler(this.rbtAnyDay_CheckedChanged);
            // 
            // rbtSelectDay
            // 
            this.rbtSelectDay.AutoSize = true;
            this.rbtSelectDay.Location = new System.Drawing.Point(908, 149);
            this.rbtSelectDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtSelectDay.Name = "rbtSelectDay";
            this.rbtSelectDay.Size = new System.Drawing.Size(75, 17);
            this.rbtSelectDay.TabIndex = 18;
            this.rbtSelectDay.TabStop = true;
            this.rbtSelectDay.Text = "Select day";
            this.rbtSelectDay.UseVisualStyleBackColor = true;
            this.rbtSelectDay.CheckedChanged += new System.EventHandler(this.rbtSelectDay_CheckedChanged);
            // 
            // ManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rbtSelectDay);
            this.Controls.Add(this.rbtAnyDay);
            this.Controls.Add(this.lblDateType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEventType);
            this.Controls.Add(this.tbxStaffID);
            this.Controls.Add(this.dtpManagement);
            this.Controls.Add(this.tbxPatientID);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.btnManagementBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.lblManagementTitle);
            this.Controls.Add(this.dgvManagementInfo);
            this.Name = "ManagementPage";
            this.Size = new System.Drawing.Size(1010, 595);
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
        private System.Windows.Forms.ComboBox cbxEventType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateType;
        private System.Windows.Forms.RadioButton rbtAnyDay;
        private System.Windows.Forms.RadioButton rbtSelectDay;
    }
}