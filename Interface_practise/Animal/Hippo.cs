using System;
namespace Animal
{
    public class Hippo: Animal, ISwimmer
    {
        public Hippo()
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("Grunt.");
        }

        public void Swim()
        {
            Console.WriteLine("Splash! I'm going for a swim");
        }


    }
}
