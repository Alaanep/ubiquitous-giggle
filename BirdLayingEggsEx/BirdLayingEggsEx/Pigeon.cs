using System;
namespace BirdLayingEggsEx
{
    public class Pigeon: Bird
    {
        
        private string _eggColor;
        public Pigeon()
        {
            _eggColor = "white";        }
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i=0;i<eggs.Length; i++)
            {
                if (Bird.Randomizer.Next(4) == 0)
                {
                    eggs[i] = new BrokenEgg(Bird.Randomizer.NextDouble() * 2 + 1, _eggColor);
                } else
                {
                    eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, _eggColor);
                }
                
            }
            return eggs;
           //Egg egg = new Egg();

        }
    }
}
