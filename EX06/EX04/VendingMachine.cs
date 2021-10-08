using System;
namespace EX04
{
    public class VendingMachine
    {
        private int _depositedAmount;
        private const int _costOfDrink=75;

        //default constructor, defaults _depositedAmount to 0
        public VendingMachine()
        {
            _depositedAmount = 0;
        }

        //adds value passed in amount to the machines depositedamount field
        public void AddCoin(int amount)
        {
            _depositedAmount += amount;
            Console.WriteLine($"Deposited amount: {_depositedAmount}");
        }

        public void GetDrink()
        {
            if (_depositedAmount >= _costOfDrink)
            {
                Console.WriteLine("Preparing your drink");
                if (_depositedAmount > _costOfDrink)
                {
                    Console.WriteLine($"Your change is {_depositedAmount-_costOfDrink}");
                }
                _depositedAmount = 0;
                
            } else if (_depositedAmount < _costOfDrink)
            {
                Console.WriteLine("Insert more coins");
            }
        }

        public void GetRefund()
        {
            if (_depositedAmount > 0)
            {
                Console.WriteLine($"You were refunded {_depositedAmount}");
            } else
            {
                Console.WriteLine("There is nothing to refund");
            }
            
        }
    }
}
