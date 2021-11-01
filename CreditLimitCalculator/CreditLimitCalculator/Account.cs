using System;
namespace CreditLimitCalculator
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal StartBalance { get; set; }
        public decimal Charges { get; set; }
        public decimal Credit { get; set; }
        public decimal CreditLimit { get; set; }

        public Account(string accountNumber, decimal startBalance, decimal charges, decimal credit, decimal creditLimit)
        {
            AccountNumber = accountNumber;
            StartBalance = startBalance;
            Charges = charges;
            Credit = credit;
            CreditLimit = creditLimit;
        }

        public decimal CalculateNewBalance()
        {
            return StartBalance + Charges - Credit;
        }


    }
}
