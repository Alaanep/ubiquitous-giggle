using System;
using System.Collections.Generic;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            try
            {
                Console.WriteLine(myList[1]);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("There is no item in the list.");
                Console.WriteLine($"Maximum index value is {myList.Count-1}");
            }
        }
    }
}
