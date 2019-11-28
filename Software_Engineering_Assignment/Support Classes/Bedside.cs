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

        public Module Module1
        {
            get
            {
                return module1;
            }
            set
            {
                module1 = value;
            }
        }
        public Module Module2
        {
            get
            {
                return module2;
            }
            set
            {
                module2 = value;
            }
        }

        public Module Module3
        {
            get
            {
                return module3;
            }
            set
            {
                module3 = value;
            }
        }

        public Module Module4
        {
            get
            {
                return module4;
            }
            set
            {
                module4 = value;
            }
        }

        public Bedside(List<string> rawBedsideData)
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

            module2 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[3]));
            if (module2 == null)
            {
                module2 = new Module();
                module2.moduleID = int.Parse(rawBedsideData[3]);
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[3]), module2);

            }

            module3 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[4]));
            if (module3 == null)
            {
                module3 = new Module();
                module3.moduleID = int.Parse(rawBedsideData[4]);
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[4]), module3);

            }

            module4 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[5]));
            if (module4 == null)
            {
                module4 = new Module();
                module4.moduleID = int.Parse(rawBedsideData[5]);
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[5]), module4);
            }
        }
    }
}
