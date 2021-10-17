using System;
namespace Animal
{
    public class Animal: IAnimal
    {
        private string _name;
        protected int _jumpCount;
        protected string _type;
        
        public Animal()
        {
            _type = "Animal";
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{_type} is making sound");
        }

        public virtual void Jump() {
            _jumpCount++;
            Console.WriteLine($"{_type} has jumped {_jumpCount} times");
            
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Type: {_type}, name: {_name}"); ;
        }

        public virtual void SetName(string name) {
            _name = name;
        }

    }
}
