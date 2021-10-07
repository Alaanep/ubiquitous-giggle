using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            myFirstMethod();
            GreetMe("Marja");
            CalculateSum(5, 5);
            CalculateSalary(1000);
            GetNameWithGreeting("Mari");
            Console.WriteLine(Square(2));
            Console.WriteLine(ModifyNumber(10));
        }

        public static void myFirstMethod()
        {
            Console.WriteLine("I am your first method");

        }

        public static void GreetMe(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public static void CalculateSum(int a, int b)
        {
            Console.WriteLine($"Sum of {a} + {b} is {a + b}");
        }

        public static void CalculateSalary(double salary)
        {
            Console.WriteLine($"Salary {salary} is {salary * 1.2} with tax");
        }

        public static string GetNameWithGreeting(string name)
        {
            return $"Hello {name}!";
        }

        public static double Square(double number)
        {
            return number * number;
        }

        public static string ModifyNumber(int number) {
            return $"{number*number + number} is result";
        }

    }
}
