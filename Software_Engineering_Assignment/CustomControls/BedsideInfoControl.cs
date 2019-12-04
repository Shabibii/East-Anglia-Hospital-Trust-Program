using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_Engineering_Assignment.Support_Classes;

namespace Software_Engineering_Assignment.CustomControls
{
    public partial class BedsideInfoControl : UserControl
    {
        private Patient patient;
        Image WarningImage => Alarm ? Properties.Resources.ImportantNotification3 : null;

        public delegate void PageCall(int bayNumber, int bedNumber);
        public PageCall PatientPageCall = delegate { };

        public BedsideInfoControl()
        {
            InitializeComponent();
            button2.Image = WarningImage;
        }

        bool Alarm = false;

        public void AssignPatient(Patient p)
        {
            //Assign patient to bedside
            patient = p;
            patient.ThrowPatientAlarm = ThrowAlarm;

            textBox1.Clear();
            textBox1.Text = $"{Environment.NewLine}";
            textBox1.Text += $"{p.FirstName} {p.Surname}{Environment.NewLine}";
            textBox1.Text += $"{p.Gender}{Environment.NewLine}";
            textBox1.Text += $"{p.DOB}{Environment.NewLine}";
            textBox1.Text += $"{p.IntakeReason}{Environment.NewLine}";
            textBox1.Text += $"{p.ModulesActive}";

            string name = $"{Environment.NewLine}({p.FirstName}{Environment.NewLine}{p.Surname})";
            button2.Text = $"Bedside {p.bedNumber}{Environment.NewLine}{name}";
        }

        private void ThrowAlarm(Patient patient, bool on)
        {
            Alarm = on;
            button2.Image = WarningImage;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PatientPageCall(patient.bayNumber, patient.bedNumber);
        }
    }
}
 