using System;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10 / 3;
            if (value == 5)
            {
                Console.WriteLine("Its correct");
            }
            Console.WriteLine("I am thinking of a number between 1- 10, Can you guess it?");

            Random random = new Random();
            int guess = random.Next(1, 10);

            int input=0;

            while (input != guess)

            {
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input == guess)
                    {
                        Console.WriteLine($"Correct, i was thinking of {guess}");
                    }
                    else
                    {
                        Console.WriteLine($"Not exactly, i was thinking of smth else");
                        Console.WriteLine("Try again: ");
                    }
                }

            }


        }
    }
}