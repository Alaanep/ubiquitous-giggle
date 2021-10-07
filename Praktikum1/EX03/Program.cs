using System;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "some name"; //setting initial value to the variable
            Console.WriteLine(name); //printing variable name value (“some name”)
            name = "new name"; //giving new value to the variable
            Console.WriteLine(name);
            string firstName = "noFirstName";
            Console.WriteLine(firstName);
            string lastName = "noLastName";
            Console.WriteLine(lastName);
            //Console.WriteLine(firstName - lastName);
            int number = 6;
            int age = 2;
            int height = 3;
            Console.WriteLine(age + height);
            Console.WriteLine(age - height);
            string a = "5";
            int b = 5;
            Console.WriteLine(int.Parse(a) + b);
            

        }
    }
}
