namespace Software_Engineering_Assignment.Support_Classes
{
    public class Bay
    {
        public int BayNumber;
        
        
        public bool ThrowAlarm()
        {
            if (patient1.TrowAlarm) return true;
            if (patient2.TrowAlarm) return true;
            if (patient3.TrowAlarm) return true;
            if (patient4.TrowAlarm) return true;
            if (patient5.TrowAlarm) return true;
            if (patient6.TrowAlarm) return true;
            if (patient7.TrowAlarm) return true;
            if (patient8.TrowAlarm) return true;

            return false;
        }

        /// <summary>
        /// Structure to hold information on bays including bedsides/patients
        /// </summary>
        /// <param name="bayNumber"></param>
        public Bay(int bayNumber)
        {
            BayNumber = bayNumber;
            patient1 = DatabaseConnector.Instance.GetPatient(bayNumber, 1);
            patient2 = DatabaseConnector.Instance.GetPatient(bayNumber, 2);
            patient3 = DatabaseConnector.Instance.GetPatient(bayNumber, 3);
            patient4 = DatabaseConnector.Instance.GetPatient(bayNumber, 4);
            patient5 = DatabaseConnector.Instance.GetPatient(bayNumber, 5);
            patient6 = DatabaseConnector.Instance.GetPatient(bayNumber, 6);
            patient7 = DatabaseConnector.Instance.GetPatient(bayNumber, 7);
            patient8 = DatabaseConnector.Instance.GetPatient(bayNumber, 8);
        }

        /// <summary>
        /// This method returns a patient based on the bedside number
        /// </summary>
        /// <param name="bedNumber"></param>
        /// <returns></returns>
        public Patient GetPatient(int bedNumber)
        {
            switch (bedNumber)
            {
                case 1: return patient1;
                case 2: return patient2;
                case 3: return patient3;
                case 4: return patient4;
                case 5: return patient5;
                case 6: return patient6;
                case 7: return patient7;
                case 8: return patient8;
                default: return new Patient();
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
