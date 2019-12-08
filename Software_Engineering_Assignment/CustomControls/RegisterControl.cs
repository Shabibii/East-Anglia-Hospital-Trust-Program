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

namespace Software_Engineering_Assignment
{
    public partial class RegisterControl : UserControl
    {
        readonly EventLogNode patientNode;
        readonly EventLogNode bedsideNode;
        readonly EventLogNode moduleNode;

        public RegisterControl()
        {
            InitializeComponent();

            patientNode = new EventLogNode("patient");
            bedsideNode = new EventLogNode("bedside");
            moduleNode = new EventLogNode("module");
            eventLog.Nodes.AddRange(new[] { patientNode, bedsideNode, moduleNode });
        }

        private bool ListContains(Staff staff)
        {
            foreach (ListViewItem item in onCallStaffList.Items)
            {
                if (((StaffListViewItem)item).staff == staff) return true;
            }

            return false;
        }

        private void DisplayOnCallStaff()
        {
            List<Staff> onCallStaff = DatabaseConnector.Instance.GetOnCallStaff(DateTime.Now.ToString("yyyy-MM-dd"));
            //onCallStaffList.Clear();

            foreach (StaffListViewItem item in onCallStaffList.Items)
            {
                if(!onCallStaff.Contains(item.staff))
                {
                    //if staff is no longer on call
                    onCallStaffList.Items.Remove(item);
                }
            }

            if (onCallStaff == null || onCallStaff.Count < 1) return;

            for (int i = 0; i < onCallStaff.Count; i++)
            {
                Staff staff = onCallStaff[i];
                if (!ListContains(staff))
                    onCallStaffList.Items.Add(new StaffListViewItem(staff));
            }
        }


        public void DisplayEventLog()
        {
            var eveLog = DatabaseConnector.Instance.GetEventLog();

            patientNode.Nodes.Clear();
            bedsideNode.Nodes.Clear();
            moduleNode.Nodes.Clear();

            foreach (string[] log in eveLog)
            {
                EventLogNode eLog = new EventLogNode(log); //Custom tree node object that holds event log

                if(eLog.eventType == "patient") patientNode.Nodes.Add(eLog);
                else if (eLog.eventType == "bedside") bedsideNode.Nodes.Add(eLog);
                else if (eLog.eventType == "module") moduleNode.Nodes.Add(eLog);
            }

            //Expand all three parent nodes
            patientNode.Expand();
            bedsideNode.Expand();
            moduleNode.Expand();
        }

        private void RefreshDisplayData_Tick(object sender, EventArgs e)
        {
            DisplayOnCallStaff(); //Display on call staff
            DisplayEventLog(); //Display event log
        }

        public void StartRealtimeDataDisplay()
        {
            refreshDisplayData.Start(); // Start refreshing data being displayed on the form
        }
    }
}
