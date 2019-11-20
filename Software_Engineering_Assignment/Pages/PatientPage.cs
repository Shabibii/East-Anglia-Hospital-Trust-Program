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
            nameLabel.Text = $"First Name: {currentPatient.FirstName}";
            surnameLabel.Text = $"Last Name: {currentPatient.Surname}";
            dobLabel.Text = $"Date of Birth: {currentPatient.DOB}";
            intakeReasonLabel.Text = $"Intake Reason: {currentPatient.IntakeReason}";

            module1ModuleType.Text = currentPatient.Module1.ToString();
            module1CurrentReading.Text = currentPatient.Module1.CurrentValue.ToString();
            module1Max.Text = currentPatient.Module1.MaxValue.ToString();
            module1Min.Text = currentPatient.Module1.MinValue.ToString();

            module2ModuleType.Text = currentPatient.Module2.currentModule.ToString();
            module2CurrentReading.Text = currentPatient.Module2.CurrentValue.ToString();
            module2Max.Text = currentPatient.Module2.MaxValue.ToString();
            module2Min.Text = currentPatient.Module2.MinValue.ToString();

            module3ModuleType.Text = currentPatient.Module3.currentModule.ToString();
            module3CurrentReading.Text = currentPatient.Module3.CurrentValue.ToString();
            module3Max.Text = currentPatient.Module3.MaxValue.ToString();
            module3Min.Text = currentPatient.Module3.MinValue.ToString();

            module4ModuleType.Text = currentPatient.Module4.currentModule.ToString();
            module4CurrentReading.Text = currentPatient.Module4.CurrentValue.ToString();
            module4Max.Text = currentPatient.Module4.MaxValue.ToString();
            module4Min.Text = currentPatient.Module4.MinValue.ToString();

            Text = currentPatient.FullName;

            InitalizeControl();
         }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (Login login = new Login())
            {
                //If login button clicked on the login form
                if (login.ShowDialog() == DialogResult.Yes)
                {
                    Staff staff = login.Staff;

                    if (staff == null)
                    {
                        //If invalid login
                        MessageBox.Show("Invalid Login", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //if valid login of any staff type
                        //tell event log that staff logged in to edit patient data
                        //enable textboxes for change
                    }
                }
            }
        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
