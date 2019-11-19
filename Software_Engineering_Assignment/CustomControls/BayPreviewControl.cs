using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_Engineering_Assignment.Pages;
using Software_Engineering_Assignment.Support_Classes;

namespace Software_Engineering_Assignment
{
    public partial class BayPreviewControl : UserControl
    {
        Bay bay;

        public Main.PageCall2 PatientPageCall = delegate { };

        public BayPreviewControl()
        {
            InitializeComponent();
            pictureBox1.Hide();
        }

        public void SetBay(Bay bay, Main.PageCall2 patientPageCall)
        {
            this.bay = bay;
            SetProperties();
            PatientPageCall = patientPageCall;
        }

      
        private void SetProperties()
        {
            title.Text = $"Bay {bay.BayNumber}";
            linkLabel1.Text = $"(1) {bay.GetPatient(1).FullName}";
            linkLabel2.Text = $"(2) {bay.GetPatient(2).FullName}";
            linkLabel3.Text = $"(3) {bay.GetPatient(3).FullName}";
            linkLabel4.Text = $"(4) {bay.GetPatient(4).FullName}";
            linkLabel5.Text = $"(5) {bay.GetPatient(5).FullName}";
            linkLabel6.Text = $"(6) {bay.GetPatient(6).FullName}";
            linkLabel7.Text = $"(7) {bay.GetPatient(7).FullName}";
            linkLabel8.Text = $"(8) {bay.GetPatient(8).FullName}";

            this.DoubleBuffered = true;
        }

        public void DisplayWarningSign()
        {
            //Display warning sign (Show that an alarm is triggered regarding patient in current bay)
            pictureBox1.Show();
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

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientPageCall(bay.BayNumber, 1);
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientPageCall(bay.BayNumber, 2);
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientPageCall(bay.BayNumber, 3);
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientPageCall(bay.BayNumber, 4);
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientPageCall(bay.BayNumber, 5);
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientPageCall(bay.BayNumber, 6);
        }

        private void LinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientPageCall(bay.BayNumber, 7);
        }

        private void LinkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientPageCall(bay.BayNumber, 8);
        }
    }
}
