using System;
namespace Animal
{
    public class Dog : Animal, IAnimal
    {
        public Dog()
        {
            _type = "Dog";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{_type} is barking");
        }

        public override void SetName(string name)
        {
            if(name.Length <= 8)
            {
                base.SetName(name);
            } else
            {
                Console.WriteLine("Name maximum length is 8. Name was not set.");
            }
            
        }
    }
}
