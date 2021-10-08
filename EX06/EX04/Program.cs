using System;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.AddCoin(74);
            vendingMachine.GetDrink();
            vendingMachine.AddCoin(1);
            vendingMachine.AddCoin(1);
            vendingMachine.GetDrink();
            vendingMachine.GetRefund();

        }
    }
}
