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
    public partial class BedsidePage : UserControl
    {
        Patient currentPatient;
        Main.PageCall0 previousPageCall;

        public BedsidePage(Main.PageCall0 previousPageCall)
        {
            InitializeComponent();
            InitalizeControl();
            //Set button1 event handler to delegate that exits the current page and goes to the previous
            this.previousPageCall = previousPageCall;

            refreshModuleData.Start();
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



            var moduleTypeSource = Module.ModuleTypes(); // Different module functionality
            module1ModuleType.Items.AddRange(moduleTypeSource);
            module2ModuleType.Items.AddRange(moduleTypeSource);
            module3ModuleType.Items.AddRange(moduleTypeSource);
            module4ModuleType.Items.AddRange(moduleTypeSource);
            DisplayModuleData();

            Text = currentPatient.FullName;

            InitalizeControl();
        }

        private void DisplayModuleData()
        {
            if (currentPatient.Module1 != null)
            {
                module1CurrentReading.Text = currentPatient.Module1.CurrentValue.ToString();
                module1Max.Text = currentPatient.Module1.MaxValue.ToString();
                module1Min.Text = currentPatient.Module1.MinValue.ToString();
                module1Unit.Text = currentPatient.Module1.ModuleUnit;
                module1ModuleType.SelectedIndex = (int)currentPatient.Module1.currentModule;
            }

            if (currentPatient.Module2 != null)
            {
                module2CurrentReading.Text = currentPatient.Module2.CurrentValue.ToString();
                module2Max.Text = currentPatient.Module2.MaxValue.ToString();
                module2Min.Text = currentPatient.Module2.MinValue.ToString();
                module2Unit.Text = currentPatient.Module2.ModuleUnit;
                module2ModuleType.SelectedIndex = (int)currentPatient.Module2.currentModule;
            }

            if (currentPatient.Module3 != null)
            {
                module3CurrentReading.Text = currentPatient.Module3.CurrentValue.ToString();
                module3Max.Text = currentPatient.Module3.MaxValue.ToString();
                module3Min.Text = currentPatient.Module3.MinValue.ToString();
                module3Unit.Text = currentPatient.Module3.ModuleUnit;
                module3ModuleType.SelectedIndex = (int)currentPatient.Module3.currentModule;
            }

            if (currentPatient.Module4 != null)
            {
                module4CurrentReading.Text = currentPatient.Module4.CurrentValue.ToString();
                module4Max.Text = currentPatient.Module4.MaxValue.ToString();
                module4Min.Text = currentPatient.Module4.MinValue.ToString();
                module4Unit.Text = currentPatient.Module4.ModuleUnit;
                module4ModuleType.SelectedIndex = (int)currentPatient.Module4.currentModule;
            }
        }

        private void LockInputControls(bool doLock)
        {
            module1ModuleType.Enabled = !doLock;
            module1CurrentReading.ReadOnly = doLock;
            module1Max.ReadOnly = doLock;
            module1Min.ReadOnly = doLock;

            module2ModuleType.Enabled = !doLock;
            module2CurrentReading.ReadOnly = doLock;
            module2Max.ReadOnly = doLock;
            module2Min.ReadOnly = doLock;

            module3ModuleType.Enabled = !doLock;
            module3CurrentReading.ReadOnly = doLock;
            module3Max.ReadOnly = doLock;
            module3Min.ReadOnly = doLock;

            module4ModuleType.Enabled = !doLock;
            module4CurrentReading.ReadOnly = doLock;
            module4Max.ReadOnly = doLock;
            module4Min.ReadOnly = doLock;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(currentPatient.IsEmpty)
            {
                return; // Do not allow data to be edited if patient is not assigned to current bedside
            }
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
                        saveButton.Visible = true;
                        LockInputControls(false);
                        MessageBox.Show("Controls have been unlocked for Data Change");
                        //EventLog.LogStaffEvent(staff, );

                        DatabaseConnector.Instance.LogEvent($"logged in to change {currentPatient.FullName} module data", "Staff", staff.StaffId);
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveButton.Visible = false;
            LockInputControls(true);

            //Register module changes
            currentPatient.Module1.currentModule = Module.GetModuleFromString(module1ModuleType.Text);
            currentPatient.Module1.CurrentValue = decimal.Parse(module1CurrentReading.Text);
            currentPatient.Module1.MaxValue = decimal.Parse(module1Max.Text);
            currentPatient.Module1.MinValue = decimal.Parse(module1Min.Text);

            currentPatient.Module2.currentModule = Module.GetModuleFromString(module2ModuleType.Text);
            currentPatient.Module2.CurrentValue = decimal.Parse(module2CurrentReading.Text);
            currentPatient.Module2.MaxValue = decimal.Parse(module2Max.Text);
            currentPatient.Module2.MinValue = decimal.Parse(module2Min.Text);

            currentPatient.Module3.currentModule = Module.GetModuleFromString(module3ModuleType.Text);
            currentPatient.Module3.CurrentValue = decimal.Parse(module3CurrentReading.Text);
            currentPatient.Module3.MaxValue = decimal.Parse(module3Max.Text);
            currentPatient.Module3.MinValue = decimal.Parse(module3Min.Text);

            currentPatient.Module4.currentModule = Module.GetModuleFromString(module4ModuleType.Text);
            currentPatient.Module4.CurrentValue = decimal.Parse(module4CurrentReading.Text);
            currentPatient.Module4.MaxValue = decimal.Parse(module4Max.Text);
            currentPatient.Module4.MinValue = decimal.Parse(module4Min.Text);

            DatabaseConnector.Instance.UpdateModule(currentPatient.Module1);
            DatabaseConnector.Instance.UpdateModule(currentPatient.Module2);
            DatabaseConnector.Instance.UpdateModule(currentPatient.Module3);
            DatabaseConnector.Instance.UpdateModule(currentPatient.Module4);

        }

        private void Module1ModuleType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Module1CurrentReading_KeyPress(object sender, KeyPressEventArgs e)
        {
            string chr = Convert.ToString(e.KeyChar);
            if (chr == "\b") return;

            try
            {
                int.Parse(chr);
            }
            catch (Exception)
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Lock controls to protect patient module data from being mistakenly edited
            saveButton.Visible = false;
            LockInputControls(true);

            previousPageCall();
        }
        
        private void RefreshModuleData_Tick(object sender, EventArgs e)
        {
            //return;
            currentPatient.Module1.SetCurrentValue();
            currentPatient.Module2.SetCurrentValue();
            currentPatient.Module3.SetCurrentValue();
            currentPatient.Module4.SetCurrentValue();

            alarmDisplay1.Visible = currentPatient.Module1.ThrowAlarm;
            alarmDisplay2.Visible = currentPatient.Module2.ThrowAlarm;
            alarmDisplay3.Visible = currentPatient.Module3.ThrowAlarm;
            alarmDisplay4.Visible = currentPatient.Module4.ThrowAlarm;

            DatabaseConnector.Instance.UpdateModule(currentPatient.Module1);
            DatabaseConnector.Instance.UpdateModule(currentPatient.Module2);
            DatabaseConnector.Instance.UpdateModule(currentPatient.Module3);
            DatabaseConnector.Instance.UpdateModule(currentPatient.Module4);

            DisplayModuleData();
        }
    }
}
