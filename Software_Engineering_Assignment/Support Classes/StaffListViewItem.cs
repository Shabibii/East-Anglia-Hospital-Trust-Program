using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Assignment.Support_Classes
{
    class StaffListViewItem : ListViewItem
    {
        private Staff currentStaff;
        public delegate void registerAction();
        public registerAction registered;
        public registerAction deregistered;

        public StaffListViewItem(Staff staff)
        {
            currentStaff = staff;
            Text = $"{staff.FirstName} {staff.LastName} (Staff ID: {staff.StaffId})";
        }

        //public void Registered()
        //{
            //if(this.)
        //}

    }
}
