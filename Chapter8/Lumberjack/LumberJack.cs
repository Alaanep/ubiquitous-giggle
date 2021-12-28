using System;
using System.Collections.Generic;
namespace Lumberjack
{
    public class LumberJack
    {
        public string Name { get; private set; }

        private Stack<FlapJack> flapjackStack = new Stack<FlapJack>();

        public void TakeFlapjack(FlapJack flapjack)
        {
            flapjackStack.Push(flapjack);
        }

        public void EatFlapjack()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            while (flapjackStack.Count > 0)
            {
                Console.WriteLine($"{Name} ate a {flapjackStack.Pop().ToString().ToLower()} flapjack");
            }
            
        }

        public LumberJack(string name)
        {
            Name = name;
        }
    }
}
