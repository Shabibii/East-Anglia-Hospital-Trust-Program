﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Assignment
{
    public partial class BayPreviewControl : UserControl
    {
        Bay bay;

        public BayPreviewControl()
        {
            InitializeComponent();
            pictureBox1.Hide();
        }

        public void SetBay(Bay bay)
        {
            this.bay = bay;
            SetProperties();

        }

        private void SetProperties()
        {
            title.Text = $"Bay {bay.BayNumber}";
            linkLabel1.Text = $"(1) {bay.GetPatient(1).FirstName}";
            linkLabel2.Text = $"(2) {bay.GetPatient(2).FirstName}";
            linkLabel3.Text = $"(3) {bay.GetPatient(3).FirstName}";
            linkLabel4.Text = $"(4) {bay.GetPatient(4).FirstName}";
            linkLabel5.Text = $"(5) {bay.GetPatient(5).FirstName}";
            linkLabel6.Text = $"(6) {bay.GetPatient(6).FirstName}";
            linkLabel7.Text = $"(7) {bay.GetPatient(7).FirstName}";
            linkLabel8.Text = $"(8) {bay.GetPatient(8).FirstName}";

            this.DoubleBuffered = true;
        }

        public void DisplayWarningSign()
        {
            //Display warning sign (Show that an alarm is triggered regarding patient in current bay)
            pictureBox1.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Bay_MouseHover(object sender, EventArgs e)
        {
            
            BackColor = Color.Gainsboro;
        }

        private void Bay_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Color.DarkGray;
        }

        private void Bay_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = Color.White;
        }

        private void BayControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
