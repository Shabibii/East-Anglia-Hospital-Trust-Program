namespace Software_Engineering_Assignment.Pages
{
    partial class Bedside
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bedside));
            this.nameLabel = new System.Windows.Forms.Label();
            this.module1CurrentReading = new System.Windows.Forms.TextBox();
            this.emptyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.module1Max = new System.Windows.Forms.TextBox();
            this.module1Min = new System.Windows.Forms.TextBox();
            this.module2CurrentReading = new System.Windows.Forms.TextBox();
            this.module2Max = new System.Windows.Forms.TextBox();
            this.module2Min = new System.Windows.Forms.TextBox();
            this.module3CurrentReading = new System.Windows.Forms.TextBox();
            this.module3Max = new System.Windows.Forms.TextBox();
            this.module3Min = new System.Windows.Forms.TextBox();
            this.module4CurrentReading = new System.Windows.Forms.TextBox();
            this.module4Max = new System.Windows.Forms.TextBox();
            this.module4Min = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.intakeReasonLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.module4Unit = new System.Windows.Forms.Label();
            this.module2Unit = new System.Windows.Forms.Label();
            this.module3Unit = new System.Windows.Forms.Label();
            this.module1Unit = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.module4ModuleType = new System.Windows.Forms.ComboBox();
            this.module3ModuleType = new System.Windows.Forms.ComboBox();
            this.module2ModuleType = new System.Windows.Forms.ComboBox();
            this.module1ModuleType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.refreshModuleData = new System.Windows.Forms.Timer(this.components);
            this.alarmDisplay1 = new System.Windows.Forms.PictureBox();
            this.alarmDisplay2 = new System.Windows.Forms.PictureBox();
            this.alarmDisplay3 = new System.Windows.Forms.PictureBox();
            this.alarmDisplay4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmDisplay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmDisplay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmDisplay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmDisplay4)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 139);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(37, 14);
            this.nameLabel.TabIndex = 22;
            this.nameLabel.Text = "Name:";
            // 
            // module1CurrentReading
            // 
            this.module1CurrentReading.ContextMenuStrip = this.emptyMenuStrip;
            this.module1CurrentReading.Location = new System.Drawing.Point(259, 82);
            this.module1CurrentReading.Margin = new System.Windows.Forms.Padding(2);
            this.module1CurrentReading.Name = "module1CurrentReading";
            this.module1CurrentReading.ReadOnly = true;
            this.module1CurrentReading.ShortcutsEnabled = false;
            this.module1CurrentReading.Size = new System.Drawing.Size(98, 20);
            this.module1CurrentReading.TabIndex = 25;
            this.module1CurrentReading.Text = "N/A";
            this.module1CurrentReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module1CurrentReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // emptyMenuStrip
            // 
            this.emptyMenuStrip.Name = "emptyMenuStrip";
            this.emptyMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // module1Max
            // 
            this.module1Max.ContextMenuStrip = this.emptyMenuStrip;
            this.module1Max.Location = new System.Drawing.Point(259, 116);
            this.module1Max.Margin = new System.Windows.Forms.Padding(2);
            this.module1Max.Name = "module1Max";
            this.module1Max.ReadOnly = true;
            this.module1Max.ShortcutsEnabled = false;
            this.module1Max.Size = new System.Drawing.Size(98, 20);
            this.module1Max.TabIndex = 26;
            this.module1Max.Text = "N/A";
            this.module1Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module1Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // module1Min
            // 
            this.module1Min.ContextMenuStrip = this.emptyMenuStrip;
            this.module1Min.Location = new System.Drawing.Point(259, 152);
            this.module1Min.Margin = new System.Windows.Forms.Padding(2);
            this.module1Min.Name = "module1Min";
            this.module1Min.ReadOnly = true;
            this.module1Min.ShortcutsEnabled = false;
            this.module1Min.Size = new System.Drawing.Size(98, 20);
            this.module1Min.TabIndex = 27;
            this.module1Min.Text = "N/A";
            this.module1Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module1Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // module2CurrentReading
            // 
            this.module2CurrentReading.ContextMenuStrip = this.emptyMenuStrip;
            this.module2CurrentReading.Location = new System.Drawing.Point(590, 82);
            this.module2CurrentReading.Margin = new System.Windows.Forms.Padding(2);
            this.module2CurrentReading.Name = "module2CurrentReading";
            this.module2CurrentReading.ReadOnly = true;
            this.module2CurrentReading.ShortcutsEnabled = false;
            this.module2CurrentReading.Size = new System.Drawing.Size(98, 20);
            this.module2CurrentReading.TabIndex = 30;
            this.module2CurrentReading.Text = "N/A";
            this.module2CurrentReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module2CurrentReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // module2Max
            // 
            this.module2Max.ContextMenuStrip = this.emptyMenuStrip;
            this.module2Max.Location = new System.Drawing.Point(590, 116);
            this.module2Max.Margin = new System.Windows.Forms.Padding(2);
            this.module2Max.Name = "module2Max";
            this.module2Max.ReadOnly = true;
            this.module2Max.ShortcutsEnabled = false;
            this.module2Max.Size = new System.Drawing.Size(98, 20);
            this.module2Max.TabIndex = 31;
            this.module2Max.Text = "N/A";
            this.module2Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module2Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // module2Min
            // 
            this.module2Min.ContextMenuStrip = this.emptyMenuStrip;
            this.module2Min.Location = new System.Drawing.Point(590, 152);
            this.module2Min.Margin = new System.Windows.Forms.Padding(2);
            this.module2Min.Name = "module2Min";
            this.module2Min.ReadOnly = true;
            this.module2Min.ShortcutsEnabled = false;
            this.module2Min.Size = new System.Drawing.Size(98, 20);
            this.module2Min.TabIndex = 32;
            this.module2Min.Text = "N/A";
            this.module2Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module2Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // module3CurrentReading
            // 
            this.module3CurrentReading.ContextMenuStrip = this.emptyMenuStrip;
            this.module3CurrentReading.Location = new System.Drawing.Point(259, 318);
            this.module3CurrentReading.Margin = new System.Windows.Forms.Padding(2);
            this.module3CurrentReading.Name = "module3CurrentReading";
            this.module3CurrentReading.ReadOnly = true;
            this.module3CurrentReading.ShortcutsEnabled = false;
            this.module3CurrentReading.Size = new System.Drawing.Size(98, 20);
            this.module3CurrentReading.TabIndex = 35;
            this.module3CurrentReading.Text = "N/A";
            this.module3CurrentReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module3CurrentReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // module3Max
            // 
            this.module3Max.ContextMenuStrip = this.emptyMenuStrip;
            this.module3Max.Location = new System.Drawing.Point(259, 353);
            this.module3Max.Margin = new System.Windows.Forms.Padding(2);
            this.module3Max.Name = "module3Max";
            this.module3Max.ReadOnly = true;
            this.module3Max.ShortcutsEnabled = false;
            this.module3Max.Size = new System.Drawing.Size(98, 20);
            this.module3Max.TabIndex = 36;
            this.module3Max.Text = "N/A";
            this.module3Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module3Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // module3Min
            // 
            this.module3Min.ContextMenuStrip = this.emptyMenuStrip;
            this.module3Min.Location = new System.Drawing.Point(259, 388);
            this.module3Min.Margin = new System.Windows.Forms.Padding(2);
            this.module3Min.Name = "module3Min";
            this.module3Min.ReadOnly = true;
            this.module3Min.ShortcutsEnabled = false;
            this.module3Min.Size = new System.Drawing.Size(98, 20);
            this.module3Min.TabIndex = 37;
            this.module3Min.Text = "N/A";
            this.module3Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module3Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // module4CurrentReading
            // 
            this.module4CurrentReading.ContextMenuStrip = this.emptyMenuStrip;
            this.module4CurrentReading.Location = new System.Drawing.Point(590, 318);
            this.module4CurrentReading.Margin = new System.Windows.Forms.Padding(2);
            this.module4CurrentReading.Name = "module4CurrentReading";
            this.module4CurrentReading.ReadOnly = true;
            this.module4CurrentReading.ShortcutsEnabled = false;
            this.module4CurrentReading.Size = new System.Drawing.Size(98, 20);
            this.module4CurrentReading.TabIndex = 40;
            this.module4CurrentReading.Text = "N/A";
            this.module4CurrentReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module4CurrentReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // module4Max
            // 
            this.module4Max.ContextMenuStrip = this.emptyMenuStrip;
            this.module4Max.Location = new System.Drawing.Point(590, 353);
            this.module4Max.Margin = new System.Windows.Forms.Padding(2);
            this.module4Max.Name = "module4Max";
            this.module4Max.ReadOnly = true;
            this.module4Max.ShortcutsEnabled = false;
            this.module4Max.Size = new System.Drawing.Size(98, 20);
            this.module4Max.TabIndex = 41;
            this.module4Max.Text = "N/A";
            this.module4Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module4Max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // module4Min
            // 
            this.module4Min.ContextMenuStrip = this.emptyMenuStrip;
            this.module4Min.Location = new System.Drawing.Point(590, 388);
            this.module4Min.Margin = new System.Windows.Forms.Padding(2);
            this.module4Min.Name = "module4Min";
            this.module4Min.ReadOnly = true;
            this.module4Min.ShortcutsEnabled = false;
            this.module4Min.Size = new System.Drawing.Size(98, 20);
            this.module4Min.TabIndex = 42;
            this.module4Min.Text = "N/A";
            this.module4Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.module4Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1CurrentReading_KeyPress);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Software_Engineering_Assignment.Properties.Resources.icons8_lock_1003;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(545, 442);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 25);
            this.button3.TabIndex = 44;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_Engineering_Assignment.Properties.Resources.yumminky_pc_43_512;
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(654, 442);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 25);
            this.button1.TabIndex = 45;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(8, 175);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 14);
            this.surnameLabel.TabIndex = 46;
            this.surnameLabel.Text = "Surname:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(8, 216);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(33, 14);
            this.dobLabel.TabIndex = 47;
            this.dobLabel.Text = "DOB:";
            // 
            // intakeReasonLabel
            // 
            this.intakeReasonLabel.AutoSize = true;
            this.intakeReasonLabel.Location = new System.Drawing.Point(8, 259);
            this.intakeReasonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.intakeReasonLabel.Name = "intakeReasonLabel";
            this.intakeReasonLabel.Size = new System.Drawing.Size(76, 14);
            this.intakeReasonLabel.TabIndex = 48;
            this.intakeReasonLabel.Text = "Intake Reason:";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Location = new System.Drawing.Point(8, 305);
            this.doctorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(43, 14);
            this.doctorLabel.TabIndex = 49;
            this.doctorLabel.Text = "Doctor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 14);
            this.label6.TabIndex = 50;
            this.label6.Text = "Module 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(619, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 51;
            this.label7.Text = "Module 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ContextMenuStrip = this.emptyMenuStrip;
            this.label8.Location = new System.Drawing.Point(283, 259);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 14);
            this.label8.TabIndex = 52;
            this.label8.Text = "Module 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ContextMenuStrip = this.emptyMenuStrip;
            this.label9.Location = new System.Drawing.Point(619, 259);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 53;
            this.label9.Text = "Module 4";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.alarmDisplay4);
            this.panel1.Controls.Add(this.alarmDisplay3);
            this.panel1.Controls.Add(this.alarmDisplay2);
            this.panel1.Controls.Add(this.alarmDisplay1);
            this.panel1.Controls.Add(this.module4Unit);
            this.panel1.Controls.Add(this.module2Unit);
            this.panel1.Controls.Add(this.module3Unit);
            this.panel1.Controls.Add(this.module1Unit);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.module4ModuleType);
            this.panel1.Controls.Add(this.module3ModuleType);
            this.panel1.Controls.Add(this.module2ModuleType);
            this.panel1.Controls.Add(this.module1ModuleType);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.doctorLabel);
            this.panel1.Controls.Add(this.intakeReasonLabel);
            this.panel1.Controls.Add(this.dobLabel);
            this.panel1.Controls.Add(this.surnameLabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.module4Min);
            this.panel1.Controls.Add(this.module4Max);
            this.panel1.Controls.Add(this.module4CurrentReading);
            this.panel1.Controls.Add(this.module3Min);
            this.panel1.Controls.Add(this.module3Max);
            this.panel1.Controls.Add(this.module3CurrentReading);
            this.panel1.Controls.Add(this.module2Min);
            this.panel1.Controls.Add(this.module2Max);
            this.panel1.Controls.Add(this.module2CurrentReading);
            this.panel1.Controls.Add(this.module1Min);
            this.panel1.Controls.Add(this.module1Max);
            this.panel1.Controls.Add(this.module1CurrentReading);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(127, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 474);
            this.panel1.TabIndex = 54;
            // 
            // module4Unit
            // 
            this.module4Unit.AutoSize = true;
            this.module4Unit.Location = new System.Drawing.Point(692, 321);
            this.module4Unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.module4Unit.Name = "module4Unit";
            this.module4Unit.Size = new System.Drawing.Size(12, 14);
            this.module4Unit.TabIndex = 73;
            this.module4Unit.Text = "^";
            // 
            // module2Unit
            // 
            this.module2Unit.AutoSize = true;
            this.module2Unit.Location = new System.Drawing.Point(692, 85);
            this.module2Unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.module2Unit.Name = "module2Unit";
            this.module2Unit.Size = new System.Drawing.Size(12, 14);
            this.module2Unit.TabIndex = 72;
            this.module2Unit.Text = "^";
            // 
            // module3Unit
            // 
            this.module3Unit.AutoSize = true;
            this.module3Unit.ContextMenuStrip = this.emptyMenuStrip;
            this.module3Unit.Location = new System.Drawing.Point(361, 321);
            this.module3Unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.module3Unit.Name = "module3Unit";
            this.module3Unit.Size = new System.Drawing.Size(12, 14);
            this.module3Unit.TabIndex = 71;
            this.module3Unit.Text = "^";
            // 
            // module1Unit
            // 
            this.module1Unit.AutoSize = true;
            this.module1Unit.ContextMenuStrip = this.emptyMenuStrip;
            this.module1Unit.Location = new System.Drawing.Point(361, 85);
            this.module1Unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.module1Unit.Name = "module1Unit";
            this.module1Unit.Size = new System.Drawing.Size(12, 14);
            this.module1Unit.TabIndex = 70;
            this.module1Unit.Text = "^";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ContextMenuStrip = this.emptyMenuStrip;
            this.label15.Location = new System.Drawing.Point(557, 391);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 14);
            this.label15.TabIndex = 69;
            this.label15.Text = "Min:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ContextMenuStrip = this.emptyMenuStrip;
            this.label16.Location = new System.Drawing.Point(555, 355);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 14);
            this.label16.TabIndex = 68;
            this.label16.Text = "Max:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ContextMenuStrip = this.emptyMenuStrip;
            this.label17.Location = new System.Drawing.Point(541, 321);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 14);
            this.label17.TabIndex = 67;
            this.label17.Text = "Current:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ContextMenuStrip = this.emptyMenuStrip;
            this.label12.Location = new System.Drawing.Point(557, 155);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 14);
            this.label12.TabIndex = 66;
            this.label12.Text = "Min:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ContextMenuStrip = this.emptyMenuStrip;
            this.label13.Location = new System.Drawing.Point(555, 119);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 14);
            this.label13.TabIndex = 65;
            this.label13.Text = "Max:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ContextMenuStrip = this.emptyMenuStrip;
            this.label14.Location = new System.Drawing.Point(541, 85);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 14);
            this.label14.TabIndex = 64;
            this.label14.Text = "Current:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ContextMenuStrip = this.emptyMenuStrip;
            this.label4.Location = new System.Drawing.Point(226, 391);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 14);
            this.label4.TabIndex = 63;
            this.label4.Text = "Min:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ContextMenuStrip = this.emptyMenuStrip;
            this.label5.Location = new System.Drawing.Point(224, 355);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 62;
            this.label5.Text = "Max:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ContextMenuStrip = this.emptyMenuStrip;
            this.label11.Location = new System.Drawing.Point(210, 321);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 14);
            this.label11.TabIndex = 61;
            this.label11.Text = "Current:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ContextMenuStrip = this.emptyMenuStrip;
            this.label3.Location = new System.Drawing.Point(226, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 60;
            this.label3.Text = "Min:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ContextMenuStrip = this.emptyMenuStrip;
            this.label2.Location = new System.Drawing.Point(224, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 59;
            this.label2.Text = "Max:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ContextMenuStrip = this.emptyMenuStrip;
            this.label1.Location = new System.Drawing.Point(210, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 58;
            this.label1.Text = "Current:";
            // 
            // module4ModuleType
            // 
            this.module4ModuleType.ContextMenuStrip = this.emptyMenuStrip;
            this.module4ModuleType.Enabled = false;
            this.module4ModuleType.FormattingEnabled = true;
            this.module4ModuleType.Location = new System.Drawing.Point(590, 283);
            this.module4ModuleType.Margin = new System.Windows.Forms.Padding(2);
            this.module4ModuleType.Name = "module4ModuleType";
            this.module4ModuleType.Size = new System.Drawing.Size(98, 22);
            this.module4ModuleType.TabIndex = 57;
            this.module4ModuleType.Text = "N/A";
            // 
            // module3ModuleType
            // 
            this.module3ModuleType.ContextMenuStrip = this.emptyMenuStrip;
            this.module3ModuleType.Enabled = false;
            this.module3ModuleType.FormattingEnabled = true;
            this.module3ModuleType.Location = new System.Drawing.Point(259, 283);
            this.module3ModuleType.Margin = new System.Windows.Forms.Padding(2);
            this.module3ModuleType.Name = "module3ModuleType";
            this.module3ModuleType.Size = new System.Drawing.Size(98, 22);
            this.module3ModuleType.TabIndex = 56;
            this.module3ModuleType.Text = "N/A";
            // 
            // module2ModuleType
            // 
            this.module2ModuleType.ContextMenuStrip = this.emptyMenuStrip;
            this.module2ModuleType.Enabled = false;
            this.module2ModuleType.FormattingEnabled = true;
            this.module2ModuleType.Location = new System.Drawing.Point(590, 46);
            this.module2ModuleType.Margin = new System.Windows.Forms.Padding(2);
            this.module2ModuleType.Name = "module2ModuleType";
            this.module2ModuleType.Size = new System.Drawing.Size(98, 22);
            this.module2ModuleType.TabIndex = 55;
            this.module2ModuleType.Text = "N/A";
            // 
            // module1ModuleType
            // 
            this.module1ModuleType.ContextMenuStrip = this.emptyMenuStrip;
            this.module1ModuleType.Enabled = false;
            this.module1ModuleType.FormattingEnabled = true;
            this.module1ModuleType.Location = new System.Drawing.Point(259, 46);
            this.module1ModuleType.Margin = new System.Windows.Forms.Padding(2);
            this.module1ModuleType.Name = "module1ModuleType";
            this.module1ModuleType.Size = new System.Drawing.Size(98, 22);
            this.module1ModuleType.TabIndex = 54;
            this.module1ModuleType.Text = "N/A";
            this.module1ModuleType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Module1ModuleType_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(449, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 26);
            this.label10.TabIndex = 55;
            this.label10.Text = "Bedside X";
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(457, 547);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(90, 25);
            this.saveButton.TabIndex = 56;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // refreshModuleData
            // 
            this.refreshModuleData.Interval = 25000;
            this.refreshModuleData.Tick += new System.EventHandler(this.RefreshModuleData_Tick);
            // 
            // alarmDisplay1
            // 
            this.alarmDisplay1.Image = ((System.Drawing.Image)(resources.GetObject("alarmDisplay1.Image")));
            this.alarmDisplay1.Location = new System.Drawing.Point(143, 98);
            this.alarmDisplay1.Name = "alarmDisplay1";
            this.alarmDisplay1.Size = new System.Drawing.Size(62, 55);
            this.alarmDisplay1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alarmDisplay1.TabIndex = 57;
            this.alarmDisplay1.TabStop = false;
            this.alarmDisplay1.Visible = false;
            // 
            // alarmDisplay2
            // 
            this.alarmDisplay2.Image = ((System.Drawing.Image)(resources.GetObject("alarmDisplay2.Image")));
            this.alarmDisplay2.Location = new System.Drawing.Point(474, 98);
            this.alarmDisplay2.Name = "alarmDisplay2";
            this.alarmDisplay2.Size = new System.Drawing.Size(62, 55);
            this.alarmDisplay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alarmDisplay2.TabIndex = 74;
            this.alarmDisplay2.TabStop = false;
            this.alarmDisplay2.Visible = false;
            // 
            // alarmDisplay3
            // 
            this.alarmDisplay3.Image = ((System.Drawing.Image)(resources.GetObject("alarmDisplay3.Image")));
            this.alarmDisplay3.Location = new System.Drawing.Point(143, 332);
            this.alarmDisplay3.Name = "alarmDisplay3";
            this.alarmDisplay3.Size = new System.Drawing.Size(62, 55);
            this.alarmDisplay3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alarmDisplay3.TabIndex = 75;
            this.alarmDisplay3.TabStop = false;
            this.alarmDisplay3.Visible = false;
            // 
            // alarmDisplay4
            // 
            this.alarmDisplay4.Image = ((System.Drawing.Image)(resources.GetObject("alarmDisplay4.Image")));
            this.alarmDisplay4.Location = new System.Drawing.Point(474, 332);
            this.alarmDisplay4.Name = "alarmDisplay4";
            this.alarmDisplay4.Size = new System.Drawing.Size(62, 55);
            this.alarmDisplay4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alarmDisplay4.TabIndex = 76;
            this.alarmDisplay4.TabStop = false;
            this.alarmDisplay4.Visible = false;
            // 
            // Bedside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Bedside";
            this.Size = new System.Drawing.Size(1010, 595);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmDisplay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmDisplay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmDisplay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmDisplay4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox module1CurrentReading;
        private System.Windows.Forms.TextBox module1Max;
        private System.Windows.Forms.TextBox module1Min;
        private System.Windows.Forms.TextBox module2CurrentReading;
        private System.Windows.Forms.TextBox module2Max;
        private System.Windows.Forms.TextBox module2Min;
        private System.Windows.Forms.TextBox module3CurrentReading;
        private System.Windows.Forms.TextBox module3Max;
        private System.Windows.Forms.TextBox module3Min;
        private System.Windows.Forms.TextBox module4CurrentReading;
        private System.Windows.Forms.TextBox module4Max;
        private System.Windows.Forms.TextBox module4Min;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label intakeReasonLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox module4ModuleType;
        private System.Windows.Forms.ComboBox module3ModuleType;
        private System.Windows.Forms.ComboBox module2ModuleType;
        private System.Windows.Forms.ComboBox module1ModuleType;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label module4Unit;
        private System.Windows.Forms.Label module2Unit;
        private System.Windows.Forms.Label module3Unit;
        private System.Windows.Forms.Label module1Unit;
        private System.Windows.Forms.ContextMenuStrip emptyMenuStrip;
        private System.Windows.Forms.Timer refreshModuleData;
        private System.Windows.Forms.PictureBox alarmDisplay4;
        private System.Windows.Forms.PictureBox alarmDisplay3;
        private System.Windows.Forms.PictureBox alarmDisplay2;
        private System.Windows.Forms.PictureBox alarmDisplay1;
    }
}