namespace Software_Engineering_Assignment.Pages
{
    partial class CentralStation
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
            this.components = new System.ComponentModel.Container();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.eventRegister = new Software_Engineering_Assignment.RegisterControl();
            this.bay2 = new Software_Engineering_Assignment.BayPreviewControl();
            this.bay1 = new Software_Engineering_Assignment.BayPreviewControl();
            this.managementButton = new System.Windows.Forms.Button();
            this.registrationButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(11, 15);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(329, 23);
            this.dateTimeLabel.TabIndex = 3;
            this.dateTimeLabel.Text = "Saturday, 26 Oct 2019 (09:21:55 PM)";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // eventRegister
            // 
            this.eventRegister.BackColor = System.Drawing.Color.White;
            this.eventRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.eventRegister.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventRegister.Location = new System.Drawing.Point(0, 0);
            this.eventRegister.Margin = new System.Windows.Forms.Padding(4);
            this.eventRegister.MaximumSize = new System.Drawing.Size(475, 557);
            this.eventRegister.Name = "eventRegister";
            this.eventRegister.Size = new System.Drawing.Size(474, 496);
            this.eventRegister.TabIndex = 2;
            // 
            // bay2
            // 
            this.bay2.BackColor = System.Drawing.Color.White;
            this.bay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bay2.Location = new System.Drawing.Point(7, 322);
            this.bay2.Margin = new System.Windows.Forms.Padding(4);
            this.bay2.Name = "bay2";
            this.bay2.Size = new System.Drawing.Size(497, 265);
            this.bay2.TabIndex = 1;
            this.bay2.Click += new System.EventHandler(this.BayControl2_Click);
            // 
            // bay1
            // 
            this.bay1.BackColor = System.Drawing.Color.White;
            this.bay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bay1.Location = new System.Drawing.Point(7, 49);
            this.bay1.Margin = new System.Windows.Forms.Padding(4);
            this.bay1.Name = "bay1";
            this.bay1.Size = new System.Drawing.Size(497, 265);
            this.bay1.TabIndex = 0;
            this.bay1.Click += new System.EventHandler(this.BayControl1_Click);
            // 
            // managementButton
            // 
            this.managementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managementButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementButton.Image = global::Software_Engineering_Assignment.Properties.Resources.icons8_lock_1001;
            this.managementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.managementButton.Location = new System.Drawing.Point(2, 498);
            this.managementButton.Margin = new System.Windows.Forms.Padding(2);
            this.managementButton.Name = "managementButton";
            this.managementButton.Size = new System.Drawing.Size(230, 36);
            this.managementButton.TabIndex = 17;
            this.managementButton.Text = "Management";
            this.managementButton.UseVisualStyleBackColor = true;
            this.managementButton.Click += new System.EventHandler(this.ManagementButton_Click);
            // 
            // registrationButton
            // 
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationButton.Image = global::Software_Engineering_Assignment.Properties.Resources.icons8_lock_1001;
            this.registrationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.registrationButton.Location = new System.Drawing.Point(235, 498);
            this.registrationButton.Margin = new System.Windows.Forms.Padding(2);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(236, 36);
            this.registrationButton.TabIndex = 18;
            this.registrationButton.Text = "Staff (De-)Registration";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.RegisterationButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.registrationButton);
            this.panel1.Controls.Add(this.eventRegister);
            this.panel1.Controls.Add(this.managementButton);
            this.panel1.Location = new System.Drawing.Point(522, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 538);
            this.panel1.TabIndex = 19;
            // 
            // CentralStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.bay2);
            this.Controls.Add(this.bay1);
            this.Controls.Add(this.panel1);
            this.Name = "CentralStation";
            this.Size = new System.Drawing.Size(1010, 595);
            this.Tag = "Central Station";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BayPreviewControl bay1;
        private BayPreviewControl bay2;
        private RegisterControl eventRegister;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button managementButton;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.Panel panel1;
    }
}

