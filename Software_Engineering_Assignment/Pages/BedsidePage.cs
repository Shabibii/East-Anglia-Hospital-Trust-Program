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
        Bedside currentBedside;
        Main.PageCall0 previousPageCall;
        public Main.PageCall3 NavBack;
        public Main.PageCall3 NavForward;

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
            if (currentBedside != null)
                label10.Text = $"Bedside {currentBedside.BedsideNo}";
            CentralizeDisplay();
        }

        public void CentralizeDisplay()
        {
            //Make sure panel holding patient information is at the centre of the screen
            int x = (Width - panel1.Width) / 2;
            int y = (Height - panel1.Height) / 2;
            panel1.Location = new Point(x, y);
        }

        public void SetBedside(Bedside bedside)
        {
            //Fill up patient object with data from the database
            currentBedside = bedside;

            nameLabel.Text = $"First Name: {currentBedside.patient.FirstName}";
            surnameLabel.Text = $"Last Name: {currentBedside.patient.Surname}";
            dobLabel.Text = $"Date of Birth: {currentBedside.patient.DOB}";
            intakeReasonLabel.Text = $"Intake Reason: {currentBedside.patient.IntakeReason}";



            var moduleTypeSource = Module.ModuleTypes(); // Different module functionality
            module1ModuleType.Items.AddRange(moduleTypeSource);
            module2ModuleType.Items.AddRange(moduleTypeSource);
            module3ModuleType.Items.AddRange(moduleTypeSource);
            module4ModuleType.Items.AddRange(moduleTypeSource);
            DisplayModuleData();

            Text = currentBedside.patient.FullName;

            InitalizeControl();
            saveButton.Visible = false;
            LockInputControls(true);
        }

        private void DisplayModuleData()
        {
            if (currentBedside.patient.Module1 != null)
            {
                module1CurrentReading.Text = currentBedside.patient.Module1.CurrentValue.ToString();
                module1Max.Text = currentBedside.patient.Module1.MaxValue.ToString();
                module1Min.Text = currentBedside.patient.Module1.MinValue.ToString();
                module1Unit.Text = currentBedside.patient.Module1.ModuleUnit;
                module1ModuleType.SelectedIndex = (int)currentBedside.patient.Module1.currentModule;
            }

            if (currentBedside.patient.Module2 != null)
            {
                module2CurrentReading.Text = currentBedside.patient.Module2.CurrentValue.ToString();
                module2Max.Text = currentBedside.patient.Module2.MaxValue.ToString();
                module2Min.Text = currentBedside.patient.Module2.MinValue.ToString();
                module2Unit.Text = currentBedside.patient.Module2.ModuleUnit;
                module2ModuleType.SelectedIndex = (int)currentBedside.patient.Module2.currentModule;
            }

            if (currentBedside.patient.Module3 != null)
            {
                module3CurrentReading.Text = currentBedside.patient.Module3.CurrentValue.ToString();
                module3Max.Text = currentBedside.patient.Module3.MaxValue.ToString();
                module3Min.Text = currentBedside.patient.Module3.MinValue.ToString();
                module3Unit.Text = currentBedside.patient.Module3.ModuleUnit;
                module3ModuleType.SelectedIndex = (int)currentBedside.patient.Module3.currentModule;
            }

            if (currentBedside.patient.Module4 != null)
            {
                module4CurrentReading.Text = currentBedside.patient.Module4.CurrentValue.ToString();
                module4Max.Text = currentBedside.patient.Module4.MaxValue.ToString();
                module4Min.Text = currentBedside.patient.Module4.MinValue.ToString();
                module4Unit.Text = currentBedside.patient.Module4.ModuleUnit;
                module4ModuleType.SelectedIndex = (int)currentBedside.patient.Module4.currentModule;
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
            if(currentBedside.patient.IsEmpty)
            {
                return; // Do not allow data to be edited if patient is not assigned to current bedside
            }
            refreshModuleData.Stop();
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

                        DatabaseConnector.Instance.LogEvent($"logged in to change {currentBedside.patient.FullName} module data", "Staff", staff.StaffId);
                    }
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveButton.Visible = false;
            LockInputControls(true);

            //Register module changes
            currentBedside.patient.Module1.currentModule = Module.GetModuleFromString(module1ModuleType.Text);
            currentBedside.patient.Module1.CurrentValue = decimal.Parse(module1CurrentReading.Text);
            currentBedside.patient.Module1.MaxValue = decimal.Parse(module1Max.Text);
            currentBedside.patient.Module1.MinValue = decimal.Parse(module1Min.Text);

            currentBedside.patient.Module2.currentModule = Module.GetModuleFromString(module2ModuleType.Text);
            currentBedside.patient.Module2.CurrentValue = decimal.Parse(module2CurrentReading.Text);
            currentBedside.patient.Module2.MaxValue = decimal.Parse(module2Max.Text);
            currentBedside.patient.Module2.MinValue = decimal.Parse(module2Min.Text);

            currentBedside.patient.Module3.currentModule = Module.GetModuleFromString(module3ModuleType.Text);
            currentBedside.patient.Module3.CurrentValue = decimal.Parse(module3CurrentReading.Text);
            currentBedside.patient.Module3.MaxValue = decimal.Parse(module3Max.Text);
            currentBedside.patient.Module3.MinValue = decimal.Parse(module3Min.Text);

            currentBedside.patient.Module4.currentModule = Module.GetModuleFromString(module4ModuleType.Text);
            currentBedside.patient.Module4.CurrentValue = decimal.Parse(module4CurrentReading.Text);
            currentBedside.patient.Module4.MaxValue = decimal.Parse(module4Max.Text);
            currentBedside.patient.Module4.MinValue = decimal.Parse(module4Min.Text);

            DatabaseConnector.Instance.UpdateModule(currentBedside.patient.Module1, true);
            DatabaseConnector.Instance.UpdateModule(currentBedside.patient.Module2, true);
            DatabaseConnector.Instance.UpdateModule(currentBedside.patient.Module3, true);
            DatabaseConnector.Instance.UpdateModule(currentBedside.patient.Module4, true);

            refreshModuleData.Start();
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
            try
            {
                if (currentBedside == null) return;

                alarmDisplay1.Visible = currentBedside.patient.Module1.ThrowAlarm;
                alarmDisplay2.Visible = currentBedside.patient.Module2.ThrowAlarm;
                alarmDisplay3.Visible = currentBedside.patient.Module3.ThrowAlarm;
                alarmDisplay4.Visible = currentBedside.patient.Module4.ThrowAlarm;

                DisplayModuleData();
            }
            catch (Exception)
            {
                refreshModuleData.Stop();
            }
            
        }

        

        private bool MuteAlarm()
        {
            if (saveButton.Visible) return true;
             
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
                        return false;
                    }
                    else
                    {
                        //if valid login of any staff type
                        //tell event log that staff logged in to edit patient data
                        //enable textboxes for change
                        
                        DatabaseConnector.Instance.LogEvent($"Muted {currentBedside.patient.FullName} module alarm", "Staff", staff.StaffId);
                        return true;
                    }
                }
            }
            return false;
        }

        private void alarmDisplay1_Click(object sender, EventArgs e)
        {
            DatabaseConnector.Instance.LogEvent($"Module 1 on bedside Nuted", "Bedside", currentBedside.BedsideId);
            if (MuteAlarm())
                currentBedside.patient.MuteModule(1);
        }

        private void alarmDisplay2_Click(object sender, EventArgs e)
        {
            DatabaseConnector.Instance.LogEvent($"Module 2 on bedside Nuted", "Bedside", currentBedside.BedsideId);
            if (MuteAlarm())
                currentBedside.patient.MuteModule(2);
        }

        private void alarmDisplay3_Click(object sender, EventArgs e)
        {
            DatabaseConnector.Instance.LogEvent($"Module 3 on bedside Nuted", "Bedside", currentBedside.BedsideId);
            if (MuteAlarm())
                currentBedside.patient.MuteModule(3);
        }

        private void alarmDisplay4_Click(object sender, EventArgs e)
        {
            DatabaseConnector.Instance.LogEvent($"Module 4 on bedside Muted", "Bedside", currentBedside.BedsideId);
            if (MuteAlarm())
                currentBedside.patient.MuteModule(4);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentBedside.BedsideNo == 1) return;

            if (currentBedside.BayNo == 1)
            {
                SetBedside(Main.bay1.GetBedside(currentBedside.BedsideNo - 1));
            }

            if (currentBedside.BayNo == 2)
            {
                SetBedside(Main.bay2.GetBedside(currentBedside.BedsideNo - 1));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (currentBedside.BedsideNo == 8) return;
            if (currentBedside.BayNo == 1)
            {
                SetBedside(Main.bay1.GetBedside(currentBedside.BedsideNo + 1));
            }

            if (currentBedside.BayNo == 2)
            {
                SetBedside(Main.bay2.GetBedside(currentBedside.BedsideNo + 1));
            }

        }
    }
}
