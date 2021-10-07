using System;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Divide(3, 0));
            Console.WriteLine(int.Parse("0")== Double.Parse("0"));
        }

        private static double Divide(double v1, int v2)
        {
            try
            {
                return v1 / v2;
            }catch(DivideByZeroException ex)
            {
                
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Cannot divide by zero, but your number divided by2 would be {v1/2.0}");
                return v1 / 2;
            }
            
        }
    }
}
