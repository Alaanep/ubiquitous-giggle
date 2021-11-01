using System;
namespace BettingGame
{
    public class Guys
    {
        private string _name;
        private int _cash;

        public Guys(string name, int cash)
        {
            _name = name;
            _cash = cash;
        }

        public int Cash { get {return _cash; } private set { _cash = value; } }

        public void WriteMyInfo()
        {
            Console.WriteLine($"{_name} has {_cash} bucks in his pocket");
        }

        public int GiveCash(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine($"{ _name} amount {amount} isnt a valid amount");
                return 0;
            }
            else if(_cash < amount)
            {
                Console.WriteLine($"{_name} cant give {amount} bucks from is pocked. Not enough cash in pocket");
                return 0;
            }

            else
            {
                Console.WriteLine($"{_name} gave {amount} bucks from his pocket");
                _cash -= amount;
                return amount;
            }
            
            
        }
        public void  ReceiveCash(int amount) {
            if (amount < 0)
            {
                Console.WriteLine($"{ _name} amount {amount} isnt a valid amount");

            } else
            {
                _cash += amount;
                Console.WriteLine($"{_name} received {amount}. Now he has {_cash} bucks in his pocket");
            }

            
        }
    }
}
