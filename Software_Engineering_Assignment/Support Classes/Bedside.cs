using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Assignment.Support_Classes
{
    class Bedside
    {
        public int BedsideNo { get; set; } = 0;
        public int BayNo { get; set; } = 0;

        public Module Module1 { get; set; }
        public Module Module2 { get; set; }

        public Module Module3 { get; set; }

        public Module Module4 { get; set; }

        public Bedside(string[] rawBedsideData)
        {
            BedsideNo = int.Parse(rawBedsideData[1]);
            BayNo = int.Parse(rawBedsideData[2]);
           
            Module1 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[2]));
            if (Module1 == null)
            {
                Module1 = new Module();
                Module1.moduleID = int.Parse(rawBedsideData[2]);
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[2]), Module1);

            }

            Module2 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[3]));
            if (Module2 == null)
            {
                Module2 = new Module();
                Module2.moduleID = int.Parse(rawBedsideData[3]);
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[3]), Module2);

            }

            Module3 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[4]));
            if (Module3 == null)
            {
                Module3 = new Module();
                Module3.moduleID = int.Parse(rawBedsideData[4]);
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[4]), Module3);

            }

            Module4 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[5]));
            if (Module4 == null)
            {
                Module4 = new Module();
                Module4.moduleID = int.Parse(rawBedsideData[5]);
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[5]), Module4);
            }
        }
    }
}
