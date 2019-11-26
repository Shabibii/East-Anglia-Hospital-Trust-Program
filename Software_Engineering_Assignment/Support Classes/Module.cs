
using System.Collections.Generic;

namespace Software_Engineering_Assignment.Support_Classes
{
    public class Module
    {
        public enum ModuleType { TempModule, HeartRateModule, BloodPressureModule, None };

        // current monitoring function on module
        public ModuleType currentModule = ModuleType.None;

        // get/set values for module readings
        public double MinValue { get; set; } = 0;
        public double MaxValue { get; set; } = 0;

        public double CurrentValue { get; set; } = 0;

        public static List<string> ModuleTypes()
        {
            List<string> output = new List<string>();
            for (int i = 0; i <= (int)ModuleType.None; i++)
                output.Add(ToString((ModuleType)i));

            return output;
        }

        public Module()
        {
            
        }

        private static string ToString(ModuleType moduleType)
        {
            switch (moduleType)
            {
                case ModuleType.TempModule:
                    return "Temperature";

                case ModuleType.HeartRateModule:
                    return "Heart Rate";

                case ModuleType.BloodPressureModule:
                    return "Blood Pressure";

                case ModuleType.None:
                default:
                    return "N\\A";
            }
        }

        public override string ToString()
        {
            //Make module class be able to act like string (for patient class)
            return ToString(currentModule);
        }
    }

}
