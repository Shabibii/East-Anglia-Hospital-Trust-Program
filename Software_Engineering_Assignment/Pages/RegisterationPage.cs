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
    public partial class RegisterationPage : UserControl
    {
        List<Staff> allStaff; 

        public RegisterationPage()
        {
            InitializeComponent();
            ConnectWithDB();
        }

        private void ConnectWithDB()
        {
            allStaff = DatabaseConnector.Instance.GetAllStaff();

            List<Staff> availableStaff = new List<Staff>();
            List<Staff> unavailableStaff = new List<Staff>();
            List<Staff> onCallStaff = new List<Staff>();


            foreach (Staff staff in allStaff)
            {
                if (staff.isAvailable)
                {
                    availableStaff.Add(staff);
                }
                else if (staff.isOnCall)
                {
                    onCallStaff.Add(staff);
                }
                else
                {
                    unavailableStaff.Add(staff);
                }
            }

            unavailableStaff1.GetUnavailableStaff(unavailableStaff);
            //staffAvailabilityControl1.GetAvailableStaff(availableStaff);

        }

        


    }
}
