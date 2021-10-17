using System;
namespace EX02
{
    public class Spider: ISpider
    {
        protected string _type;
        protected int _age;
        protected string _name;
        protected int  _maxAge;

        public Spider()
        {
            _type = "regular spider";
            _maxAge = 10;

        }

        public virtual void Bite()
        {
            Console.WriteLine("You have been bitten");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Spider is eating {food}");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Spider name is: {_name}, age: {_age}, type: {_type}");
        }

        public void SetAge(int age)
        {
            if ((age>=0)  && (age <= _maxAge))
            {
                _age = age;
                Console.WriteLine($"Age was set to {_age}");
            } else
            {
                Console.WriteLine($"Invalid age. Max age is {_maxAge}. Age is not set");
            }
        }

        public virtual void SetName(string name)
        {
            _name = name;
            Console.WriteLine($"Name was set to {_name}");
        }
    }
}
