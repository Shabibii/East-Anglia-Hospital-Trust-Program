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
    public partial class CentralStation : UserControl
    {
        public Main.PageCall1 BayPageCall;
        public Main.PageCall0 ManagementPageCall;
        public Main.PageCall0 RegisterationPageCall;

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

        public CentralStation(Main.PageCall2 patientPageCall)
        {
            InitializeComponent();
            InitializeBays(patientPageCall);
            timer.Start();
            Text = "Central Station";

            eventRegister.StartRealtimeDataDisplay();
        }

        
        public void InitializeBays(Main.PageCall2 patientPageCall)
        {
            bay1.SetBay(new Bay(1), patientPageCall);
            bay2.SetBay(new Bay(2), patientPageCall);
        }

        private void Timer_Tick(object sender, EventArgs e) 
            => dateTimeLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"); //Display current time

        private void ManagementButton_Click(object sender, EventArgs e)
        {
            int staffType = Login();
            if (staffType == -2) return;
            //If login is invalid
            if (staffType == -1)
                MessageBox.Show("Invalid Login", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Warning); //If invalid login
            else if (staffType == 0)
                MessageBox.Show("You are not authorized to view this page", 
                    "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Warning); //if regular staff member
            else
                ManagementPageCall(); //if is manager
        }

        private void RegisterationButton_Click(object sender, EventArgs e) => RegisterationPageCall();        

        private void BayControl1_Click(object sender, EventArgs e) => BayPageCall(1);

        private void BayControl2_Click(object sender, EventArgs e) => BayPageCall(2);
    }
}
