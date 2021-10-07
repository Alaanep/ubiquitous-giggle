using System;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number that i am thinking of: ");
            int secretNumber = 6;
            bool correctGuess = false;

            //while player has not guessed correct number
            while (!correctGuess)
            {
                //ask input and try to parse input to int
                Int32.TryParse(Console.ReadLine(), out int input);
                //call checkguess
                correctGuess = CheckGuess(input, secretNumber);
            }
        }

        //method that takes 2 parameters. Player guessed and secretnumber.
        //if player guess is not egual to secret number, print info for player and return false,
        //true otherwise
        static bool CheckGuess(int input, int guess)
        {
            if(input != guess)
            {
                Console.WriteLine("That is not the number i am thinking of. Try again: ");
                return false;
            }
            Console.WriteLine("Correct, you guessed my number");
            return true;
        }
        
    }
}
