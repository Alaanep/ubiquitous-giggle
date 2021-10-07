using System;

namespace Alar_Laanep_kodutoo1_pikkuse_hindaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter your height in cm: ");
            int height;

            if (int.TryParse(Console.ReadLine(), out height))
            {

            }
            else
            {
                Console.WriteLine("Please enter a numeric value");
                int.TryParse(Console.ReadLine(), out height);
            }

            if(height < 100)
            {
                Console.WriteLine($"{height}: Oh dear, you are either a child or a midget");
            } else if(height>=100 && height <= 155)
            {
                Console.WriteLine($"Not to tall..");
            } else if(height>155 && height<= 195)
            {
                Console.WriteLine("Average height");
            } else if(height > 195)
            {
                Console.WriteLine("Buying shoes must be a challenge for you.");
            }
        }
    }
}
