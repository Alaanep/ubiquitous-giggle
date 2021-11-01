using System;
namespace HiLoGame
{
    public static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random _random = new Random();
        private static int _currentNumber = _random.Next(1, MAXIMUM);
        private static int _pot = 10;

        public static void Guess(bool higher)
        {
            int nextRandomNumber = _random.Next(1, MAXIMUM+1);
            if (higher && nextRandomNumber >= _currentNumber)
            {
                Console.WriteLine("You guessed right!");
                Console.WriteLine("1 bucks added to your pot");
                _pot++;    
            }
            else if (!higher && nextRandomNumber<=_currentNumber)
            {
                Console.WriteLine("You guessed right!");
            
                _pot++;
            } else
            {
                Console.WriteLine($"Bad luck, you guessed wrong");
                
                _pot--;
            }
            _currentNumber = nextRandomNumber;
            Console.WriteLine($"The current number is: {_currentNumber}");

        }

        public static int GetPot()
        {
            return _pot;
        }

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (_currentNumber >= half)
            {
                Console.WriteLine($"The number is at least {half}");
            }
            else
            {
                Console.WriteLine($"The number is at most {half}");
            }
            _pot--;
        }

    }
}
