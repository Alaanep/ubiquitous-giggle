using System;
namespace EX01
{
    public class ColdWaterMachine: DryingMachine
    {
        protected int _temp;
        protected int _usageCounter;
        protected int _bonusReceiver;
        public ColdWaterMachine()
        {
            _machineType = "Cold water machine";
            _activites.Clear(); //clear base class values
            _activites.Add("Soaking");
            _activites.Add("Washing");
            _activites.Add("Rinsing");
            _cost = 1;
            _temp = 30;
            _bonusReceiver = 10;
            
        }

        protected virtual void AddBonus()
        {
            if (_usageCounter % _bonusReceiver == 0) { 
                Random random = new Random();
                double discountPercent = random.Next(20, 51);
                double discount = _cost * (discountPercent/100);
                Console.WriteLine($"You have just received a bonus of {discount} EUR");
            }
        }

        public override void DoLaundry()
        {
            if (CheckMoney())
            {
                _usageCounter++;
                AddBonus();
                DoLaundryActivites();
            }
        }

        protected override void PrintMachineInfo()
        {
            base.PrintMachineInfo();
            Console.Write($"and temp is {_temp}.\n");
        }
    }
}
