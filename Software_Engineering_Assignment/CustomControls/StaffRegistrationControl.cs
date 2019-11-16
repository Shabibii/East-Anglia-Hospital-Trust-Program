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
    public partial class StaffRegistrationControl : UserControl
    {
        public StaffRegistrationControl()
        {
            InitializeComponent();
            //RegisterField();
        }
        
      

        /// <summary>
        /// Method to get each doctorRegistrationFieldControl 
        /// and present in StaffRegistrationControl as a list
        /// </summary>
        private void RegisterField()
        {
            var allStaff = DatabaseConnector.Instance.GetAllStaff();

            foreach (Staff staff in allStaff)
            {
                staffRegisterList.Controls.Add(new doctorRegistrationFieldControl(staff));
            }
        }

        //Registeration field control
        /*
         * Get doctors from database
         * create many regFControls for the doctors
         * Add controls to panel (with auto scroll(scroll bar))
         */
    }
}
