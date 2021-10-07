using System;

namespace EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            BankCard mycard = new BankCard(100, "Maestro");
            mycard.SetCardNumber("21231234");
            mycard.PrintCardType();
            mycard.PrintAccountBalance();
            mycard.IncreaseAccountBalance(200);
            mycard.PrintAccountBalance();
            mycard.DecreaseAccountBalance(301);
            mycard.PrintAccountBalance();
            mycard.DecreaseAccountBalance(300);
            mycard.PrintAccountBalance();
            BankCard mycard2 = new BankCard();
            mycard2.SetCardNumber("21231266");
            mycard2.PrintCardType();
            mycard2.IncreaseAccountBalance(200);
            mycard2.PrintAccountBalance();
            mycard2.DecreaseAccountBalance(301);
            mycard2.PrintAccountBalance();
            mycard2.DecreaseAccountBalance(200);
            mycard2.PrintAccountBalance();
        }
    }
}
