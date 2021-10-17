using System;
namespace Animal
{
    public interface IAnimal
    {
        public void MakeSound();
        public void Jump();
        public void PrintInfo();
        public void SetName(string name);
    }
}
