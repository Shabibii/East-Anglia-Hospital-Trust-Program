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

namespace Software_Engineering_Assignment
{
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
        {
            InitializeComponent();
        }

        private bool ListContains(Staff staff)
        {
            foreach (ListViewItem item in onCallStaffList.Items)
            {
                if (((StaffListViewItem)item).staff == staff) return true;
            }

            return false;
        }

        private void DisplayOnCallStaff()
        {
            List<Staff> onCallStaff = DatabaseConnector.Instance.GetOnCallStaff(DateTime.Now.ToString("yyyy-MM-dd"));
            //onCallStaffList.Clear();

            foreach (StaffListViewItem item in onCallStaffList.Items)
            {
                if(!onCallStaff.Contains(item.staff))
                {
                    //if staff is no longer on call
                    onCallStaffList.Items.Remove(item);
                }
            }

            if (onCallStaff == null) return;

            if (onCallStaff.Count > 0)
            {
                foreach (Staff staff in onCallStaff)
                {
                    if(!ListContains(staff))
                    {
                        onCallStaffList.Items.Add(new StaffListViewItem(staff));
                    }
                }
            }
        }

        private void RefreshDisplayData_Tick(object sender, EventArgs e)
        {
            //Display data, check for changes and repeat
            DisplayOnCallStaff();
        }

        public void StartRealtimeDataDisplay()
        {
            refreshDisplayData.Start();
        }
    }
}
