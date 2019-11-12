using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_Engineering_Assignment.Support_Classes;

namespace Software_Engineering_Assignment
{
    public partial class Login : Form
    {
        private Staff staff; //Staff created by authentication

        public Staff Staff
        {
            get
            {
                //Make null after use
                var staffCopy = staff;
                staff = null;
                return staffCopy;
            }
        }

        public Login() 
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Dialog Result Yes
            int.TryParse(staffIdTextBox.Text, out int staffId); //Get staff id in form of INT
            string password = passwordTextBox.Text; // get password

            //Check if inputed details matches specific staff login details
            bool succesfulLogin = DatabaseConnector.Instance.VerifyLogin(staffId, password);

            if(succesfulLogin)
            {
                staff = DatabaseConnector.Instance.GetStaff(staffId);
            }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPassword.Checked ? '\0' : '●';
        }
    }
}
