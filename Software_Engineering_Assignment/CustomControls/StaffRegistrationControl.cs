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
        // Use delegate function to assign method for change in staff status
        public delegate void registerationStateEvent();
        public registerationStateEvent registrationStateChanged;
        
        public StaffRegistrationControl()
        {
            InitializeComponent();
        }     
      
        /// <summary>
        /// Method to get each doctorRegistrationFieldControl 
        /// and present in StaffRegistrationControl as a list.
        /// Also, give functionality to register and deregister button.
        /// </summary>
        public void InitalizeRegisterField()
        {
            var allStaff = DatabaseConnector.Instance.GetAllStaff();

            foreach (Staff staff in allStaff)
            {
                var docReg = new doctorRegistrationFieldControl(staff) { BorderStyle = BorderStyle.FixedSingle };
                
                docReg.registerButton1.Click += staffStatusRegister;
                docReg.deregisterButton.Click += staffStatusDeregister;                
               
                staffRegisterList.Controls.Add(docReg);           
            }
        }

        //Register selected staff 
        public void staffStatusRegister(object sender, EventArgs e)
        {
            registrationStateChanged();            
        }

        //Deregister selected staff
        public void staffStatusDeregister(object sender, EventArgs e)
        {
            registrationStateChanged();
        }
    }
}
