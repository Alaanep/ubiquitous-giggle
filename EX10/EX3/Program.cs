using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator tc = new TaxCalculator();
            tc.AddYearlyIncome(-20000);
            Console.WriteLine(tc.YearlySalary);
            
            Console.WriteLine(tc.FindYearlyTaxFreeAmount());
            Console.WriteLine(tc.FindMonthlyTaxFreeAmount());
        }
    }
}
