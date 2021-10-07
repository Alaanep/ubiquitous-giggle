using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumber = false;
            while (!isNumber) { 
                Console.WriteLine("Enter a number: ");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    isNumber = true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("This is not a number");
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
