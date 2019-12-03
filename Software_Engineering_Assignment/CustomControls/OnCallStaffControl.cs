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
    public partial class OnCallStaffControl : UserControl
    {
        public OnCallStaffControl()
        {
            InitializeComponent();
        }

        // Get on call staff for selected date using the monthCalendar
        private void calendarOnCallStaff_DateChanged(object sender, DateRangeEventArgs e)
        {
            DisplayOnCallStaff();
        }

        // Check if selected staff (registered) is already in the on call list, for that date.
        private bool registerListDoubleStaff(int staffId)
        {
            foreach (StaffListViewItem listItem in StaffOncallList.Items)
            {
                if (listItem.staff.StaffId == staffId) return true;
            }
            return false;
        }

        // Method removes staff from on call list
        public void RemoveOnCallStaffItem(StaffListViewItem item)
        {
            StaffOncallList.Items.Remove(item);
        }

        // Method to hold each on call staff displayed on GUI.
        public List<Staff> DisplayedStaff()
        {
            List<Staff> output = new List<Staff>();
            foreach (StaffListViewItem item in StaffOncallList.Items)
            {
                output.Add(item.staff);
            }
            return output;
        }

        /// <summary>
        /// Method to add selected staff to on call list && display on GUI.
        /// </summary>
        public void DisplayOnCallStaff()
        {
            // Get on call staff for date
            List<Staff> onCallStaff = DatabaseConnector.Instance.GetOnCallStaff(calendarOnCallStaff.SelectionRange.Start.ToString("yyyy-MM-dd"));
            StaffOncallList.Clear();

            if (onCallStaff == null) return;

            if(onCallStaff.Count > 0)
            {
                foreach (Staff staff in onCallStaff)
                {
                    // Only add the member to display on the list, if not already there.
                    if (!registerListDoubleStaff(staff.StaffId))
                    {
                        StaffOncallList.Items.Add(new StaffListViewItem(staff));
                    }                    
                }
            }
        }
    }
}
