using System;
namespace VendingMachine
{
    public class VendingMachine
    {
        private int _depositedAmount;

        public VendingMachine()
        {
            _depositedAmount = 0;
        }

        public void DepositCoin(int coinAmount)
        {
            _depositedAmount += coinAmount;
        }

        public void GetDrink()
        {
            if (_depositedAmount >= 75)
            {
                Console.WriteLine($"Your change is {_depositedAmount - 75} cents");
                _depositedAmount = 0;
            }
            else if(_depositedAmount < 75)
            {
                Console.WriteLine("Insert more coins");
            }
        }

        public void GetRefund()
        {
            Console.WriteLine($"You were refuned {_depositedAmount}");
            _depositedAmount = 0;
        }

    }   
}
