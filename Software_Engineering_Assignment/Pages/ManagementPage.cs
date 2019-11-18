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

namespace Software_Engineering_Assignment.Pages
{
    public partial class ManagementPage : UserControl
    {

        public Main.PageCall0 pageCall0;

        public ManagementPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        //On load of the program fill the management page dataGridView with all alarms
        private void ManagementPage_Load(object sender, EventArgs e)
        {
            //Assign dataGridView data source to alarms dataset
            dgvManagementInfo.DataSource = DatabaseConnector.Instance.GetAlarms();
        }

        private void btnManagementBack_Click(object sender, EventArgs e)
        {
            pageCall0();
        }
    }
}
