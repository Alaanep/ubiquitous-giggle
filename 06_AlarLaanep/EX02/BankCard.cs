using System;
using System.Linq;

namespace EX02
{
    public class BankCard
    {
        private double _accountBalance;
        private string _cardType;
        private string _cardNumber;

        public double AccountBalance {
            get {return _accountBalance;}
            set {_accountBalance = value ; }
        }
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
        //set cardnumber value if its length is 8, else default to empty string
        public string CardNumber {
            get {return _cardNumber; }
            set { if (value.Length == 8) {
                    if (value.All(Char.IsDigit))
                    {
                        _cardNumber = value;
                    }
                    else
                    {
                        Console.WriteLine($"From c: Invalid value, card number has to be all digits");
                        _cardNumber = string.Empty; ;
                    }
                } else
                {
                    Console.WriteLine("Card number length must be 8 and all digits. Defaulted to empty string");
                    _cardNumber = string.Empty;
                }
            }
        }

        //default constructor sets accountbalance to 0 and card type to Visa
        public BankCard()
        {
            AccountBalance = 0;
            CardType = "Visa";
        }

        //Constructor BankCard(int balance, string cardType) which sets the accountBalance and
        //cardType according to constructors parameters
        public BankCard(double balance, string cardType)
        {
            AccountBalance = balance;
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
                    CardNumber = cardNumber;
                    Console.WriteLine($"Card number is set to {CardNumber}");
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
            Console.WriteLine(AccountBalance);
        }

        //get account balance
        public double GetAccountBalance()
        {
            return AccountBalance;
        }

        //increase account balance, amount to add is the parameter
        public void IncreaseAccountBalance(double amount)
        {
            AccountBalance += amount;
        }

        //decrease account balance, amount to decrease is the parameter.
        //if balance is smaller than 0, display error and cancel
        public void DecreaseAccountBalance(double amount)
        {
            if (AccountBalance - amount < 0)
            {
                Console.WriteLine("Cannot do this operation, insufficient funds, accountbalance is not changed");
            }else
            {
                AccountBalance -= amount;
            }
        }
    }
}
