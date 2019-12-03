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
    public partial class UnregisteredStaffControl : UserControl
    {
        // Method to hold each unregistered staff displayed on GUI.
        public List<Staff> DisplayedStaff()
        {
            List<Staff> output = new List<Staff>();
            foreach (StaffListViewItem item in staffUnregisterList.Items)
            {
                output.Add(item.staff);
            }
            return output;
        }

        public UnregisteredStaffControl()
        {
            InitializeComponent();
        }

        // Get on unregistered staff for selected date using the monthCalendar
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DisplayUnregisterStaff();
        }

        // Check if selected staff (deregistered) is already in the unregister list, for that date.
        private bool unregisterListDoubleStaff(int staffId)
        {
            foreach (StaffListViewItem listItem in staffUnregisterList.Items)
            {
                if (listItem.staff.StaffId == staffId) return true;
            }
            return false;
        }

        // Method removes staff from unregister list
        public void Remove(StaffListViewItem item)
        {
            staffUnregisterList.Items.Remove(item);
        }

        /// <summary>
        /// Method to add selected staff to unregister list && display on GUI.
        /// </summary>
        public void DisplayUnregisterStaff()
        {
            // Get unregistered staff for that date
            List<Staff> unregisteredStaff = DatabaseConnector.Instance.GetUnregisteredStaff(calendarUnregisterd.SelectionRange.Start.ToString("yyyy-MM-dd"));
            staffUnregisterList.Clear();

            if (unregisteredStaff == null) return;

            if (unregisteredStaff.Count > 0)                
            {
                foreach (Staff staff in unregisteredStaff)
                {
                    // Only add to unregisterlist & display, if not already there.
                    if(!unregisterListDoubleStaff(staff.StaffId))
                    {
                        staffUnregisterList.Items.Add(new StaffListViewItem(staff));
                    }                   
                }               
            }
           
        }
    }
}
