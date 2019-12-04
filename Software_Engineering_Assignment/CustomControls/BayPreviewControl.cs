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
        int selectedBay = 0;

        public Main.PageCall2 PatientPageCall = delegate { };

        static bool HasConnectedAllBays = false;

        public BayPreviewControl()
        {
            InitializeComponent();
            alarmDisplay.Hide();

            //alarmCheck.Start();
            if(HasConnectedAllBays)
            {
                Main.bay1.ThrowAlarm += AlarmThrown;
                Main.bay2.ThrowAlarm += AlarmThrown;
                HasConnectedAllBays = true;
            }
           
        }

        public void AlarmThrown(ref Patient patient, bool on)
        {
            alarmDisplay.Visible = on;
        }

        public void SetBay(int selectedBay, Main.PageCall2 patientPageCall)
        {
            this.selectedBay = selectedBay;

            if (selectedBay == 1) SetProperties(ref Main.bay1);
            else if (selectedBay == 2) SetProperties(ref Main.bay2);

            PatientPageCall = patientPageCall;
            alarmCheck.Start();
        }

      
        private void SetProperties(ref Bay bay)
        {
            title.Text = $"Bay {bay.BayNumber}";
            patient1.Text = $"(1) {bay.GetBedside(1).patient.FullName}";
            patient2.Text = $"(2) {bay.GetBedside(2).patient.FullName}";
            patient3.Text = $"(3) {bay.GetBedside(3).patient.FullName}";
            patient4.Text = $"(4) {bay.GetBedside(4).patient.FullName}";
            patient5.Text = $"(5) {bay.GetBedside(5).patient.FullName}";
            patient6.Text = $"(6) {bay.GetBedside(6).patient.FullName}";
            patient7.Text = $"(7) {bay.GetBedside(7).patient.FullName}";
            patient8.Text = $"(8) {bay.GetBedside(8).patient.FullName}";
            DoubleBuffered = true;
        }

        private void Bay_MouseHover(object sender, EventArgs e) => BackColor = Color.Gainsboro;

        private void Bay_MouseDown(object sender, MouseEventArgs e) => BackColor = Color.DarkGray;

        private void Bay_MouseUp(object sender, MouseEventArgs e) => BackColor = Color.White;

        private void BayControl_MouseLeave(object sender, EventArgs e) => BackColor = Color.White;

        private void Patient1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(selectedBay, 1);

        private void Patient2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(selectedBay, 2);

        private void Patient3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(selectedBay, 3);

        private void Patient4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(selectedBay, 4);

        private void Patient5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(selectedBay, 5);

        private void Patient6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(selectedBay, 6);

        private void Patient7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(selectedBay, 7);

        private void Patient8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => PatientPageCall(selectedBay, 8);

        private void alarmCheck_Tick(object sender, EventArgs e)
        {
            if(selectedBay == 1)
            {
                alarmDisplay.Visible = Main.bay1.Throw_Alarm;
            }
            if (selectedBay == 2)
            {
                alarmDisplay.Visible = Main.bay2.Throw_Alarm;
            }
        }

        private void BayPreviewControl_Load(object sender, EventArgs e)
        {

        }
    }
}
