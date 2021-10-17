using System;
namespace EX07Loeng
{
    public class CoinMachine
    {

        private int _moneyEntered;

        public CoinMachine()
        {
        }

        public void EnterMoney(int amount)
        {
            _moneyEntered += amount;
        }

        public void ExchangeMoney()
        {
            Console.WriteLine($"{_moneyEntered} give you {_moneyEntered / 2} coins");
            _moneyEntered = 0;
        }


    }
}
