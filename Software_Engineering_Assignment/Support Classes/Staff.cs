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

        public int StaffType { get; set; } = 0;

        public string ContactNo1 { get; set; } = "1234567890";

        public string ContactNo2 { get; set; } = "1234567890";

        public string Email { get; set; } = "null@gmail.com";

        public string Address { get; set; } = "NULL";

        public bool isOnCall { get; set; } = true;

        public Staff()
        {

        }

        public Staff(List<string> rawStaffData)
        {
            StaffId = int.Parse(rawStaffData[0]);
            FirstName = rawStaffData[1];
            LastName = rawStaffData[2];
            StaffType = int.Parse(rawStaffData[3]);
            DOB = rawStaffData[4];
            Gender = rawStaffData[5];
            ContactNo1 = rawStaffData[6];
            ContactNo2 = rawStaffData[7];
            Email = rawStaffData[8];
            Address = rawStaffData[9];
        }
    }

}
