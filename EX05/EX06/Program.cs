using System;

namespace EX06
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DateTime birthdate = new DateTime(1985, 05, 25);

            Console.WriteLine(birthdate);
            Console.WriteLine(today);

            Console.WriteLine($"Total nr days i have lived: {(today - birthdate).Days}");
            Console.WriteLine($"My age in years: {((today-birthdate).Days)/365.25}");

            DateTime endOfYear = new DateTime(2021, 12, 31);

            Console.WriteLine($"{(endOfYear - today).Days} days left in this year");
            
        }
    }
}
