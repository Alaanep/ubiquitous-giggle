using System;

namespace EX07Loeng
{
    class Program
    {
        static void Main(string[] args)
        {
            CoinMachine ylemiste = new CoinMachine();
            CoinMachine kristiine = new CoinMachine();
            CoinMachine rocca = new CoinMachine();

            ylemiste.EnterMoney(10);
            ylemiste.EnterMoney(16);
            ylemiste.ExchangeMoney();
            kristiine.EnterMoney(15);
            kristiine.ExchangeMoney();
            rocca.EnterMoney(17);
            rocca.ExchangeMoney();

            Dog dog1 = new Dog();
            LoudDog dog2 = new LoudDog();

            dog1.Bark();
            dog1.Eat("Bone");
            dog2.Bark();
            dog2.Eat("Bone");
        }
    }
}
