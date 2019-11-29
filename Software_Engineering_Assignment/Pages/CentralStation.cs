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

        public CentralStation(Main.PageCall2 patientPageCall)
        {
            InitializeComponent();
            InitializeBays(patientPageCall);
            timer.Start();
            Text = "Central Station";

            eventRegister.StartRealtimeDataDisplay();
        }

        public BayPreviewControl BayPreviewControl
        {
            get => default;
            set
            {
            }
        }

        public RegisterControl event_Register
        {
            get => default;
            set
            {
            }
        }

        public void InitializeBays(Main.PageCall2 patientPageCall)
        {
            bay1.SetBay(new Bay(1), patientPageCall);
            bay2.SetBay(new Bay(2), patientPageCall);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dateTimeLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void ManagementButton_Click(object sender, EventArgs e)
        {
            using (Login login = new Login())
            {
                //If login button clicked on the login form
                if (login.ShowDialog() == DialogResult.Yes)
                {
                    Staff staff = login.Staff;

                    if (staff == null)
                    {
                        //If invalid login
                        MessageBox.Show("Invalid Login", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (staff.StaffType == 0)
                    {
                        //if regular staff member
                        MessageBox.Show("You are not authorized to view this page", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //if is manager
                        ManagementPageCall();
                    }
                }
            }
            
        }

        private void BayControl1_Click(object sender, EventArgs e)
        {
            BayPageCall(1);
        }

        private void BayControl2_Click(object sender, EventArgs e)
        {
            BayPageCall(2);
        }

        private void RegisterationButton_Click(object sender, EventArgs e)
        {
            using (Login login = new Login())
            {
                //If login button clicked on the login form
                if (login.ShowDialog() == DialogResult.Yes)
                {
                    Staff staff = login.Staff;

                    if (staff == null)
                    {
                        //If invalid login
                        MessageBox.Show("Invalid Login", "Invalid login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //if valid login of any staff type
                        RegisterationPageCall();
                    }
                }
            }
        }
    }
}
