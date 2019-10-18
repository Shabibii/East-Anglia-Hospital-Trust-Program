using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Assignment.CustomControls
{
    public partial class BedsideInfoControl : UserControl
    {

        Image WarningImage => Alarm() ? Properties.Resources.ImportantNotification3 : null;

        public BedsideInfoControl()
        {
            InitializeComponent();
            button2.Image = WarningImage;
        }

        bool Alarm()
        {
            return false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
