using System;
namespace BirdLayingEggsEx
{
    public class Ostrich: Bird
    {
        private string _eggColor;
        
        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int i = 0; i < eggs.Length; i++)
            {
                eggs[i] = new Egg(Bird.Randomizer.NextDouble() + 12, _eggColor);
            }
            return eggs;
            //Egg egg = new Egg();

        }
        public Ostrich()
        {
            _eggColor = "speckled";
        }
    }
}
