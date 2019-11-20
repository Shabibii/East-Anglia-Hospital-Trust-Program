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
       
        public UnregisteredStaffControl()
        {
            InitializeComponent();
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DisplayUnregisterStaff();
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
                    staffUnregisterList.Items.Add(new StaffListViewItem(staff));
                }
            }
            Console.Read();
        }



    }
}
