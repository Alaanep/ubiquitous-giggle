using System;
namespace Animal
{
    public class Cat: Animal, IAnimal
    {
        public Cat()
        {
            _type = "Cat";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{_type} is meowing");
        }

        public override void SetName(string name)
        {
            if (name.Length <= 4)
            {
                base.SetName(name);
            } else
            {
                Console.WriteLine("Name maximum length is 8. Name was not set.");
            }
        }

        public override void Jump()
        {
            if (_jumpCount < 3)
            {
                base.Jump();
            } else
            {
                Console.WriteLine("Cat is tired, must sleep now");
            }
            
        }
    }
}
