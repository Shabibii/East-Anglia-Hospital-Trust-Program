using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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
        
        public void InitalizeRegisterField()
        {
            var allStaff = DatabaseConnector.Instance.GetAllStaff();

            DisplayStaff(allStaff);
        }

        /// <summary>
        /// Method to get each doctorRegistrationFieldControl 
        /// and present in StaffRegistrationControl as a list.
        /// Also, give functionality to register and deregister button.
        /// </summary>
        /// <param name="staffList"></param>
        public void DisplayStaff(List<Staff> staffList)
        {
            staffRegisterList.Controls.Clear();
            foreach (Staff staff in staffList)
            {
                var docReg = new DoctorRegistrationFieldControl(staff) { BorderStyle = BorderStyle.FixedSingle };

                docReg.registerButton.Click += staffStatusRegister;
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

        /// <summary>
        /// SearchButton functionality, search in staff list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e)
        {            
            Search();
        }

        /// <summary>
        /// Method when no match is found (user search input)
        /// </summary>
        public void NoResult()
        {
            MessageBox.Show("Invalid Search!");
        }

        /// <summary>
        /// Search box functionality, used RegularExpression to compare user input
        /// with staff database.
        /// </summary>
        private void Search()
        {
            try
            {
                var allStaff = DatabaseConnector.Instance.GetAllStaff();

                string pattern = searchTextBox.Text;
                Regex rg = new Regex(pattern, RegexOptions.IgnoreCase);

                var staffList = allStaff.Where(x => rg.IsMatch(x.FirstName)).ToList();
                
                if (staffList.Count > 0)
                {
                    DisplayStaff(staffList);
                }
            }
            catch (Exception)
            {
                NoResult();
                InitalizeRegisterField();
            }           
        }

        /// <summary>
        /// Also, method to compare user input with staff in database after user presses "Enter".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
    }
}
