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
    public partial class doctorRegistrationFieldControl : UserControl
    {
        public doctorRegistrationFieldControl(Staff staff)
        {
            InitializeComponent();

            doctorName.Text = staff.FirstName;
            staffId.Text = staff.StaffId.ToString();
        }
    }
}
