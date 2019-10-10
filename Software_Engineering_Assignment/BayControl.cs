using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Assignment
{
    public partial class BayControl : UserControl
    {
        Bay bay;

        public BayControl()
        {
            InitializeComponent();
            pictureBox1.Hide();
        }

        public void SetBay(Bay bay)
        {
            this.bay = bay;
            SetProperties();

        }

        private void SetProperties()
        {
            title.Text = $"Bay {bay.BayNumber}";
            linkLabel1.Text = $"(1) All Hail Sam";
            linkLabel2.Text = $"(2) Patient Name";
            linkLabel3.Text = $"(3) Patient Name";
            linkLabel4.Text = $"(4) Patient Name";
            linkLabel5.Text = $"(5) Patient Name";
            linkLabel6.Text = $"(6) Patient Name";
            linkLabel7.Text = $"(7) Patient Name";
            linkLabel8.Text = $"(8) Patient Name";

            this.DoubleBuffered = true;
        }

        public void DisplayWarningSign()
        {
            pictureBox1.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Bay_MouseHover(object sender, EventArgs e)
        {
            
            BackColor = Color.DarkGray;
        }

        private void Bay_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Color.Gray;
        }

        private void Bay_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = Color.White;
        }

        private void BayControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
    }
}
