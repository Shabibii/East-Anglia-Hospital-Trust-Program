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
            doctorName.Text = staff.FirstName;
            staffId.Text = staff.StaffId.ToString();
        }

        /// <summary>
        /// Add selected staff member to available staff 
        /// after clicking registerButton1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RegisterStaff(object sender, EventArgs e)
        {
            // Register staff   
            DatabaseConnector.Instance.RegisterStaff(currentStaff.StaffId, dateTimePicker2.Value.ToString("yyyy-MM-dd"));
            //DatabaseConnector.Instance.LogEvent($"{currentStaff.} Module data changed");
        }

        /// <summary>
        /// Add selected staff member to unavailable staff 
        /// after clicking deregisterButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnregisterStaff(object sender, EventArgs e)
        {
            // Deregister staff
            DatabaseConnector.Instance.UnregisterStaff(currentStaff.StaffId, dateTimePicker2.Value.ToString("yyyy-MM-dd"));
        }
    }
}
