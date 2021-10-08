using System;
using System.Linq;

namespace EX02
{
    public class BankCard
    {
        private double _accountBalance;
        private string _cardType;
        private string _cardNumber;

       
        //set cardtype value if Maestro or Visa, else default to empty string
        public string CardType {
            get {return _cardType; }
            set { if (value == "Maestro" || value == "Visa") {
                    _cardType = value;
                } else
                {
                    Console.WriteLine("Card type can be either Maestro or Visa. Defaulted to empty String");
                    _cardType = String.Empty;
                }
            }
        }
        

        //default constructor sets accountbalance to 0 and card type to Visa
        public BankCard()
        {
            _accountBalance = 0;
            CardType = "Visa";
        }

        //Constructor BankCard(int balance, string cardType) which sets the accountBalance and
        //cardType according to constructors parameters
        public BankCard(double balance, string cardType)
        {
            _accountBalance = balance;
            CardType = cardType;
        }
        //Set card number, takes card number as parameter and prints it. If card number length !=8
        //then display invalid value
        public void SetCardNumber(string cardNumber)
        {
            if (cardNumber.Length == 8)
            {
                if (cardNumber.All(char.IsDigit))
                {
                    _cardNumber = cardNumber;
                    Console.WriteLine($"Card number is set to {_cardNumber}");
                }
                else
                {
                    Console.WriteLine($"Invalid value, card number has to be all digits");
                }
                
            } else
            {
                Console.WriteLine($"Invalid value, the length has to be 8 and all digits");
            }
        }
        //print out cardtype
        public void PrintCardType()
        {
            if (CardType!=string.Empty)
            {
                Console.WriteLine($"Card type is {CardType}");
            } else
            {
                Console.WriteLine("Card type has not been set");
            }
        }

        //print out accountbalance
        public void PrintAccountBalance()
        {
            Console.WriteLine(_accountBalance);
        }

        //get account balance
        public double GetAccountBalance()
        {
            return _accountBalance;
        }

        //increase account balance, amount to add is the parameter
        public void IncreaseAccountBalance(double amount)
        {
            _accountBalance += amount;
        }

        //decrease account balance, amount to decrease is the parameter.
        //if balance is smaller than 0, display error and cancel
        public void DecreaseAccountBalance(double amount)
        {
            if (_accountBalance - amount < 0)
            {
                Console.WriteLine("Cannot do this operation, insufficient funds, accountbalance is not changed");
            }else
            {
                _accountBalance -= amount;
            }
        }
    }
}
