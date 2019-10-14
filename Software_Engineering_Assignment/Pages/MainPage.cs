using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Assignment.Pages
{
    public partial class MainPage : UserControl
    {
        public delegate void PageCall(int bayNumber);
        public PageCall BayPageCall = delegate { };

        public MainPage()
        {
            InitializeComponent();
            InitializeBays();
            timer.Start();
        }

        public void InitializeBays()
        {
            bayControl1.SetBay(new Bay(1));
            bayControl2.SetBay(new Bay(2));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dateTimeLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.Yes)
            {
                //If login button clicked on the login form
            }
        }

        private void BayControl1_Click(object sender, EventArgs e)
        {
            BayPageCall(1);
        }

        private void BayControl2_Click(object sender, EventArgs e)
        {
            BayPageCall(2);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.Yes)
            {
                //If login button clicked on the login form
            }
        }
    }
}
