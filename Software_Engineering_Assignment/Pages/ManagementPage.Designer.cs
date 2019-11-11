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
            this.lbxEventType = new System.Windows.Forms.ListBox();
            this.lbxStaffID = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxDate = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnManagementBack = new System.Windows.Forms.Button();
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
            this.dgvManagementInfo.Size = new System.Drawing.Size(714, 508);
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
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(740, 63);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(84, 17);
            this.lblEventType.TabIndex = 2;
            this.lblEventType.Text = "Event Type:";
            // 
            // lbxEventType
            // 
            this.lbxEventType.AllowDrop = true;
            this.lbxEventType.FormattingEnabled = true;
            this.lbxEventType.ItemHeight = 16;
            this.lbxEventType.Location = new System.Drawing.Point(840, 63);
            this.lbxEventType.Name = "lbxEventType";
            this.lbxEventType.Size = new System.Drawing.Size(128, 20);
            this.lbxEventType.TabIndex = 3;
            // 
            // lbxStaffID
            // 
            this.lbxStaffID.AllowDrop = true;
            this.lbxStaffID.FormattingEnabled = true;
            this.lbxStaffID.ItemHeight = 16;
            this.lbxStaffID.Location = new System.Drawing.Point(840, 100);
            this.lbxStaffID.Name = "lbxStaffID";
            this.lbxStaffID.Size = new System.Drawing.Size(128, 20);
            this.lbxStaffID.TabIndex = 5;
            this.lbxStaffID.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Staff ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbxDate
            // 
            this.lbxDate.AllowDrop = true;
            this.lbxDate.FormattingEnabled = true;
            this.lbxDate.ItemHeight = 16;
            this.lbxDate.Location = new System.Drawing.Point(840, 139);
            this.lbxDate.Name = "lbxDate";
            this.lbxDate.Size = new System.Drawing.Size(128, 20);
            this.lbxDate.TabIndex = 7;
            this.lbxDate.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(752, 139);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 17);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Staff ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(893, 178);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnManagementBack
            // 
            this.btnManagementBack.Location = new System.Drawing.Point(893, 524);
            this.btnManagementBack.Name = "btnManagementBack";
            this.btnManagementBack.Size = new System.Drawing.Size(75, 23);
            this.btnManagementBack.TabIndex = 9;
            this.btnManagementBack.Text = "Back";
            this.btnManagementBack.UseVisualStyleBackColor = true;
            // 
            // ManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnManagementBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbxDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbxStaffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxEventType);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.lblManagementTitle);
            this.Controls.Add(this.dgvManagementInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ListBox lbxEventType;
        private System.Windows.Forms.ListBox lbxStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnManagementBack;
    }
}