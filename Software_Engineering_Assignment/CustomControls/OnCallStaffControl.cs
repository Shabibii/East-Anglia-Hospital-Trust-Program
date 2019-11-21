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

        public void DisplayOnCallStaff()
        {
            List<Staff> onCallStaff = DatabaseConnector.Instance.GetOnCallStaff(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
            StaffOncallList.Clear();

            if (onCallStaff == null) return;

            if(onCallStaff.Count > 0)
            {
                foreach (Staff staff in onCallStaff)
                {
                    StaffOncallList.Items.Add(new StaffListViewItem(staff));
                }
            }
            Console.Read();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
