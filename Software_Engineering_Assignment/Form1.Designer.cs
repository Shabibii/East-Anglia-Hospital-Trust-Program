namespace Software_Engineering_Assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.register1 = new Software_Engineering_Assignment.Register();
            this.bayControl2 = new Software_Engineering_Assignment.BayControl();
            this.bayControl1 = new Software_Engineering_Assignment.BayControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(359, 12);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(372, 26);
            this.dateTimeLabel.TabIndex = 3;
            this.dateTimeLabel.Text = "Saturday, 26 Oct 2019 (09:21:55 PM)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.register1);
            this.panel1.Location = new System.Drawing.Point(344, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 613);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Software_Engineering_Assignment.Properties.Resources.icons8_lock_1001;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(191, 565);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Registration";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(3, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Management";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // register1
            // 
            this.register1.BackColor = System.Drawing.Color.White;
            this.register1.Dock = System.Windows.Forms.DockStyle.Top;
            this.register1.Location = new System.Drawing.Point(0, 0);
            this.register1.MaximumSize = new System.Drawing.Size(475, 557);
            this.register1.Name = "register1";
            this.register1.Size = new System.Drawing.Size(403, 557);
            this.register1.TabIndex = 2;
            // 
            // bayControl2
            // 
            this.bayControl2.BackColor = System.Drawing.Color.White;
            this.bayControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bayControl2.Location = new System.Drawing.Point(45, 348);
            this.bayControl2.MaximumSize = new System.Drawing.Size(255, 360);
            this.bayControl2.Name = "bayControl2";
            this.bayControl2.Size = new System.Drawing.Size(255, 325);
            this.bayControl2.TabIndex = 1;
            // 
            // bayControl1
            // 
            this.bayControl1.BackColor = System.Drawing.Color.White;
            this.bayControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bayControl1.Location = new System.Drawing.Point(45, 12);
            this.bayControl1.MaximumSize = new System.Drawing.Size(255, 360);
            this.bayControl1.Name = "bayControl1";
            this.bayControl1.Size = new System.Drawing.Size(255, 325);
            this.bayControl1.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 684);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.bayControl2);
            this.Controls.Add(this.bayControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BayControl bayControl1;
        private BayControl bayControl2;
        private Register register1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Timer timer;
    }
}

