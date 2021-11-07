using System;
namespace BirdLayingEggsEx
{
    public class Bird
    {
        public static Random Randomizer = new Random();
        public  virtual Egg[] LayEggs(int numberOfEggs)
        {
            Console.Error.WriteLine("Bird.LayEggs should never get called");
            return new Egg[0];
        }
        public Bird()
        {
        }
    }
}
