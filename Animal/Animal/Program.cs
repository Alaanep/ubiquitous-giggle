using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal animal = new Animal();
            animal.MakeSound();
            animal.Jump();
            animal.Jump();
            animal.Jump();
            animal.SetName("myAnimalName");
            animal.PrintInfo();

            Dog dog = new Dog();
            dog.MakeSound();
            dog.Jump();
            dog.Jump();
            dog.SetName("mydogname");
            dog.PrintInfo();
            dog.SetName("Kuti");
            dog.PrintInfo();

            Cat cat = new Cat();
            cat.MakeSound();
            cat.Jump();
            cat.Jump();
            cat.Jump();
            cat.Jump();
            cat.SetName("mikut");
            cat.PrintInfo();
            cat.SetName("Meow");
            cat.PrintInfo();

            Chiuaua chiuaua = new Chiuaua();
            chiuaua.MakeSound();
            chiuaua.Jump();
            chiuaua.Jump();
            chiuaua.Jump();
            chiuaua.Jump();
            chiuaua.SetName("chiuauaauau");
            chiuaua.PrintInfo();
            chiuaua.SetName("chiuaua");
            chiuaua.PrintInfo();



        }

        
        
    }
}
