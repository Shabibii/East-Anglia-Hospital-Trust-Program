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
    public partial class DoctorRegistrationFieldControl : UserControl
    {
        /// <summary>
        /// Get staff name + staff Id from database.
        /// Add in label doctorName & staffId.
        /// </summary>
        /// <param name="staff"></param>
        private readonly Staff currentStaff;
        public DoctorRegistrationFieldControl(Staff staff)
        {
            InitializeComponent();
            currentStaff = staff;
            staffNameText.Text = staff.FirstName;
            staffIdText.Text = staff.StaffId.ToString();
        }

        private int Login()
        {
            //Attempts Login
            //Returns -1 if invalid
            //0 or 1 (Staff type if login is valid)
            using (Login login = new Login())
            {
                //If login button clicked on the login form
                if (login.ShowDialog() == DialogResult.Yes)
                {
                    Staff staff = login.Staff;

                    if (staff == null) return -1;
                    else return staff.StaffType;
                }
            }
            return -2;
        }

        /// <summary>
        /// Add selected staff member to available staff 
        /// after clicking registerButton1, but first login!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void registerButton_Click(object sender, EventArgs e)
        {
            int staffType = Login();
            if (staffType == -2) return;

            // If login is correct
            if (staffType != -1)
                // Staff is given access, activate change
                RegisterStaff(); 
            // Login not correct
            else 
                // Message user
                MessageBox.Show("Invalid Login", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Warning);                       
        }

        public void RegisterStaff()
        {
            // Register staff   
            DatabaseConnector.Instance.RegisterStaff(currentStaff.StaffId, dateRegisterActivity.Value.ToString("yyyy-MM-dd"));
            DatabaseConnector.Instance.LogEvent($"Registered for shift ({staffNameText.Text})", "Staff", int.Parse(staffIdText.Text));
        }

        /// <summary>
        /// Add selected staff member to unavailable staff 
        /// after clicking deregisterButton, but first login!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deregisterButton_Click(object sender, EventArgs e)
        {
            int staffType = Login();
            if (staffType == -2) return;

            // If login is correct
            if (staffType != -1)
                // Staff is given access, activate change
                DeregisterStaff();
            // Login not correct
            else
                // Message user
                MessageBox.Show("Invalid Login", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void DeregisterStaff()
        {
            // Deregister staff
            DatabaseConnector.Instance.UnregisterStaff(currentStaff.StaffId, dateRegisterActivity.Value.ToString("yyyy-MM-dd"));
            DatabaseConnector.Instance.LogEvent("Deregistered from shift", "Staff", int.Parse(staffIdText.Text));
        }
    }

}
