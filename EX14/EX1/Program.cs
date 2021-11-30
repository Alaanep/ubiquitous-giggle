using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice;
            for (int i = 0; i <= 60; i+=10)
            {
                dice = new Dice(i);
                dice.DrawOuterFrame();
                dice.DrawRandomNumber();
            }
        }
    }
}
