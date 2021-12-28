using System;
using System.Collections.Generic;

namespace Lumberjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Queue<LumberJack> lumberJacks = new Queue<LumberJack>();
            string name;
            Console.Write("First lumberjack name:  ");
            
            while ((name = Console.ReadLine())!=""){
                Console.Write("Number of flapjacks: ");
                if (int.TryParse(Console.ReadLine(), out int numberOfFlapjacks))
                {
                    LumberJack lumberJack = new LumberJack(name);
                    for (int i =0; i < numberOfFlapjacks; i++)
                    {
                        lumberJack.TakeFlapjack((FlapJack)random.Next(0, 4));
                    }
                    lumberJacks.Enqueue(lumberJack);
                }
                Console.Write("Next lumberjack's name (blank to end): ");
            }
            while (lumberJacks.Count > 0)
            {
                LumberJack next = lumberJacks.Dequeue();
                next.EatFlapjack();
            }
        }
    }
}
