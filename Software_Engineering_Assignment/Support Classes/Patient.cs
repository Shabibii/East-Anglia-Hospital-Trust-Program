using System.Collections.Generic;

namespace Software_Engineering_Assignment.Support_Classes
{
   
    public class Patient
    {
        // get/set patient details 
        private string patientId;

        public string FullName
        {
            //Return truncated value
            get
            {
                string output = FirstName + " ";
                int displayLimit = 20; //Total number of characters to be returned

                int i = 0;
                while(output.Length < displayLimit && i < Surname.Length)
                {
                    if(output.Length == displayLimit - 3)
                    {
                        output += "...";
                        break;
                    }
                    else
                    {
                        output += Surname[i];
                        i++;
                    }
                }
                return output;
            }
        }

        public string FirstName { get; set; } = "Nobody";
        public string Surname { get; set; } = "Nobody";

        public string Gender { get; set; } = "Unknown";

        public string Address { get; set; } = "Holy Grove";

        public string DOB { get; set; } = "00/00/0000";

        public string ContactNumber1 { get; set; } = "07700000000";

        public string ContactNumber2 { get; set; } = "07700000000";

        public string IntakeReason { get; set; } = "Intake Reason";

        public int bedNumber = 0;

        public int bayNumber = 0;

        // creating module-objects for storing moduledata 
        public Module Module1;
        public Module Module2;
        public Module Module3;
        public Module Module4;

        //Only show first two active modules for space management reasons (to be used on the bay-page)
        public string ModulesActive => $"{Module1},{Module2}...";

        void ConnectToBedside()
        {
            //Connect patient with 4 modules
            Module1 = new Module(bedNumber, bayNumber, 1);
            Module2 = new Module(bedNumber, bayNumber, 2);
            Module3 = new Module(bedNumber, bayNumber, 3);
            Module4 = new Module(bedNumber, bayNumber, 4);
        }

        public Patient()
        {
            
        }

        public Patient(List<string> rawPatientDat)
        {
            patientId = rawPatientDat[0];
            FirstName = rawPatientDat[1];
            Surname = rawPatientDat[2];
            DOB = rawPatientDat[3].Split(' ')[0];
            Gender = rawPatientDat[4];
            IntakeReason = rawPatientDat[5];
            Address = rawPatientDat[6];
            ContactNumber1 = rawPatientDat[7];
            ContactNumber2 = rawPatientDat[8];
            bedNumber = int.Parse(rawPatientDat[9]);
            bayNumber = int.Parse(rawPatientDat[10]);
            ConnectToBedside();
        }
    }
}
