using System;

namespace CalculateDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            Random random = new Random();
            while (true)
            {
                Console.Write($"Enter 0 for no magic/flaming,  " +
                                $"1 for magic, 2 for flaming, 3 for both, anything else to quit");
                char input = Console.ReadKey().KeyChar;
                if (input != '0' && input != '1' && input != '2' && input != '3') return;
                int roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
                swordDamage.Roll = roll;
                swordDamage.SetMagic(input == '1' || input == '3');
                swordDamage.SetFlaming(input == '2' || input == '3');
                Console.WriteLine($"\nRolled {roll} for {swordDamage.Damage} HP\n");
            }
        }
    }
}
