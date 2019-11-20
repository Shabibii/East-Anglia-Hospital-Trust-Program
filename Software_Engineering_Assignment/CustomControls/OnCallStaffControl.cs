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
        List<Staff> availableStaff;       

        public OnCallStaffControl()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           var onCallStaff = DatabaseConnector.Instance.GetOnCallStaff(monthCalendar1.SelectionRange.Start.ToShortDateString());
            Console.Read();
        }
    }
}
