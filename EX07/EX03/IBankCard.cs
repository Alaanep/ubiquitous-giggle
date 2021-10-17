using System;
namespace EX03
{
    public interface IBankCard
    {
        public void GetAccountBalance();
        public void AddMoneyToAccount(double amount);
        public void MakePayment(double payment);
        public void PrintCardInfo();
        public void CloseCard();
        public void ReOpenCard();
    }
}
