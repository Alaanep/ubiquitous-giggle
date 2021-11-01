using System;
namespace EX01
{
    public class HotWaterMachine: ColdWaterMachine
    {
        public HotWaterMachine()
        {
            _machineType = "Hot water machine";
            _cost = 3;
            _temp = 40;
            _duration = 50;
            _activites.Clear();
            _activites.Add("prewash");
            _activites.Add("soaking");
            _activites.Add("stain removing");
            _activites.Add("washing");
            _activites.Add("rinsing");
            _bonusReceiver = 5;
        }

        public override void DoLaundry()
        {
            if (CheckMoney())
            {
                Console.WriteLine("Warning! Warm water can damage clothes");
                _usageCounter++;
                AddBonus();
                DoLaundryActivites();
                _temp = 40;
            }
        }

        protected override void AddBonus()
        {
            if (_usageCounter % _bonusReceiver == 0)
            {
                _temp = 60;
                Console.WriteLine($"You have just received a free temperature boost. Washing temperature is {_temp}");
            }
        }


    }
}
