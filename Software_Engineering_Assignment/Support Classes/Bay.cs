 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Assignment
{
    public class Bay
    {
        public int BayNumber;

        public Bay(int bayNumber)
        {
            BayNumber = bayNumber;
            patient1 = DatabaseConnector.GetPatient(bayNumber, 1);
            patient2 = DatabaseConnector.GetPatient(bayNumber, 2);
            patient3 = DatabaseConnector.GetPatient(bayNumber, 3);
            patient4 = DatabaseConnector.GetPatient(bayNumber, 4);
            patient5 = DatabaseConnector.GetPatient(bayNumber, 5);
            patient6 = DatabaseConnector.GetPatient(bayNumber, 6);
            patient7 = DatabaseConnector.GetPatient(bayNumber, 7);
            patient8 = DatabaseConnector.GetPatient(bayNumber, 8);
        }

        public Patient GetPatient(int bedNumber)
        {
            switch(bedNumber)
            {
                case 1: return patient1;
                case 2: return patient2;
                case 3: return patient3;
                case 4: return patient4;
                case 5: return patient5;
                case 6: return patient6;
                case 7: return patient7;
                case 8: return patient8;
                default:  return new Patient();
            }
        }

        //Patients from bed 1 to 8
        readonly Patient patient1;
        readonly Patient patient2;
        readonly Patient patient3;
        readonly Patient patient4;
        readonly Patient patient5;
        readonly Patient patient6;
        readonly Patient patient7;
        readonly Patient patient8;
    }
}
