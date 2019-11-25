namespace Software_Engineering_Assignment.Pages
{
    partial class MainPage
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
            this.register1 = new Software_Engineering_Assignment.RegisterControl();
            this.bayControl2 = new Software_Engineering_Assignment.BayPreviewControl();
            this.bayControl1 = new Software_Engineering_Assignment.BayPreviewControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.White;
            this.register1.Dock = System.Windows.Forms.DockStyle.Top;
            this.register1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register1.Location = new System.Drawing.Point(0, 0);
            this.register1.Margin = new System.Windows.Forms.Padding(4);
            this.register1.MaximumSize = new System.Drawing.Size(475, 557);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(474, 496);
            this.register1.TabIndex = 2;
            // 
            // bayControl2
            // 
            this.bayControl2.BackColor = System.Drawing.Color.White;
            this.bayControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bayControl2.Location = new System.Drawing.Point(7, 322);
            this.bayControl2.Margin = new System.Windows.Forms.Padding(4);
            this.bayControl2.Name = "bayControl2";
            this.bayControl2.Size = new System.Drawing.Size(497, 265);
            this.bayControl2.TabIndex = 1;
            this.bayControl2.Click += new System.EventHandler(this.BayControl2_Click);
            // 
            // bayControl1
            // 
            this.bayControl1.BackColor = System.Drawing.Color.White;
            this.bayControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bayControl1.Location = new System.Drawing.Point(7, 49);
            this.bayControl1.Margin = new System.Windows.Forms.Padding(4);
            this.bayControl1.Name = "bayControl1";
            this.bayControl1.Size = new System.Drawing.Size(497, 265);
            this.bayControl1.TabIndex = 0;
            this.bayControl1.Load += new System.EventHandler(this.BayControl1_Load);
            this.bayControl1.Click += new System.EventHandler(this.BayControl1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Software_Engineering_Assignment.Properties.Resources.icons8_lock_1001;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(2, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Management";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Software_Engineering_Assignment.Properties.Resources.icons8_lock_1001;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(235, 498);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "Staff (De-)Registration";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.register1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(522, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 538);
            this.panel1.TabIndex = 19;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.bayControl2);
            this.Controls.Add(this.bayControl1);
            this.Controls.Add(this.panel1);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1010, 595);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BayPreviewControl bayControl1;
        private BayPreviewControl bayControl2;
        private RegisterControl register1;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}

