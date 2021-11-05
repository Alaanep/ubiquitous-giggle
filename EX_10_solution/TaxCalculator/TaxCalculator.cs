using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace TaxCalculatorClass
{
    //using public properties, their values are set by methods
    public class TaxCalc
    {
        //public property for yearly income
        //this value can be read from other classes but set only in this class
        public double YearlyIncome { get; private set; }
        public double YearlyTaxFree { get; private set; }
        public double MonthlyTaxFree { get; private set; }
        public void AddYearlyIncome(double amount)
        {
            YearlyIncome = amount;
        }
        public void AddMonthlyIncome(double amount)
        {
            YearlyIncome = amount * 12;
        }
        
        public void FindYearlyTaxFreeIncome()//OR use return type method instead of property!
        {
            if (YearlyIncome <= 14400)//less or equal to 14400
            {
                if (YearlyIncome < 6000)
                {
                    YearlyTaxFree = YearlyIncome;
                }
                else
                {
                    YearlyTaxFree = 6000;
                }
            }
            else if (YearlyIncome <= 25200)//less or equal to 25200
            {
                YearlyTaxFree = 6000 - (6000.0 / 10800.0
                                      * (YearlyIncome - 14400));
            }
            else //over 25200
            {
                YearlyTaxFree = 0;
            }
        }

        public void FindMonthlyTaxFreeIncome()
        {
            //to find monthly we need to find yearly first
            FindYearlyTaxFreeIncome(); 
            MonthlyTaxFree = YearlyTaxFree / 12;
        }
    }
}
