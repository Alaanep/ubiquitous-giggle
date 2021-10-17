using System;
namespace Animal
{
    public class Chiuaua: Dog, IAnimal
    {   
       

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("with a really irritating voice");
        }
    }
}
