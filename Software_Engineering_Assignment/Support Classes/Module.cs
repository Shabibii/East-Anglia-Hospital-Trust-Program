
using System;

namespace Software_Engineering_Assignment.Support_Classes
{
    public class Module
    {
        public int moduleID;

        public enum ModuleType { TempModule, HeartRateModule, BloodPressureModule, BreathingRate, PulseRate, None };

        // current monitoring function on module
        public ModuleType currentModule = ModuleType.None;

        public string ModuleUnit = "^";

        // get/set values for module readings
        public decimal MinValue { get; set; } = 0;
        public decimal MaxValue { get; set; } = 60;

        public decimal CurrentValue { get; set; } = 0;

        public static string[] ModuleTypes()
        {
            string[] moduleTypes = new string[(int)ModuleType.None + 1];

            for (int i = 0; i <= (int)ModuleType.None; i++)
                moduleTypes[i] = ToString((ModuleType)i);

            return moduleTypes;
        }


        public static ModuleType GetModuleFromString(string moduleTypeStr)
        {
            //Convert string to ModuleType enum
            for (int i = 0; i <= (int)ModuleType.None; i++)
            {
                if(ToString((ModuleType)i) == moduleTypeStr)
                    return (ModuleType)i;
            }
            return ModuleType.None; //Default value
        }

        public Module()
        {
            //Generate random values
            currentModule = (ModuleType)Constants.NextRandomValue(0, (int)ModuleType.None + 1);

            switch(currentModule)
            {
                case ModuleType.PulseRate:
                    ModuleUnit = "mm";
                    MinValue = 70;
                    MaxValue = 100;
                    break;

                case ModuleType.BreathingRate:
                    ModuleUnit = "bpm"; //breaths per minute
                    MinValue = 12;
                    MaxValue = 25;
                    break;

                case ModuleType.BloodPressureModule:
                    ModuleUnit = "mm";
                    MinValue = 70;
                    MaxValue = 100;
                    break;

                case ModuleType.HeartRateModule:
                    ModuleUnit = "bpm"; //beats per minute
                    MinValue = 70;
                    MaxValue = 100;
                    break;

                case ModuleType.TempModule:
                    ModuleUnit = "C";
                    MinValue = 36;
                    MaxValue = 37;
                    break;

                case ModuleType.None:
                    MinValue = 0;
                    MaxValue = 0;
                    return;

                    
            }
            // set current value to be from min - 8 to max + 8
            CurrentValue = Constants.NextRandomValue(Convert.ToInt32(MinValue) - 8, Convert.ToInt32(MaxValue) + 8);
        }

       
        public Module(string[] rawModuleData)
        {
            moduleID = int.Parse(rawModuleData[0]);
            currentModule = GetModuleFromString(rawModuleData[1]);
            ModuleUnit = rawModuleData[2];
            MaxValue = decimal.Parse(rawModuleData[3]);
            MinValue = decimal.Parse(rawModuleData[4]);
            CurrentValue = decimal.Parse(rawModuleData[5]);
        }

        private static string ToString(ModuleType moduleType)
        {
            switch (moduleType)
            {
                case ModuleType.TempModule: return "Temperature";

                case ModuleType.HeartRateModule: return "Heart Rate";

                case ModuleType.BloodPressureModule: return "Blood Pressure";

                case ModuleType.BreathingRate: return "Breathing Rate";

                case ModuleType.PulseRate: return "Pulse Pressure";

                case ModuleType.None: default: return "N\\A";
            }
        }

        public override string ToString()
        {
            //Make module class be able to act like string (for patient class)
            return ToString(currentModule);
        }
    }

}
