using System;
using System.Collections.Generic;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>();
            Console.WriteLine("Please enter 3 strings: ");
            for(int i = 0; i < 3; i++)
            {
                AskInputAndAddToList(items);
            }

            //sort items List
            items.Sort();
            Console.WriteLine($"Results in a sorted list are: ");
            foreach(string item in items)
            {
                Console.WriteLine(item);
            }
        }

        static void AskInputAndAddToList(List <string> itemsList)
        {
            string input = Console.ReadLine();
            itemsList.Add(input);
        }
    }
}
