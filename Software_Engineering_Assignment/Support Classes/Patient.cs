using System.Collections.Generic;

namespace Software_Engineering_Assignment.Support_Classes
{
   
    public class Patient
    {
        // get/set patient details 
        public string FirstName { get; set; } = "Nobody";
        public string Surname { get; set; } = "Nobody";

        public string Gender { get; set; } = "Unknown";

        public string DOB { get; set; } = "00/00/0000";

        public string IntakeReason { get; set; } = "Well damn";

        public int bedNumber = 0;

        public int bayNumber = 0;

        // creating module-objects for storing moduledata 
        public Module Module1 => new Module();
        public Module Module2 => new Module();
        public Module Module3 => new Module();
        public Module Module4 => new Module();

        //Only show first two active modules for space management reasons (to be used on the bay-page)
        public string ModulesActive => $"{Module1},{Module2}...";

        public Patient()
        {

        }

        public Patient(List<string> rawStaffDat)
        {

        }
    }
}
