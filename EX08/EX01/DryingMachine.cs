using System;
using System.Collections.Generic;

namespace EX01
{
    public class DryingMachine : IWashingMachine
    {
        protected int _cost;
        protected int _duration;
        protected List<string> _activites = new List<string>();
        protected string _machineType;
        protected double _moneyEntered;


        public DryingMachine()
        {
            _machineType = "Dryer";
            _duration = 30;
            _activites.Add("drying");
            _moneyEntered = 0;
            _cost = 2;
        }

        public void AddCoin(int coinAmount)
        {
            if (coinAmount == 1 || coinAmount ==2)
            {
                _moneyEntered += coinAmount;
                Console.WriteLine($"You have entered {coinAmount} euro");
            } else if(coinAmount == 50)
            {
                _moneyEntered += 0.5;
                Console.WriteLine($"You have entered {coinAmount} euro");
            } else
            {
                Console.WriteLine("Invalid value");
            }
        }

        public virtual void DoLaundry()
        {
            if (CheckMoney())
            {
                DoLaundryActivites();
            } 
        }

        protected bool CheckMoney()
        {
            if (_moneyEntered >= _cost)
            {
                _moneyEntered -= -_cost;
                return true;
            }
            Console.WriteLine($"Not enought money entered. Cost of the program is {_cost}, you have entered {_moneyEntered}");
            Refund();
            return false;
        }

        private void Refund()
        {
            Console.WriteLine($"Refund: {_moneyEntered}");
            _moneyEntered = 0;
        }

        protected void DoLaundryActivites()
        {
            PrintMachineInfo();
            foreach(string activity in _activites)
            {
                Console.WriteLine($"Doing: {activity}");
            }
            Console.WriteLine("Laundry is done!");
            if (_moneyEntered>0)
            {
                Refund();
            }
        }

        protected virtual void PrintMachineInfo()
        {
            Console.WriteLine($"You are using {_machineType} and washing program with duration {_duration}");
        }
    }
}
