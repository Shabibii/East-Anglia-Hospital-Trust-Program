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
    public partial class doctorRegistrationFieldControl : UserControl
    {
        /// <summary>
        /// Get staff name + staff Id from database.
        /// Add in label doctorName & staffId.
        /// </summary>
        /// <param name="staff"></param>
        public doctorRegistrationFieldControl(Staff staff)
        {
            InitializeComponent();

            doctorName.Text = staff.FirstName;
            staffId.Text = staff.StaffId.ToString();

            
        }

        List<Staff> allStaff;
        /// <summary>
        /// Add selected staff member to available staff 
        /// after clicking registerButton1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerButton1_Click(object sender, EventArgs e)
        {
           // Staff staff             
        }
    }
}
