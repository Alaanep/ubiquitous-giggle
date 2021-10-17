//base class

using System;
namespace EX07Loeng
{
    public class Dog
    {
        public virtual void Bark()
        {
            Console.WriteLine("Bark");
            Console.WriteLine("Bark");
        }

        public void Eat(string food)
        {
            Console.WriteLine("Dog is eating " + food);
        }
        public Dog()
        {
        }
    }
}
