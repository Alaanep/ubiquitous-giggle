using System;
namespace EX03
{
    public class CreditCard: DebitCard
    {
        private double _creditLimit;
        private  double _maxCreditLimit;
        public CreditCard()
        {
            _cardType = "Credit";
            _cardNrLength = 6;
            _cardNumber = GenerateCardNumber();
            _isOpen = false;
            _maxCreditLimit = 10000;
        }

        /// <summary>
        /// method for setting creditlimit
        /// </summary>
        /// <param name="amount"></param>
        public void SetCreditLimit(double amount)
        {
            if (_isOpen) { 
                if(amount <0)
                {
                    Console.WriteLine("Invalid creditlimit. Creditlimit cant be negative");
                }
                else if(amount < _maxCreditLimit)
                {
                    _creditLimit = amount;
                    Console.WriteLine($"Creditlimit is set to {_creditLimit}");
                } else
                {
                    Console.WriteLine($"Maximum credit limit exceeded. Maximum creditlimit is {_maxCreditLimit}");
                }
            } else
            {
                Console.WriteLine("Cant change creditlimit. Card is closed");
            }
        }

        public override void PrintCardInfo()
        {
            Console.Write($"Creditlimit: {_creditLimit} ");
            base.PrintCardInfo();
            
        }

        public override void MakePayment(double payment)
        {
            if (_isOpen)
            {
                double maxPayment = _creditLimit+ _accountBalance;

                if (maxPayment > (_creditLimit + _accountBalance)*-1)
                {
                    _accountBalance -= payment;
                    Console.WriteLine($"Payment {payment} done");
                    GetAccountBalance();
                }
                else
                {
                    Console.WriteLine($"Insufficient funds to make payment {payment}.");
                    GetAccountBalance();
                }
            }
            else
            {
                Console.WriteLine("Card is closed. Unable to make payment");
            }
        }



    }
}
