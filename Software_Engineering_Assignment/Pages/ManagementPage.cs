using Software_Engineering_Assignment.Support_Classes;
using System;
using System.Data;
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

            rbtAnyDay.Checked = true;
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
            string table = GetTableName();
            string conditions = GetQueryConditions();
            
            dgvManagementInfo.DataSource = DatabaseConnector.Instance.GetMatchingEvents(table, conditions);
            dgvManagementInfo.AutoResizeColumns();
        }

        private string GetTableName()
        {
            string table;


            switch(cbxEventType.SelectedItem)
            {
                case "Alarms":
                    table = "Alarm";
                    break;
                case "ProgramLogs":
                    table = "LogActivity";
                    break;
                default:
                    table = "Alarm";
                    break;
            }
               

            return table;
        }

        private string GetQueryConditions()
        {
            string conditions = " WHERE ";

            if(tbxStaffID.Text != "")
            {
                conditions += "staff_id = '" + tbxStaffID.Text + "' ";
            }

            if(tbxPatientID.Text != "" && tbxStaffID.Text != "")
            {
                conditions += "AND patient_id = '" + tbxPatientID.Text + "' ";
            }
            else if(tbxPatientID.Text != "")
            {
                conditions += "patient_id = '" + tbxPatientID.Text + "' ";
            }
            
            if(rbtSelectDay.Checked == true)
            {
                if(conditions != " WHERE ")
                {
                    conditions += "AND trigger_date_time = '" + dtpManagement.Value + "' ";
                }
                else
                {
                    conditions += " trigger_date_time = " + dtpManagement.Text + " ";
                }


            }

            if(conditions == " WHERE ")
            {
                conditions = "";
            }
            return conditions;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "SELECT * FROM " + GetTableName() + GetQueryConditions();
            label1.Text = dgvManagementInfo.Rows[0].Cells[5].ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtAnyDay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtSelectDay_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtSelectDay.Checked == true)
            {
                dtpManagement.Enabled = true;

            }
            else
            {
                dtpManagement.Enabled = false;
            }
        }

        private string getSelectedDate()
        {
            string selectedDate;
            selectedDate = dtpManagement.Value.Date.ToString().Split(' ')[0];
            return selectedDate;
        }
    }
}
