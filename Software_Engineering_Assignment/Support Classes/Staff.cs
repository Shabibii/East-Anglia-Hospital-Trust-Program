using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Assignment.Support_Classes
{
    public class Staff
    {
        // Get all attributes in the Staff class

        public int StaffId { get; set; } = 123456;

        public string FirstName { get; set; } = "NULL";

        public string LastName { get; set; } = "NULL";

        public string Gender { get; set; } = "NULL";

        public string DOB { get; set; } = "00/00/0000";

        public string StaffType { get; set; } = "NULL";

        public int ContactNo1 { get; set; } = 1234567890;

        public int ContactNo2 { get; set; } = 1234567890;

        public string Email { get; set; } = "null@gmail.com";

        public string Address { get; set; } = "NULL";

        public bool isAvailable { get; set; } = true;

        public bool isOnCall { get; set; } = true;
    }

    public class StaffSchedule
    {

    }
}
