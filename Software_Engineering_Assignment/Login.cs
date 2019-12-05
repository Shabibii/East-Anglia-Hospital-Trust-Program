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
            //can not be used more than once
            get
            {
                //Make null after use
                var staffCopy = staff;
                staff = null;
                return staffCopy;
            }
        }

        internal DatabaseConnector DatabaseConnector
        {
            get => default;
            set
            {
            }
        }

        public Staff Validated_Staff
        {
            get => default;
            set
            {
            }
        }

        public Login() 
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void ValidateLogin()
        {
            //Create a staff if login is valid
            //Dialog Result Yes
            int.TryParse(staffIdTextBox.Text, out int staffId); //Get staff id in form of INT
            string password = passwordTextBox.Text; // get password

            //Check if inputed details matches specific staff login details
            bool succesfulLogin = DatabaseConnector.Instance.VerifyLogin(staffId, password);

            if (succesfulLogin)
            {
                staff = DatabaseConnector.Instance.GetStaff(staffId);
            }
        }

        private void LoginField_MouseDown(object sender, MouseEventArgs e)
        {
            //if empty, leave water mark
            var txtBox = (TextBox)sender;

            if(txtBox.ForeColor == Color.Gray)
            {
                txtBox.ForeColor = Color.Black;
                txtBox.Clear();
            }
        }

        private void LoginField_Leave(object sender, EventArgs e)
        {
            //if empty, leave water mark
            var txtBox = (TextBox)sender;

            if (txtBox.Text.Length == 0)
            {
                txtBox.ForeColor = Color.Gray;
                txtBox.Text = (string)txtBox.Tag;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close(); //close form
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //Show password if checked/hide password if unchecked
            passwordTextBox.PasswordChar = showPassword.Checked ? '\0' : '●';
        }

        private void StaffIdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                LoginField_Leave(staffIdTextBox, null);
                passwordTextBox.Focus(); // go to password field
                LoginField_MouseDown(passwordTextBox, null);
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                LoginField_Leave(passwordTextBox, null);
                staffIdTextBox.Focus(); // go to staff_id field
                LoginField_MouseDown(staffIdTextBox, null);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ValidateLogin(); // Attempt logging in
                DialogResult = DialogResult.Yes;
            }
        }        
    }
}
