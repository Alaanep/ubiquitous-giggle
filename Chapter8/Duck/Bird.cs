using System;
using System.Collections.Generic;

namespace Duck
{
    public class Bird
    {
        public Bird()
        {
        }

        public string Name { get; set; }

        public virtual void Fly(string destination) {
            Console.WriteLine($"{this} is flying to {destination}");
        }

        public override string ToString()
        {
            return $"A bird named {Name}";
        }

        public static void FlyAway(List<Bird> flock, string destination) {
            foreach(Bird bird in flock)
            {
                bird.Fly(destination);
            }
        }


    }
}
