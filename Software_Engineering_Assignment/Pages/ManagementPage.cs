using Software_Engineering_Assignment.Support_Classes;
using System;
using System.Windows.Forms;

namespace Software_Engineering_Assignment.Pages
{
    public partial class ManagementPage : UserControl
    {

        public Main.PageCall0 pageCall0;

        public ManagementPage()
        {
            InitializeComponent();
            Text = "Management";
        }

        private void lblStaffID_Click(object sender, EventArgs e)
        {

        }

        //On load of the program fill the management page dataGridView with all alarms
        private void ManagementPage_Load(object sender, EventArgs e)
        {
            //Assign dataGridView data source to alarms dataset
            dgvManagementInfo.DataSource = DatabaseConnector.Instance.GetAlarms();
            dgvManagementInfo.Refresh();
        }

        private void btnManagementBack_Click(object sender, EventArgs e)
        {
            pageCall0();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string table = "Alarm";
            string conditions = "WHERE ";
            
            if(lbxEventType.SelectedItem == "Alarms")
            {
                table = "Alarm";
            }
            else
            {
                table = "Log/Activity";
            }

            if(tbxPatientID.Text != "")
            {
                conditions += "PatientID = " + tbxPatientID;
            }
            else
            {
                conditions += "PatientID = " + "%";
            }


            dgvManagementInfo.DataSource = DatabaseConnector.Instance.GetMatchingEvents(table, conditions);
        }
    }
}
