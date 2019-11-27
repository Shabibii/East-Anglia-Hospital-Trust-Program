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

        public Module Module1 => module1;
        public Module Module2 => module2;
        public Module Module3 => module3;
        public Module Module4 => module4;

        public Bedside(List<string> rawBedsideData)
        {
            BedsideNo = int.Parse(rawBedsideData[1]);
            BayNo = int.Parse(rawBedsideData[2]);
           
            module1 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[2]));
            if (module1 == null)
            {
                module1 = new Module();
                module1.CurrentValue = Constants.NextRandomValue;
                module1.moduleID = int.Parse(rawBedsideData[2]);
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[2]), module1);

            }

            module2 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[3]));
            if (module2 == null)
            {
                module2 = new Module();
                module2.CurrentValue = Constants.NextRandomValue;
                module2.moduleID = int.Parse(rawBedsideData[3]);
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[3]), module2);

            }

            module3 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[4]));
            if (module3 == null)
            {
                module3 = new Module();
                module3.CurrentValue = Constants.NextRandomValue;
                module3.moduleID = int.Parse(rawBedsideData[4]);
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[4]), module3);

            }

            module4 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[5]));
            if (module4 == null)
            {
                module4 = new Module();
                module4.CurrentValue = Constants.NextRandomValue;
                module4.moduleID = int.Parse(rawBedsideData[5]);
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[5]), module4);
            }
        }
    }
}
