using System;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            DebitCard db = new DebitCard();
            CreditCard cc = new CreditCard();
            cc.PrintCardInfo();
            cc.ReOpenCard();
            cc.AddMoneyToAccount(200);

            cc.SetCreditLimit(200);
            cc.MakePayment(300);
            cc.MakePayment(100);
            cc.MakePayment(100);
            cc.PrintCardInfo();

        }
    }
}
