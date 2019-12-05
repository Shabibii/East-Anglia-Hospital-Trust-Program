using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Software_Engineering_Assignment.Support_Classes
{
   
    public class Patient
    {
        public delegate void PatientEvent(Patient patient, bool on);
        public PatientEvent ThrowPatientAlarm = delegate { };
        // get/set patient details 
        public readonly int patientId;

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
                    else output += Surname[i++];
                }
                return output;
            }
        }

        public bool IsEmpty = false;

        public string FirstName { get; set; } = "Nobody";

        public string Surname { get; set; } = "Nobody";

        public string Gender { get; set; } = "Unknown";

        public string Address { get; set; } = "N/A";

        public string DOB { get; set; } = "00/00/0000";

        public string ContactNumber1 { get; set; } = "07700000000";

        public string ContactNumber2 { get; set; } = "07700000000";

        public string IntakeReason { get; set; } = "Intake Reason";

        public int bedNumber = 0;

        public int bayNumber = 0;

        public bool mute = false;

        public bool ThrowAlarm
        {
            get
            {
                try
                {
                    return Module1.ThrowAlarm || Module2.ThrowAlarm || Module3.ThrowAlarm || Module4.ThrowAlarm;
                }
                catch (Exception)
                {
                    return false;
                }
                
            }
        }

        public Module Module1;

        public Module Module2;

        public Module Module3;

        public Module Module4;

        //Only show first two active modules for space management reasons (to be used on the bay-page)
        public string ModulesActive => $"{Module1},{Module2}...";


        public Patient() => IsEmpty = true;

        public Patient(string[] rawPatientDat)
        {
            patientId = int.Parse(rawPatientDat[0]);
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
        }

        
        public void ConnectToBedside(string[] rawBedsideData)
        {
            if (this == new Patient()) return;

            int[] randomIndexes = new[] { 0, 1, 2, 3, 4, 5 }.OrderBy(x => Constants.Next()).ToArray();

            Module1 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[2]));
            if (Module1 == null)
            {
                Module1 = new Module(randomIndexes[0])
                {
                    moduleID = int.Parse(rawBedsideData[2])
                };
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[2]), Module1);

            }

            Module2 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[3]));
            if (Module2 == null)
            {
                Module2 = new Module(randomIndexes[1])
                {
                    moduleID = int.Parse(rawBedsideData[3])
                };
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[3]), Module2);

            }

            Module3 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[4]));
            if (Module3 == null)
            {
                Module3 = new Module(randomIndexes[2])
                {
                    moduleID = int.Parse(rawBedsideData[4])
                };
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[4]), Module3);

            }

            Module4 = DatabaseConnector.Instance.GetModule(int.Parse(rawBedsideData[5]));
            if (Module4 == null)
            {
                Module4 = new Module(randomIndexes[3])
                {
                    moduleID = int.Parse(rawBedsideData[5])
                };
                DatabaseConnector.Instance.RegisterModule(int.Parse(rawBedsideData[5]), Module4);
            }

            Module1.ValueChanged += ModuleValueChanged;
            Module2.ValueChanged += ModuleValueChanged;
            Module3.ValueChanged += ModuleValueChanged;
            Module4.ValueChanged += ModuleValueChanged;
        }

        public void MuteModule(int moduleNumber, bool doMute = true)
        {
            switch(moduleNumber)
            {
                case 1:
                    Module1.MuteModule(doMute);
                    break;
                case 2:
                    Module2.MuteModule(doMute);
                    break;
                case 3:
                    Module3.MuteModule(doMute);
                    break;
                case 4:
                    Module4.MuteModule(doMute);
                    break;
            }
        }
        

        void ModuleValueChanged(Module module)
        {
            if (module.ThrowAlarm)
            {
                ThrowPatientAlarm(this, true);
                DatabaseConnector.Instance.LogEvent($"Alarm for {module} thrown", "Patient", patientId);
            }
            else
            {
                ThrowPatientAlarm(this, false);
            }
        }
    }
}
