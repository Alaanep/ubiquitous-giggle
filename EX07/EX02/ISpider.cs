using System;
namespace EX02
{
    public interface ISpider
    {
        public void Bite();
        public void Eat(string food);
        public void PrintInfo();
        public void SetName(string name);
        public void SetAge(int age);
    }
}
