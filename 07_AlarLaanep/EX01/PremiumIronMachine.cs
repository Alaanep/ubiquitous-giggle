using System;
namespace EX01
{
    public class PremiumIronMachine: RegularIronMachine
    {

        private bool _indicatorLight;
        private int _steamUsage;

        public bool IndicatorLight
        {
            get { return _indicatorLight; }
            set { _indicatorLight = value; }
        }
        public PremiumIronMachine()
        {
            _type = "Premium Iron Machine";
            _indicatorLight = false;
        }

        public override void DoIroning(int temperature)
        {
            CheckUsage();
            base.DoIroning(temperature);
            CheckSteamUsage();
        }

        public override void DoIroning(string program)
        {
            CheckUsage();
            base.DoIroning(program);
            CheckSteamUsage();
        }

        private void CheckUsage()
        {
            if (_usageCounter == 3)
            {
                DeScale();
            }
        }

        private void CheckSteamUsage()
        {
            if (_steamUsage == 2)
            {
                IndicatorLight = true;
                Console.WriteLine("Steam indicator light on. Please add water");
            }
        }

        public override void UseSteam()
        {
            if (!_useSteam && _temperature>=120)
            {
                _steamUsage++;
            }
            base.UseSteam();

        }
    }
}
