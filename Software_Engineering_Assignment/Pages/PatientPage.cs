using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_Engineering_Assignment.Support_Classes;

namespace Software_Engineering_Assignment.Pages
{
    public partial class PatientPage : UserControl
    {
        Patient currentPatient;

        public PatientPage(Main.PageCall0 previousPageCall)
        {
            InitializeComponent();
            InitalizeControl();
            //Set button1 event handler to delegate that exits the current page and goes to the previous
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
            //Make sure panel holding patient information is at the centre of the screen
            int x = (Width - panel1.Width) / 2;
            int y = (Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }

        public void SetPatient(int bayNumber, int bedNumber)
        {
            //Fill up patient object with data from the database
            currentPatient = DatabaseConnector.Instance.GetPatient(bayNumber, bedNumber);

            InitalizeControl();
        }
    }
}
