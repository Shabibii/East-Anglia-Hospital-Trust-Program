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
            //DisplayOnCallStaff();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DisplayOnCallStaff();
        }

        private bool registerListDoubleStaff(int staffId)
        {
            foreach (StaffListViewItem listItem in StaffOncallList.Items)
            {
                if (listItem.staff.StaffId == staffId) return true;
            }

            return false;
        }

        public void Remove(StaffListViewItem item)
        {
            StaffOncallList.Items.Remove(item);
        }

        public List<Staff> DisplayedStaff()
        {
            List<Staff> output = new List<Staff>();
            foreach (StaffListViewItem item in StaffOncallList.Items)
            {
                output.Add(item.staff);
            }

            return output;
        }

        public void DisplayOnCallStaff()
        {
            List<Staff> onCallStaff = DatabaseConnector.Instance.GetOnCallStaff(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
            StaffOncallList.Clear();

            if (onCallStaff == null) return;

            if(onCallStaff.Count > 0)
            {
                foreach (Staff staff in onCallStaff)
                {
                    if (!registerListDoubleStaff(staff.StaffId))
                    {
                        StaffOncallList.Items.Add(new StaffListViewItem(staff));
                    }                    
                }
            }
            Console.Read();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
