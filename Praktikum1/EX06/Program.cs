using System;

namespace EX06
{
    class Program
    {
        static void Main(string[] args)
        {

            int answer = 1;
            int input=0;
            
            Console.WriteLine("Who was the legendary Benedictine monk who invented champagne?");
            Console.WriteLine("1. Dom Perignon");
            Console.WriteLine("2. Jack Daniels");
            Console.WriteLine("3. Captain Morgan");
            Console.WriteLine("Please enter the number for the answer");

            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input == answer)
                {
                    Console.WriteLine($"Correct. It was Dom Perignon");

                } else
                {
                    Console.WriteLine("I am afraid not. Correct answer is 1");
                }
            }
            else
            {
                Console.WriteLine("Please enter the number for the answer");
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input == answer)
                    {
                        Console.WriteLine($"Correct. It was Dom Perignon");
                    }
                    else
                    {
                        Console.WriteLine("I am afraid not. Correct answer is 1");
                    }
                }

            }
        }
    }
}
