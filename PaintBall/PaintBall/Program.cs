using System;

namespace PaintBall
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = ReadInt(20, "Number of balls");
            int magazineSize = ReadInt(16, "Magazine size");
            Console.Write($"Loaded[false]: ");
            bool.TryParse(Console.ReadLine(), out bool isLoaded);

            PaintBallGun gun = new PaintBallGun(numberOfBalls,magazineSize,isLoaded);
            while (true)
            {
                Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
                if (gun.IsEmpty())
                {
                    Console.WriteLine("WARNING: You're out of ammo");
                }
                Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
                char key = Console.ReadKey().KeyChar;
                if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
                else if (key == 'r') gun.Reload();
                else if (key == 'q') return;
                else if (key == '+') gun.Balls+= gun.MagazineSize;
                

            }
        }

        static int ReadInt(int lastUsedValue, string prompt)
        {
            Console.Write($"{prompt} [{lastUsedValue}]:");
            string line = Console.ReadLine();
            if(int.TryParse(line, out int value))
            {
                Console.WriteLine($"Using value {value}");
                return value;
            }
            else
            {
                Console.WriteLine($"Using default value {lastUsedValue}");
                return lastUsedValue;
            }
        }
    }
}
