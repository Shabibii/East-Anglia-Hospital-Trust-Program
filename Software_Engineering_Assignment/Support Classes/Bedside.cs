using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineering_Assignment.Support_Classes
{
    public class Bedside
    {
        public int BedsideNo { get; set; } = 0;
        public int BayNo { get; set; } = 0;

        public Patient patient;

        public bool ThrowAlarm
        {
            get
            {
                try
                {
                    return patient.Module1.ThrowAlarm || patient.Module2.ThrowAlarm || patient.Module3.ThrowAlarm || patient.Module4.ThrowAlarm;
                }
                catch (Exception)
                {
                    return false;
                }
                
            }
        }

        public delegate void BedsideEvent(ref Patient patient, bool on);
        public BedsideEvent AlarmThrown = delegate { };

        public Bedside(string[] rawBedsideData)
        {
            BedsideNo = int.Parse(rawBedsideData[0]);
            BayNo = int.Parse(rawBedsideData[1]);
        }

        public void StartGeneratingRandomValues()
        {
            if (patient.FullName == "Empty Record") return;

            patient.Module1.ValueChanged += ModuleChanged;
            patient.Module2.ValueChanged += ModuleChanged;
            patient.Module3.ValueChanged += ModuleChanged;
            patient.Module4.ValueChanged += ModuleChanged;

            patient.Module1.StartGeneratingValues();
            patient.Module2.StartGeneratingValues();
            patient.Module3.StartGeneratingValues();
            patient.Module4.StartGeneratingValues();

            ModuleChanged(patient.Module1);
            ModuleChanged(patient.Module2);
            ModuleChanged(patient.Module3);
            ModuleChanged(patient.Module4);
        }

        private void ModuleChanged(Module module)
        {
            if(module.ThrowAlarm)
            {
                AlarmThrown(ref patient, true);
            }
            else
            {
                AlarmThrown(ref patient, false);
            }
        }

    }
}
