using System;
using System.Collections.Generic;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salaryWithTax = CalculateSalary(4000);
            Console.WriteLine(salaryWithTax);
            Console.WriteLine(CalculateSalary(1001));
            string word = "Kala";
            int wordLength = FindWordLength(word);
            Console.WriteLine("word {0} has {1} letters", word, wordLength);
            PrintListWithForLoop();

        }

        public static double CalculateSalary(double salary)
        {
            if (salary > 1000)
            {
                salary = salary * 1.2;
            }

            return salary;
        }

        public static  void PrintMyInfo()
        {
            Console.WriteLine("Hello my name is x");
            Console.WriteLine("I love programming");
            
        }

        public static int FindWordLength(string word)
        {
            return word.Length;
        }

        public static void PrintListWithForLoop()
        {
            List<string> listToPrint = GetWeekdays();

            for(int i = 0; i<listToPrint.Count; i++)
            {
                Console.WriteLine(listToPrint[i]);
            }
        }

        public static List<string> GetWeekdays()
        {
            List<string> weekdays = new List<string>();
            weekdays.Add("Monday");
            weekdays.Add("Tuesday");
            weekdays.Add("Wednesday");
            return weekdays;
        }



    }
}
