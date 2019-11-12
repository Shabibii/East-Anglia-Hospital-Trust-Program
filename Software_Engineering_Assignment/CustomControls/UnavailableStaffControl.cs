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
    public partial class UnavailableStaffControl : UserControl
    {
        List<Staff> unavailableStaff;
        public UnavailableStaffControl()
        {
            InitializeComponent();
            GetUnavailableStaff(unavailableStaff);
        }

        public void GetUnavailableStaff(List<Staff> unavailableStaff)
        {
            this.unavailableStaff = unavailableStaff;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            

        }
    }
}
