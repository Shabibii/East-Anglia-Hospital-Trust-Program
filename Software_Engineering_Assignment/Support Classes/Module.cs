
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

        public Module()
        {
            
        }

        public override string ToString()
        {
            //Make module class be able to act like string (for patient class)
            switch (currentModule)
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
    }

}
