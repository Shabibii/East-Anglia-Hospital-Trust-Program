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
        public delegate void registerationStateEvent();
        public registerationStateEvent registrationStateChanged;
        
        public StaffRegistrationControl()
        {
            InitializeComponent();
            //RegisterField();
        }
        
      

        /// <summary>
        /// Method to get each doctorRegistrationFieldControl 
        /// and present in StaffRegistrationControl as a list
        /// </summary>
        public void InitalizeRegisterField()
        {
            var allStaff = DatabaseConnector.Instance.GetAllStaff();

            foreach (Staff staff in allStaff)
            {
                var docReg = new doctorRegistrationFieldControl(staff) { BorderStyle = BorderStyle.FixedSingle };

                docReg.registerButton1.Click += staffStatusChange;
                docReg.deregisterButton.Click += staffStatusChange;

                if (!staffRegisterList.Controls.Contains(docReg))
                {
                    staffRegisterList.Controls.Add(docReg);
                }
                else
                {
                    
                }
                                         
            }
        }

        public void staffStatusChange(object sender, EventArgs e)
        {
            registrationStateChanged();
        }

      

        //Registeration field control
        /*
         * Get doctors from database
         * create many regFControls for the doctors
         * Add controls to panel (with auto scroll(scroll bar))
         */
    }
}
