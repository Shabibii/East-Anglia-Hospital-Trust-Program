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


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DisplayUnregisterStaff();
        }

        private bool unregisterListDoubleStaff(int staffId)
        {
            foreach (StaffListViewItem listItem in staffUnregisterList.Items)
            {
                if (listItem.staff.StaffId == staffId) return true;
            }

            return false;
        }

        public void Remove(StaffListViewItem item)
        {
            staffUnregisterList.Items.Remove(item);
        }

        public void DisplayUnregisterStaff()
        {
            List<Staff> unregisteredStaff = DatabaseConnector.Instance.GetUnregisteredStaff(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
            staffUnregisterList.Clear();

            if (unregisteredStaff == null) return;

            if (unregisteredStaff.Count > 0)                
            {
                foreach (Staff staff in unregisteredStaff)
                {
                    if(!unregisterListDoubleStaff(staff.StaffId))
                    {
                        staffUnregisterList.Items.Add(new StaffListViewItem(staff));
                    }                   
                }
            }
            Console.Read();
        }



    }
}
