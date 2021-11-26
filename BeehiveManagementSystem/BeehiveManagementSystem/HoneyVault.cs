using System;
namespace BeehiveManagementSystem
{
    public static class HoneyVault
    {
        const float NECTAR_CONVERSION_RATIO = .19f;
        const float LOW_LEVEL_WARNING = 10f;

        private static float honey = 25f;
        private static float nectar = 100f;

        public static void ConvertNectarToHoney(float amount)
        {
            if (amount > nectar)
            {
                honey += nectar * NECTAR_CONVERSION_RATIO;
                nectar = 0;

            }
            else
            {
                nectar -= amount;
                honey += amount * NECTAR_CONVERSION_RATIO;
            }
        }

        public static bool ConsumeHoney(float amount)
        {
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CollectNectar(float amount)
        {
            if (amount > 0f)
            {
                nectar += amount;
            }
        }

        public static string StatusReport
        {
            get { 
                string status = $"{honey:0.0} units of honey\n"+
                                $"{nectar:0.0} units if nectar\n";
                string warnings = "";

                if (honey < LOW_LEVEL_WARNING)
                {
                    warnings+= "\nLOW HONEY - ADD A HONEY MANUFACTURER\n";
                }
                
                if (nectar < LOW_LEVEL_WARNING)
                {
                    warnings += "\nLOW NECTAR - ADD A NECTAR MANUFACTURER\n";
                }
                return status + warnings;

            }
        }
    }
}
