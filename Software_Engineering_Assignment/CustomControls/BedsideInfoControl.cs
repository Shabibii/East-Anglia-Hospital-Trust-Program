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
        Image WarningImage => Alarm() ? Properties.Resources.ImportantNotification3 : null;

        public delegate void PageCall(int bayNumber, int bedNumber);
        public PageCall PatientPageCall = delegate { };

        public BedsideInfoControl()
        {
            InitializeComponent();
            button2.Image = WarningImage;
        }

        bool Alarm()
        {
            return false;
        }

        public void AssignPatient(Patient p)
        {
            patient = p;

            textBox1.Clear();
            textBox1.Text = $"{Environment.NewLine}";
            textBox1.Text += $"{p.FirstName} {p.Surname}{Environment.NewLine}";
            textBox1.Text += $"{p.Gender}{Environment.NewLine}";
            textBox1.Text += $"{p.DOB}{Environment.NewLine}";
            textBox1.Text += $"{p.IntakeReason}{Environment.NewLine}";
            textBox1.Text += $"{p.ModulesActive}";

            button2.Text = $"Bedside {p.bedNumber}";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PatientPageCall(patient.bayNumber, patient.bedNumber);
        }
    }
}
 