using System;
namespace EX01
{
    public class Dog
    {
        private string _name;
        private int _age;
        private string _ownerName;

        public Dog(string name)
        {
            _name = name;
            Console.WriteLine($"A dog with name {_name} is created!");
            
        }

        public int Age {
            get {return _age; }
            set {_age = value; }
        }

        public void ChangeOwnersName(string newOwner)
        {
            Console.WriteLine("Previous owner was: " + _ownerName);
            _ownerName = newOwner;
            Console.WriteLine("New owner is: " + _ownerName);
        }

        public void Run()
        {
            if (_age < 10)
            {
                Console.WriteLine($"{_name} is running fast");
            } else
            {
                Console.WriteLine($"{_name} is running slowly");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Dogs name is {_name} and age is {_age}." +
                $"Owners name is {_ownerName}");
        }

    }
}
