using System;
namespace EX07Loeng
{
    public class LoudDog: Dog
    {
        public override void Bark()
        {
            base.Bark();
            Console.WriteLine("Bark");
        }
        public LoudDog()
        {
        }
    }
}
