using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter interest rate as %: ");
            decimal interest = decimal.Parse(Console.ReadLine())/100;
            Console.WriteLine("Enter year: ");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine($"Final sum is: { FindCompoundInterest(amount, interest, years)}");
        }

        public static decimal FindCompoundInterest(decimal amount, decimal interest, int years)
        {
            decimal totalSum = amount;
            decimal interestPerYear = 0;

            for(int i =1; i <= years; i++)
            {
                interestPerYear = totalSum * interest;
                //Console.WriteLine(interestPerYear);
                totalSum = totalSum + interestPerYear;
            }
            return totalSum;
        }
    }
}
