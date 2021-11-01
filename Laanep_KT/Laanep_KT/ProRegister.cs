using System;
using System.Collections.Generic;

namespace Laanep_KT
{
    public class ProRegister: IRegister
    {
        protected decimal _coinAmount;
        protected decimal _eurAmount;
        protected string _type;
        protected List<decimal> _notes;

        protected decimal _lastEnteredAmount;
        protected decimal _TotalMoneyLimit;
        protected decimal _TotalMoneyInCashRegister;
        protected decimal _maxNoteValue;
        protected int _oneHundredNotesCount;

        public ProRegister()
        {
            _type = "Pro Register";
            _TotalMoneyLimit = 1000;
            _maxNoteValue = 100;
            _notes = new List<decimal>();
        }

        public void AddCash(decimal amount)
        {
            if (CheckEnteredAmount(amount))
            {
                if (CheckMoneyLimit(amount))
                {
                    if (CheckMaximumNoteValue(amount))
                    {
                        if (CheckOneHundredNoteCount(amount))
                        {
                            if(amount == 100)
                            {
                                _oneHundredNotesCount++;
                            }
                            _eurAmount += amount;
                            _lastEnteredAmount = amount;
                            _notes.Add(amount);
                            Console.WriteLine($"{amount}€ added to {_type}");
                        }
                    }
                }
            }
        }

        public void AddCoin(decimal amount)
        {
            if (CheckEnteredAmount(amount))
            {
                if (CheckMoneyLimit(amount/100))
                {
                    AddCoinToRegister(amount);
                }  
            }
        }

        protected virtual void AddCoinToRegister (decimal amount)
        {
            _lastEnteredAmount = amount / 100;
            decimal euros;
            decimal cents;
            if (amount >= 100)
            {
                cents = amount % 100;
                euros = (amount - cents) / 100;
                _coinAmount += cents;
                _eurAmount += euros;
                if (cents == 0)
                {
                    Console.WriteLine($"{euros}€ added to {_type}.");
                }
                else
                {
                    Console.WriteLine($"{euros}€ and {cents} cent(s) added to {_type}.");
                }
            }
            else
            {
                cents = amount;
                _coinAmount += cents;
                Console.WriteLine($"{cents} cent(s) added to {_type}.");
            }
        }

        private bool CheckOneHundredNoteCount(decimal amount)
        {
            if(_oneHundredNotesCount == 5 && amount==100)
            {
                
                Console.WriteLine($"Cannot add {amount}€. {_type} cannot contain more than 5 100€ notes.");
                return false;
            }
            return true;
        }

        private bool CheckMaximumNoteValue (decimal amount) {
            if (amount > _maxNoteValue)
            {
                Console.WriteLine($"Invalid, max note value is {_maxNoteValue}");
                return false;
            }
            return true;
        }


        private bool CheckMoneyLimit(decimal amount)
        {
            CalculateTotalMoneyInRegister();
            if(_TotalMoneyInCashRegister + amount > _TotalMoneyLimit)
            {
                Console.WriteLine($"Cannot add {amount}€ to {_type}. Register cannot contain more than {_TotalMoneyLimit}€ ");
                return false;   
            }
            return true;
        }

        private void CalculateTotalMoneyInRegister()
        {
            _TotalMoneyInCashRegister = _eurAmount + (_coinAmount / 100);

        }

        private bool CheckEnteredAmount(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Invalid value. Cannot add {amount} to {_type}");
                return false;
            }
            return true;
        }

        public void MakeInventory()
        {
            _notes.Sort();
            Console.WriteLine($"Paper notes in {_type}");
            foreach(decimal note in _notes)
            {
                Console.Write($" {note} ");
            }
        }

        public void PrintLastEnteredAmount()
        {
            Console.WriteLine($"Lasted entered amount to {_type}: {_lastEnteredAmount}€");
        }

        public virtual void PrintTotalMoney()
        {
            CalculateTotalMoneyInRegister();
            Console.WriteLine($"{_type} total money in register: {_TotalMoneyInCashRegister}€");
        }
    }
}
