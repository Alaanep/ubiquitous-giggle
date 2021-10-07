using System;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Tere, {firstName} {lastName}");
            int age;
            Console.WriteLine("Please enter your age");
            if(int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine($"In just {100-age} you might be 100 years old");
            } else
            {
                Console.WriteLine("Please enter your age in numeric value: ");
                int.TryParse(Console.ReadLine(), out age);
                Console.WriteLine($"In just {100 - age} you might be 100 years old");
            }
        }
    }
}
