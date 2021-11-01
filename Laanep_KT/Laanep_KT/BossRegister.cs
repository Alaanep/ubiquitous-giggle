using System;
namespace Laanep_KT
{
    public class BossRegister: ProRegister
    {
        private int _timesCoinEntered;
        public BossRegister()
        {
            _type = "Boss Register";
            _TotalMoneyLimit = 5000;
            _maxNoteValue = 500;
            _timesCoinEntered = 0;
        }

        public override void PrintTotalMoney()
        {
            base.PrintTotalMoney();
            if (_TotalMoneyInCashRegister > 1000)
            {
                Console.WriteLine("There is a lot of money, do not forget to lock register!");
            }
        }

        public void OilMachine()
        {
            Console.WriteLine($"Oiling {_type}");
            _timesCoinEntered = 0;
        }

        protected override void AddCoinToRegister(decimal amount)
        {
            _timesCoinEntered++;
            if (_timesCoinEntered >= 5)
            {
                Console.WriteLine($"{_type} coin department makse Squek-squek");
            }
            base.AddCoinToRegister(amount);
        }
    }
}
