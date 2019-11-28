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

namespace Software_Engineering_Assignment.Pages
{
    public partial class RegistrationPage : UserControl
    {
        public Main.PageCall0 goBackToParentPage;

        public RegistrationPage()
        {
            InitializeComponent();
            staffRegistrationControl1.InitalizeRegisterField();

            Text = "Registration Page";
            staffRegistrationControl1.registrationStateChanged += RefreshStaffStatus;
            RefreshStaffStatus();
        }

        /// <summary>
        /// Lookup & refresh Staff status. 
        /// Amend GUI accordingly.
        /// </summary>
        private void RefreshStaffStatus()
        {
            staffAvailabilityControl1.DisplayOnCallStaff();
            unavailableStaff1.DisplayUnregisterStaff();
        }       

        /// <summary>
        /// Back button on GUI, this will  guide user back to parent page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            goBackToParentPage();
        }
    }
}
