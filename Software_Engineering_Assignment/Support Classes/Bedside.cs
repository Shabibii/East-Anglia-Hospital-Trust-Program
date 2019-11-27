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

        private Module module1;
        private Module module2;
        private Module module3;
        private Module module4;

        public Module Module1 {get; set;}
        public Module Module2 { get; set; }
        public Module Module3 { get; set; }
        public Module Module4 { get; set; }

        void SetupModules(int bedNumber, int bayNumber)
        {
            module1 = new Module(bayNumber, bedNumber, 1);
            module2 = new Module(bayNumber, bedNumber, 2);
            module3 = new Module(bayNumber, bedNumber, 3);
            module4 = new Module(bayNumber, bedNumber, 4);
        }

        public Bedside(int bedNumber, int bayNumber)
        {
            Bedside bedside = DatabaseConnector.Instance.GetBedside(BedsideNo, BayNo);
            module1 = bedside.Module1;
            module2 = bedside.Module2;
            module3 = bedside.Module3;
            module4 = bedside.Module4;

            SetupModules(bedNumber, bayNumber);
        }

        public Bedside(List<string> rawBedsideData)
        {
            int bedNumber = int.Parse(rawBedsideData[0]);
            int bayNumber = int.Parse(rawBedsideData[0]);

            SetupModules(bedNumber, bayNumber);
        }
    }
}
