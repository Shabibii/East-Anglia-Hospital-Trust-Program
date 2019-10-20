using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Assignment
{
    class DatabaseConnector
    {
        //This class is to be accessable to all other classes in this project

        public static Bay GetBay(int bayNumber)
        {
            //To be implemented
            return new Bay(bayNumber);
        }

        public static Patient GetPatient(int bayNumber, int bedNumber)
        {
            //To be implemented
            return new Patient() { bayNumber = bayNumber, bedNumber = bedNumber};
        }
    }
}
