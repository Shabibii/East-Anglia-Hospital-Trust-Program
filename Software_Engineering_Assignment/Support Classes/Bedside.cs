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

        public Bedside(List<string> rawBedsideData)
        {
            BedsideNo = int.Parse(rawBedsideData[1]);
            BayNo = int.Parse(rawBedsideData[2]);

            //module1 = new Module(int.Parse(rawBedsideData[3]));
            //module2 = new Module(int.Parse(rawBedsideData[4]));
            //module3 = new Module(int.Parse(rawBedsideData[5]));
            //module4 = new Module(int.Parse(rawBedsideData[6]));
        }
    }
}
