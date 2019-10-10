namespace Software_Engineering_Assignment
{
    partial class Form1
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
            this.bayControl1 = new Software_Engineering_Assignment.BayControl();
            this.bayControl2 = new Software_Engineering_Assignment.BayControl();
            this.SuspendLayout();
            // 
            // bayControl1
            // 
            this.bayControl1.BackColor = System.Drawing.Color.White;
            this.bayControl1.Location = new System.Drawing.Point(12, 12);
            this.bayControl1.Name = "bayControl1";
            this.bayControl1.Size = new System.Drawing.Size(341, 313);
            this.bayControl1.TabIndex = 0;
            // 
            // bayControl2
            // 
            this.bayControl2.BackColor = System.Drawing.Color.White;
            this.bayControl2.Location = new System.Drawing.Point(12, 348);
            this.bayControl2.Name = "bayControl2";
            this.bayControl2.Size = new System.Drawing.Size(341, 313);
            this.bayControl2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 673);
            this.Controls.Add(this.bayControl2);
            this.Controls.Add(this.bayControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BayControl bayControl1;
        private BayControl bayControl2;
    }
}

