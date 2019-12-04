namespace Software_Engineering_Assignment.Support_Classes
{
    public class Bay
    {
        public int BayNumber;

        public bool Throw_Alarm => 
               bedside1.ThrowAlarm || bedside2.ThrowAlarm || bedside3.ThrowAlarm || bedside4.ThrowAlarm
            || bedside5.ThrowAlarm || bedside6.ThrowAlarm || bedside7.ThrowAlarm || bedside8.ThrowAlarm;

        /// <summary>
        /// Structure to hold information on bays including bedsides/patients
        /// </summary>
        /// <param name="bayNumber"></param>
        public Bay(int bayNumber)
        {
            BayNumber = bayNumber;
            bedside1 = DatabaseConnector.Instance.GetBedside(bayNumber, 1);
            bedside2 = DatabaseConnector.Instance.GetBedside(bayNumber, 2);
            bedside3 = DatabaseConnector.Instance.GetBedside(bayNumber, 3);
            bedside4 = DatabaseConnector.Instance.GetBedside(bayNumber, 4);
            bedside5 = DatabaseConnector.Instance.GetBedside(bayNumber, 5);
            bedside6 = DatabaseConnector.Instance.GetBedside(bayNumber, 6);
            bedside7 = DatabaseConnector.Instance.GetBedside(bayNumber, 7);
            bedside8 = DatabaseConnector.Instance.GetBedside(bayNumber, 8);
        }

        public void StartRandomizingValues()
        {
            bedside1.StartGeneratingRandomValues();
            bedside2.StartGeneratingRandomValues();
            bedside3.StartGeneratingRandomValues();
            bedside4.StartGeneratingRandomValues();
            bedside5.StartGeneratingRandomValues();
            bedside6.StartGeneratingRandomValues();
            bedside7.StartGeneratingRandomValues();
            bedside8.StartGeneratingRandomValues();
        }


        /// <summary>
        /// This method returns a patient based on the bedside number
        /// </summary>
        /// <param name="bedNumber"></param>
        /// <returns></returns>
        public Bedside GetBedside(int bedNumber)
        {
            switch (bedNumber)
            {
                case 1: return bedside1;
                case 2: return bedside2;
                case 3: return bedside3;
                case 4: return bedside4;
                case 5: return bedside5;
                case 6: return bedside6;
                case 7: return bedside7;
                case 8: return bedside8;
                default: return null;
            }
        }

        //Patients from bed 1 to 8
        readonly Bedside bedside1;
        readonly Bedside bedside2;
        readonly Bedside bedside3;
        readonly Bedside bedside4;
        readonly Bedside bedside5;
        readonly Bedside bedside6;
        readonly Bedside bedside7;
        readonly Bedside bedside8;
    }
}
