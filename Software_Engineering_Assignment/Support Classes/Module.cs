
using System;
using System.Collections.Generic;

namespace Software_Engineering_Assignment.Support_Classes
{
    public class Module
    {
        public int moduleID;

        public enum ModuleType { TempModule, HeartRateModule, BloodPressureModule, None };

        // current monitoring function on module
        public ModuleType currentModule = ModuleType.None;

        public string ModuleUnit = "^";

        // get/set values for module readings
        public float MinValue { get; set; } = 0;
        public float MaxValue { get; set; } = 60;

        public float CurrentValue { get; set; } = 0;

        public static List<string> ModuleTypes()
        {
            List<string> output = new List<string>();
            for (int i = 0; i <= (int)ModuleType.None; i++)
                output.Add(ToString((ModuleType)i));

            return output;
        }

        public Module() { }

        public Module(int moduleID)
        {
            Module module = DatabaseConnector.Instance.GetModule(moduleID);
            if (module == null)
            {
                //Store module data
                //Create random module values
                //CurrentValue = Constants.NextRandomValue;
                CurrentValue = 45;
                DatabaseConnector.Instance.RegisterModule(moduleID, this);
            }
            else
            {
                moduleID = module.moduleID;
                currentModule = module.currentModule;
                CurrentValue = module.CurrentValue;
                MaxValue = module.MaxValue;
                MinValue = module.MinValue;
                ModuleUnit = module.ModuleUnit;
            }
    
        }

        public Module(List<string> rawModuleData)
        {
            moduleID = int.Parse(rawModuleData[0]);
            currentModule = (ModuleType)int.Parse(rawModuleData[1]);
            ModuleUnit = rawModuleData[2];
            MaxValue = float.Parse(rawModuleData[3]);
            MinValue = float.Parse(rawModuleData[4]);
            CurrentValue = float.Parse(rawModuleData[5]);
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
