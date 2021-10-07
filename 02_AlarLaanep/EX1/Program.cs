using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result1 = FindPercentage(40, 50);
            double result2 = FindPercentage(30, 1);

            Console.WriteLine(result1);
            Console.WriteLine(result2);

        }

        static double FindPercentage(double number, double percentage)
        {
            return  (number * percentage) / 100;
            
        }
    }


}
