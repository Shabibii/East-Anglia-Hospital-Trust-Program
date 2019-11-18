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
            this.lblEventType.Location = new System.Drawing.Point(1001, 63);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(84, 17);
            this.lblEventType.TabIndex = 2;
            this.lblEventType.Text = "Event Type:";
            // 
            // lbxEventType
            // 
            this.lbxEventType.AllowDrop = true;
            this.lbxEventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxEventType.FormattingEnabled = true;
            this.lbxEventType.ItemHeight = 16;
            this.lbxEventType.Location = new System.Drawing.Point(1097, 63);
            this.lbxEventType.Name = "lbxEventType";
            this.lbxEventType.Size = new System.Drawing.Size(208, 20);
            this.lbxEventType.TabIndex = 3;
            // 
            // lbxStaffID
            // 
            this.lbxStaffID.AllowDrop = true;
            this.lbxStaffID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxStaffID.FormattingEnabled = true;
            this.lbxStaffID.ItemHeight = 16;
            this.lbxStaffID.Location = new System.Drawing.Point(1097, 100);
            this.lbxStaffID.Name = "lbxStaffID";
            this.lbxStaffID.Size = new System.Drawing.Size(208, 20);
            this.lbxStaffID.TabIndex = 5;
            this.lbxStaffID.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1013, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Staff ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbxDate
            // 
            this.lbxDate.AllowDrop = true;
            this.lbxDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxDate.FormattingEnabled = true;
            this.lbxDate.ItemHeight = 16;
            this.lbxDate.Location = new System.Drawing.Point(1097, 139);
            this.lbxDate.Name = "lbxDate";
            this.lbxDate.Size = new System.Drawing.Size(208, 20);
            this.lbxDate.TabIndex = 7;
            this.lbxDate.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(1013, 139);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 17);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Staff ID:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(1150, 178);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.ListBox lbxEventType;
        private System.Windows.Forms.ListBox lbxStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnManagementBack;
    }
}