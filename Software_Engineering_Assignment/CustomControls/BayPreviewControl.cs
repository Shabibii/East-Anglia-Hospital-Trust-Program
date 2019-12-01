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
            alarmDisplay.Hide();
        }

        public Bay Bay
        {
            get => default;
            set
            {
            }
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
            patient1.Text = $"(1) {bay.GetPatient(1).FullName}";
            patient2.Text = $"(2) {bay.GetPatient(2).FullName}";
            patient3.Text = $"(3) {bay.GetPatient(3).FullName}";
            patient4.Text = $"(4) {bay.GetPatient(4).FullName}";
            patient5.Text = $"(5) {bay.GetPatient(5).FullName}";
            patient6.Text = $"(6) {bay.GetPatient(6).FullName}";
            patient7.Text = $"(7) {bay.GetPatient(7).FullName}";
            patient8.Text = $"(8) {bay.GetPatient(8).FullName}";
            DoubleBuffered = true;
        }

        private void Bay_MouseHover(object sender, EventArgs e) => BackColor = Color.Gainsboro;

        private void Bay_MouseDown(object sender, MouseEventArgs e) => BackColor = Color.DarkGray;

        private void Bay_MouseUp(object sender, MouseEventArgs e) => BackColor = Color.White;

        private void BayControl_MouseLeave(object sender, EventArgs e) => BackColor = Color.White;

        private void Patient1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(bay.BayNumber, 1);

        private void Patient2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(bay.BayNumber, 2);

        private void Patient3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(bay.BayNumber, 3);

        private void Patient4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(bay.BayNumber, 4);

        private void Patient5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(bay.BayNumber, 5);

        private void Patient6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(bay.BayNumber, 6);

        private void Patient7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(bay.BayNumber, 7);

        private void Patient8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(bay.BayNumber, 8);

        private void AlarmCheck_Tick(object sender, EventArgs e)
        {
            if (bay.ThrowAlarm())
            {
                alarmDisplay.Show();
            }
            else
            {
                alarmDisplay.Hide();
            }
        }
    }
}
