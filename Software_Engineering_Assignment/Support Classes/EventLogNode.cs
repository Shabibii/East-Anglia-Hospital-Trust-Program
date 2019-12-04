using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Engineering_Assignment.Support_Classes
{
    class EventLogNode : TreeNode
    {
        public string eventType;

        public EventLogNode(string eventType)
        {
            this.eventType = Text = eventType;
        }

        public EventLogNode(string[] eventLog)
        {
            string staff_id = eventLog[1];
            string description = eventLog[2];
            string patient_id = eventLog[3];
            string bedside_id = eventLog[4];
            string module_id = eventLog[5];
            string timestamp = eventLog[6];

            /*Because of the practice being used on the Log/Activity table,
              no two IDs can exist (no two should exist) in the same log
             */
            string id = "  ";
            if (staff_id != "")
            {
                eventType = "staff";
                id = staff_id;
            }
            else if (patient_id != "")
            {
                eventType = "patient";
                id = patient_id;
            }
            else if (bedside_id != "")
            {
                eventType = "bedside";
                id = bedside_id;
            }
            else if (module_id != "")
            {
                eventType = "module";
                id = module_id;
            }

            Text = $"{timestamp} : ({eventType}-id:{id}) {description}";
        }

    }
}
