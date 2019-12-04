namespace Software_Engineering_Assignment.Support_Classes
{
    public class Bay
    {
        public int BayNumber;

        public delegate void BayEvent(ref Patient patient, bool on);
        public BayEvent ThrowAlarm = delegate { };

        /// <summary>
        /// Structure to hold information on bays including bedsides/patients
        /// </summary>
        /// <param name="bayNumber"></param>
        public Bay(int bayNumber)
        {
            BayNumber = bayNumber;
            patient1 = DatabaseConnector.Instance.GetBedside(bayNumber, 1);
            patient2 = DatabaseConnector.Instance.GetBedside(bayNumber, 2);
            patient3 = DatabaseConnector.Instance.GetBedside(bayNumber, 3);
            patient4 = DatabaseConnector.Instance.GetBedside(bayNumber, 4);
            patient5 = DatabaseConnector.Instance.GetBedside(bayNumber, 5);
            patient6 = DatabaseConnector.Instance.GetBedside(bayNumber, 6);
            patient7 = DatabaseConnector.Instance.GetBedside(bayNumber, 7);
            patient8 = DatabaseConnector.Instance.GetBedside(bayNumber, 8);


            patient1.AlarmThrown = PatientValueChanged;
            patient2.AlarmThrown = PatientValueChanged;
            patient3.AlarmThrown = PatientValueChanged;
            patient4.AlarmThrown = PatientValueChanged;
            patient5.AlarmThrown = PatientValueChanged;
            patient6.AlarmThrown = PatientValueChanged;
            patient7.AlarmThrown = PatientValueChanged;
            patient8.AlarmThrown = PatientValueChanged;

            //StartRandomizingValues();
        }

        public void PatientValueChanged(ref Patient patient, bool throwAlarm)
        {
            // AlarmThrown(patient,on);
            ThrowAlarm(ref patient, throwAlarm);
        }

        private void StartRandomizingValues()
        {
            patient1.StartGeneratingRandomValues();
            patient2.StartGeneratingRandomValues();
            patient3.StartGeneratingRandomValues();
            patient4.StartGeneratingRandomValues();
            patient5.StartGeneratingRandomValues();
            patient6.StartGeneratingRandomValues();
            patient7.StartGeneratingRandomValues();
            patient8.StartGeneratingRandomValues();
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
                case 1: return patient1.patient;
                case 2: return patient2.patient;
                case 3: return patient3.patient;
                case 4: return patient4.patient;
                case 5: return patient5.patient;
                case 6: return patient6.patient;
                case 7: return patient7.patient;
                case 8: return patient8.patient;
                default: return new Patient();
            }
        }

        //Patients from bed 1 to 8
        readonly Bedside patient1;
        readonly Bedside patient2;
        readonly Bedside patient3;
        readonly Bedside patient4;
        readonly Bedside patient5;
        readonly Bedside patient6;
        readonly Bedside patient7;
        readonly Bedside patient8;
    }
}
