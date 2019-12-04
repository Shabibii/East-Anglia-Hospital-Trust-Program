namespace Software_Engineering_Assignment
{
    partial class BayPreviewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BayPreviewControl));
            this.title = new System.Windows.Forms.Label();
            this.patient1 = new System.Windows.Forms.LinkLabel();
            this.patient2 = new System.Windows.Forms.LinkLabel();
            this.patient3 = new System.Windows.Forms.LinkLabel();
            this.patient4 = new System.Windows.Forms.LinkLabel();
            this.patient5 = new System.Windows.Forms.LinkLabel();
            this.patient6 = new System.Windows.Forms.LinkLabel();
            this.patient7 = new System.Windows.Forms.LinkLabel();
            this.patient8 = new System.Windows.Forms.LinkLabel();
            this.alarmDisplay = new System.Windows.Forms.PictureBox();
            this.alarmCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alarmDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(211, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(76, 26);
            this.title.TabIndex = 0;
            this.title.Text = "Bay X";
            // 
            // patient1
            // 
            this.patient1.AutoSize = true;
            this.patient1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.patient1.Location = new System.Drawing.Point(33, 96);
            this.patient1.Name = "patient1";
            this.patient1.Size = new System.Drawing.Size(147, 22);
            this.patient1.TabIndex = 2;
            this.patient1.TabStop = true;
            this.patient1.Text = "(X) Patient Name";
            this.patient1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Patient1_LinkClicked);
            // 
            // patient2
            // 
            this.patient2.AutoSize = true;
            this.patient2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.patient2.Location = new System.Drawing.Point(33, 140);
            this.patient2.Name = "patient2";
            this.patient2.Size = new System.Drawing.Size(147, 22);
            this.patient2.TabIndex = 3;
            this.patient2.TabStop = true;
            this.patient2.Text = "(X) Patient Name";
            this.patient2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Patient2_LinkClicked);
            // 
            // patient3
            // 
            this.patient3.AutoSize = true;
            this.patient3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.patient3.Location = new System.Drawing.Point(33, 184);
            this.patient3.Name = "patient3";
            this.patient3.Size = new System.Drawing.Size(147, 22);
            this.patient3.TabIndex = 4;
            this.patient3.TabStop = true;
            this.patient3.Text = "(X) Patient Name";
            this.patient3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Patient3_LinkClicked);
            // 
            // patient4
            // 
            this.patient4.AutoSize = true;
            this.patient4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.patient4.Location = new System.Drawing.Point(33, 228);
            this.patient4.Name = "patient4";
            this.patient4.Size = new System.Drawing.Size(147, 22);
            this.patient4.TabIndex = 5;
            this.patient4.TabStop = true;
            this.patient4.Text = "(X) Patient Name";
            this.patient4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Patient4_LinkClicked);
            // 
            // patient5
            // 
            this.patient5.AutoSize = true;
            this.patient5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.patient5.Location = new System.Drawing.Point(312, 96);
            this.patient5.Name = "patient5";
            this.patient5.Size = new System.Drawing.Size(147, 22);
            this.patient5.TabIndex = 6;
            this.patient5.TabStop = true;
            this.patient5.Text = "(X) Patient Name";
            this.patient5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Patient5_LinkClicked);
            // 
            // patient6
            // 
            this.patient6.AutoSize = true;
            this.patient6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.patient6.Location = new System.Drawing.Point(312, 140);
            this.patient6.Name = "patient6";
            this.patient6.Size = new System.Drawing.Size(147, 22);
            this.patient6.TabIndex = 7;
            this.patient6.TabStop = true;
            this.patient6.Text = "(X) Patient Name";
            this.patient6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Patient6_LinkClicked);
            // 
            // patient7
            // 
            this.patient7.AutoSize = true;
            this.patient7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient7.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.patient7.Location = new System.Drawing.Point(312, 184);
            this.patient7.Name = "patient7";
            this.patient7.Size = new System.Drawing.Size(147, 22);
            this.patient7.TabIndex = 8;
            this.patient7.TabStop = true;
            this.patient7.Text = "(X) Patient Name";
            this.patient7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Patient7_LinkClicked);
            // 
            // patient8
            // 
            this.patient8.AutoSize = true;
            this.patient8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient8.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.patient8.Location = new System.Drawing.Point(312, 228);
            this.patient8.Name = "patient8";
            this.patient8.Size = new System.Drawing.Size(147, 22);
            this.patient8.TabIndex = 9;
            this.patient8.TabStop = true;
            this.patient8.Text = "(X) Patient Name";
            this.patient8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Patient8_LinkClicked);
            // 
            // alarmDisplay
            // 
            this.alarmDisplay.Image = ((System.Drawing.Image)(resources.GetObject("alarmDisplay.Image")));
            this.alarmDisplay.Location = new System.Drawing.Point(21, 18);
            this.alarmDisplay.Name = "alarmDisplay";
            this.alarmDisplay.Size = new System.Drawing.Size(62, 55);
            this.alarmDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alarmDisplay.TabIndex = 1;
            this.alarmDisplay.TabStop = false;
            // 
            // alarmCheck
            // 
            this.alarmCheck.Tick += new System.EventHandler(this.alarmCheck_Tick);
            // 
            // BayPreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.patient8);
            this.Controls.Add(this.patient7);
            this.Controls.Add(this.patient6);
            this.Controls.Add(this.patient5);
            this.Controls.Add(this.patient4);
            this.Controls.Add(this.patient3);
            this.Controls.Add(this.patient2);
            this.Controls.Add(this.patient1);
            this.Controls.Add(this.alarmDisplay);
            this.Controls.Add(this.title);
            this.Name = "BayPreviewControl";
            this.Size = new System.Drawing.Size(500, 291);
            this.Load += new System.EventHandler(this.BayPreviewControl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bay_MouseDown);
            this.MouseLeave += new System.EventHandler(this.BayControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Bay_MouseHover);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bay_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.alarmDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox alarmDisplay;
        private System.Windows.Forms.LinkLabel patient1;
        private System.Windows.Forms.LinkLabel patient2;
        private System.Windows.Forms.LinkLabel patient3;
        private System.Windows.Forms.LinkLabel patient4;
        private System.Windows.Forms.LinkLabel patient5;
        private System.Windows.Forms.LinkLabel patient6;
        private System.Windows.Forms.LinkLabel patient7;
        private System.Windows.Forms.LinkLabel patient8;
        private System.Windows.Forms.Timer alarmCheck;
    }
}
