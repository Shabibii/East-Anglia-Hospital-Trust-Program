namespace Software_Engineering_Assignment
{
    partial class Login
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
            this.emergencyLabel = new System.Windows.Forms.Label();
            this.energencyLog = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.staffIdTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.staffIdLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showPassword = new System.Windows.Forms.CheckBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // emergencyLabel
            // 
            this.emergencyLabel.AutoSize = true;
            this.emergencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyLabel.Location = new System.Drawing.Point(3, 9);
            this.emergencyLabel.Name = "emergencyLabel";
            this.emergencyLabel.Size = new System.Drawing.Size(83, 13);
            this.emergencyLabel.TabIndex = 5;
            this.emergencyLabel.Text = "Emergencies:";
            // 
            // energencyLog
            // 
            this.energencyLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.energencyLog.BackColor = System.Drawing.Color.White;
            this.energencyLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.energencyLog.Location = new System.Drawing.Point(3, 25);
            this.energencyLog.Multiline = true;
            this.energencyLog.Name = "energencyLog";
            this.energencyLog.ReadOnly = true;
            this.energencyLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.energencyLog.Size = new System.Drawing.Size(313, 303);
            this.energencyLog.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.emergencyLabel);
            this.panel1.Controls.Add(this.energencyLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 333);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // staffIdTextBox
            // 
            this.staffIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIdTextBox.ForeColor = System.Drawing.Color.Gray;
            this.staffIdTextBox.Location = new System.Drawing.Point(61, 136);
            this.staffIdTextBox.Name = "staffIdTextBox";
            this.staffIdTextBox.Size = new System.Drawing.Size(235, 26);
            this.staffIdTextBox.TabIndex = 8;
            this.staffIdTextBox.Tag = "Enter Staff ID";
            this.staffIdTextBox.Text = "Enter Staff ID";
            this.staffIdTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StaffIdTextBox_KeyDown);
            this.staffIdTextBox.Leave += new System.EventHandler(this.LoginField_Leave);
            this.staffIdTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginField_MouseDown);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Gray;
            this.passwordTextBox.Location = new System.Drawing.Point(61, 185);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(235, 26);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.Tag = "Enter Password";
            this.passwordTextBox.Text = "Enter Password";
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            this.passwordTextBox.Leave += new System.EventHandler(this.LoginField_Leave);
            this.passwordTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginField_MouseDown);
            // 
            // staffIdLabel
            // 
            this.staffIdLabel.AutoSize = true;
            this.staffIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIdLabel.Location = new System.Drawing.Point(58, 120);
            this.staffIdLabel.Name = "staffIdLabel";
            this.staffIdLabel.Size = new System.Drawing.Size(55, 13);
            this.staffIdLabel.TabIndex = 10;
            this.staffIdLabel.Text = "Staff ID:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(58, 169);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(65, 13);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginButton.Location = new System.Drawing.Point(156, 225);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(64, 43);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.showPassword);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.passwordLabel);
            this.panel2.Controls.Add(this.staffIdLabel);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Controls.Add(this.staffIdTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(323, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 331);
            this.panel2.TabIndex = 13;
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(226, 239);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(101, 17);
            this.showPassword.TabIndex = 14;
            this.showPassword.Text = "Show password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeButton.Location = new System.Drawing.Point(316, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(37, 34);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 333);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(683, 333);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(683, 333);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label emergencyLabel;
        private System.Windows.Forms.TextBox energencyLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox staffIdTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label staffIdLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox showPassword;
    }
}