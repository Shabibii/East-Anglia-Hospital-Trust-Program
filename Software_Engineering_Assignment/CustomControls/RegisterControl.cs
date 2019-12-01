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
        EventLogNode patientNode;
        EventLogNode bedsideNode;
        EventLogNode moduleNode;

        List<EventLogNode> allLogs = new List<EventLogNode>();

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

            if (onCallStaff == null) return;

            if (onCallStaff.Count > 0)
            {
                foreach (Staff staff in onCallStaff)
                {
                    if(!ListContains(staff))
                    {
                        onCallStaffList.Items.Add(new StaffListViewItem(staff));
                    }
                }
            }
        }


        bool LogContains(EventLogNode elog)
        {
            foreach (EventLogNode item in allLogs)
            {
                if(elog.Text == item.Text && elog.eventType == item.eventType)
                {
                    return true;
                }
            }
            return false;
        }
        public void DisplayEventLog()
        {
            var eveLog = DatabaseConnector.Instance.GetEventLog();

            try
            {
                foreach (string[] log in eveLog)
                {
                    EventLogNode eLog = new EventLogNode(log);
                    if (LogContains(eLog)) return;

                    switch (eLog.eventType)
                    {
                        case "patient":
                            allLogs.Add(eLog);
                            patientNode.Nodes.Add(eLog);
                            break;

                        case "bedside":
                            allLogs.Add(eLog);
                            bedsideNode.Nodes.Add(eLog);
                            break;

                        case "module":
                            allLogs.Add(eLog);
                            moduleNode.Nodes.Add(eLog);
                            break;
                    }
                }
            }
            catch (Exception)
            {

            }
           

            

            patientNode.Expand();
            bedsideNode.Expand();
            moduleNode.Expand();
        }

        private void RefreshDisplayData_Tick(object sender, EventArgs e)
        {
            //Display data, check for changes and repeat
            DisplayOnCallStaff();
            DisplayEventLog();
        }

        public void StartRealtimeDataDisplay()
        {
            refreshDisplayData.Start();
        }
    }
}
