using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Dialog Result Yes
        }

        private void LoginField_MouseDown(object sender, MouseEventArgs e)
        {
            var txtBox = (TextBox)sender;

            if(txtBox.ForeColor == Color.Gray)
            {
                txtBox.ForeColor = Color.Black;
                txtBox.Clear();
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            var txtBox = (TextBox)sender;

            if (txtBox.Text.Length == 0)
            {
                txtBox.ForeColor = Color.Gray;
                txtBox.Text = (string)txtBox.Tag;
            }
        }

    }
}
