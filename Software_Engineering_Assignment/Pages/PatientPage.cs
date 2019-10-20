using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Assignment.Pages
{
    public partial class PatientPage : UserControl
    {
        Patient currentPatient;

        public delegate void PageCall();

        public PatientPage(PageCall previousPageCall)
        {
            InitializeComponent();
            InitalizeControl();
            button1.Click += delegate { previousPageCall();  };
        }

        private void InitalizeControl()
        {
            //Set up runtime graphics up
            if (currentPatient != null)
                label10.Text = $"Bedside {currentPatient.bedNumber}";
            CentralizeDisplay();
        }

        public void CentralizeDisplay()
        {
            int x = (Width - panel1.Width) / 2;
            int y = (Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }

        public void SetPatient(int bayNumber, int bedNumber)
        {
            currentPatient = DatabaseConnector.GetPatient(bayNumber, bedNumber);
            InitalizeControl();
        }
    }
}
