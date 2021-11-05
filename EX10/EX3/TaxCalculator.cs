using System;
namespace EX3
{
    public class TaxCalculator
    {
        public TaxCalculator()
        {
            taxFreeLowerLimit = 14400;
            taxFreeHigherLimit = 25200;
        }

        private double taxFreeLowerLimit;
        private double taxFreeHigherLimit;
        public double YearlySalary { get; set; }

        public void AddMonthlyIncome(double monthlyIncome)
        {
            if (monthlyIncome < 0)
            {
                monthlyIncome = 0;
                Console.WriteLine("Cannot add negative income. Value defaulted to 0.");
            }
            YearlySalary = monthlyIncome * 12;
        }

        public void AddYearlyIncome(double yearlyIncome)
        {
            if (yearlyIncome < 0)
            {
                yearlyIncome = 0;
                Console.WriteLine("Cannot add negative income. Value defaulted to 0.");
            }
            YearlySalary = yearlyIncome;
        }

        public double FindYearlyTaxFreeAmount()
        {
            double yearlyTaxFreeIncome=0;
            if (YearlySalary < taxFreeLowerLimit)
            {
                yearlyTaxFreeIncome = 6000;
            }
            else if (YearlySalary >= taxFreeLowerLimit && YearlySalary < taxFreeHigherLimit)
            {
                yearlyTaxFreeIncome = 6000D - 6000D / 10800D * (YearlySalary - 14400D);
            }
            else
            { 
                yearlyTaxFreeIncome = 0;
                
            }
            return yearlyTaxFreeIncome;
        }

        public double FindMonthlyTaxFreeAmount()
        {
            return FindYearlyTaxFreeAmount() / 12;
        }

        public void FindTaxFreeAmount()
        {
            Console.WriteLine($"If yearly salary is {YearlySalary} then monthly tax free amount is {FindMonthlyTaxFreeAmount()}");
        }
    }
}
