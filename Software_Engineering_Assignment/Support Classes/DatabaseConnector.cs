using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Assignment.Support_Classes
{
    class DatabaseConnector
    {
        //This class is to be accessable to all other classes in this project
        private static DatabaseConnector instance;

        public static DatabaseConnector Instance
        {
            get
            {
                if (instance == null)
                {
                    //Initalize DatabaseConnector instance
                    instance = new DatabaseConnector();
                }
                return instance;
            }
        }

        public Bay GetBay(int bayNumber)
        {
            //To be implemented
            return new Bay(bayNumber);
        }

        public Patient GetPatient(int bayNumber, int bedNumber)
        {
            //To be implemented
            return new Patient() { bayNumber = bayNumber, bedNumber = bedNumber};
        }

        public List<Staff> GetAllStaff()
        {
            return null;
        }
    }
}
