using System;
namespace EX03
{
    public class DebitCard: IBankCard
    {

        protected double _accountBalance;
        protected string _cardNumber;
        protected int _cardNrLength;
        protected string _cardType;
        protected bool _isOpen;

        public DebitCard()
        {
            _isOpen = true;
            _cardType = "Debit";
            _cardNrLength = 8;
            _cardNumber = GenerateCardNumber();
        }

        protected string GenerateCardNumber()
        {
            Random random = new Random();
            string cardNr = string.Empty;
            for(int i = 0; i < _cardNrLength; i++)
            {
                cardNr += random.Next(0, 9);
            }
            return cardNr;
        }

        public void AddMoneyToAccount(double amount)
        {
            if (_isOpen)
            {
                _accountBalance += amount;
                Console.WriteLine($"Accountbalance is now {_accountBalance}");
            } else
            {
                Console.WriteLine($"Unable to add money to your account. Card is closed");
            }
            
        }

        public void CloseCard()
        {
            _isOpen = false;
            Console.WriteLine($"{_cardType} is now closed");
        }

        public void GetAccountBalance()
        {
            Console.WriteLine($"Accountbalance is: {_accountBalance}");
        }

        public virtual void MakePayment(double payment)
        {
            if (_isOpen)
            {
                double maxPayment = _accountBalance;
                if (maxPayment > payment)
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

        public virtual void PrintCardInfo()
        {
            string status = string.Empty;
            if (_isOpen)
            {
                status = "(Card is open)";
            } else
            {
                status = "(Card is closed)";
            }
            Console.WriteLine($"Accountbalance: {_accountBalance}, status: {status}, card number: {_cardNumber}");
        }

        public void ReOpenCard()
        {
            _isOpen = true;
            Console.WriteLine($"{_cardType} is now reopen");
        }
    }
}
