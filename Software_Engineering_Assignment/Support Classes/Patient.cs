namespace Software_Engineering_Assignment
{
    public class Module
    {
        public enum ModuleType { TempModule, HeartRateModule, BloodPressureModule, None };

        public ModuleType currentModule;

        public double MinValue { get; set; } = 0;
        public double MaxValue { get; set; } = 0;

        public double CurrentValue { get; set; } = 0;

        public Module()
        {
            currentModule = ModuleType.None;
        }

        public Module(ModuleType type)
        {
            currentModule = type;
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

    public class Patient
    {
        public string FirstName { get; set; } = "Nobody";
        public string Surname { get; set; } = "Nobody";

        public string Gender { get; set; } = "Unknown";

        public string DOB { get; set; } = "00/00/0000";

        public string IntakeReason { get; set; } = "Well damn";

        public int bedNumber { get; set; }

        public int bayNumber { get; set; }

        public Module Module1 => new Module();
        public Module Module2 => new Module();
        public Module Module3 => new Module();
        public Module Module4 => new Module();

        //Only show first two active modules for space management reasons
        public string ModulesActive => $"{Module1},{Module2}...";

        public Patient()
        {

        }
    }
}
