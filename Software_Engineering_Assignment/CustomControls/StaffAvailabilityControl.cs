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
    public partial class StaffAvailabilityControl : UserControl
    {
        List<Staff> availableStaff;       

        public StaffAvailabilityControl()
        {
            InitializeComponent();
            GetAvailableStaff(availableStaff);
        }

        /// <summary>
        /// Get all available staff and list them below each other.
        /// Present in StaffAvailabilityControl
        /// </summary>
        /// <param name="availableStaff"></param>
        public void GetAvailableStaff(List<Staff> availableStaff)
        {
            this.availableStaff = availableStaff;
        }
    }
}
