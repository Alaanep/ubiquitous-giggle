using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter value for calculating tax: ");


            bool correctInput = double.TryParse(Console.ReadLine(), out double value);
            while (!correctInput)
            {
                Console.WriteLine("Enter int value for calculating tax; ");
                correctInput = double.TryParse(Console.ReadLine(), out value);

            }
            calculatingValueWithTax(value);

            
        }

        public static void calculatingValueWithTax (double value)
        {
            if (value > 800)
            {
                value = value * 1.28;
            }
            else if (value > 500)
            {
                value = value * 1.22;
            }

            Console.WriteLine($"Value with tax is: {value}");
        }

    }
}
