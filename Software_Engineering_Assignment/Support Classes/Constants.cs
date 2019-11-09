using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Assignment.Support_Classes
{
    class Constants
    {
        //These are sql queries that will be used regurally
        public static string GetStaff(int id) => $"SELECT * FROM Staff Where staff_id={id};";
        

    }
}
