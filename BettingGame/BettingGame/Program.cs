using System;

namespace BettingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.75;
            Guys player = new Guys("The Player", 100);
            Console.WriteLine($"Welcome to the casino, the odd are {odds}");
            while (player.Cash > 0)
            {

                player.WriteMyInfo();
                Console.WriteLine("How much money would you like to bet?");

                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount);
                    pot = pot * 2;
                    if (random.NextDouble() > odds)
                    {
                        Console.WriteLine($"Congratulations. You won {pot}");
                        player.ReceiveCash(pot);
                    }
                    else
                    {
                        Console.WriteLine("Bad luck, you lose");
                    }

                }
            }
            Console.WriteLine("The house always wins");
        }
    }
}
