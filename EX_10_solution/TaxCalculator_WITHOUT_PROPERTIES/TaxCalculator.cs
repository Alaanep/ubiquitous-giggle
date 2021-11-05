using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator_WITHOUT_PROPERTIES
{
    public class TaxCalculator
    {
        //using private field and return type methods
        private double _yearlyIncome; //private field

        public void AddYearlyIncome(double amount)
        {
            _yearlyIncome = amount;
        }
        public void AddMontlhyIncome(double amount)
        {
            _yearlyIncome = amount * 12;
        }

        //method for making field _yearlyIncome public
        public double GetYearlyIncome()
        {
            return _yearlyIncome;
        }

        //OR use return type method instead of property!
        public double FindYearlyTaxFreeIncome()
        {
            //less or equal to 14400
            if (_yearlyIncome <= 14400)
            {
                if (_yearlyIncome < 6000)
                {
                     return _yearlyIncome;
                }
                return 6000;
            }
            else if (_yearlyIncome <= 25200)//less or equal to 25200
            {
                return 6000 - (6000.0 / 10800.0
                                        * (_yearlyIncome - 14400));
            }
            return 0;
        }

        public double FindMonthlyTaxFreeIncome()
        {
            double yearly = FindYearlyTaxFreeIncome(); //to find monthly we need to find yearly first
            return yearly / 12;
        }
    }
}
