using System;
namespace EX01
{
    public class PremiumIronMachine: RegularIronMachine
    {

        private bool _indicatorLight;
        

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
            if(_usageCounter == 3)
            {
                DeScale();
            }
            base.DoIroning(temperature);   
        }

        public override void DoIroning(string program)
        {
            if (_usageCounter == 3)
            {
                DeScale();
            }
            base.DoIroning(program);
        }

        public override void UseSteam()
        {
            base.UseSteam();
            if (_steamUsage == 2)
            {
                IndicatorLight = true;
                Console.WriteLine("Steam has been used 2 times. Please add water");
            }
        }
    }
}
