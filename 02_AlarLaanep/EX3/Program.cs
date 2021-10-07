using System;
using System.Collections.Generic;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum = GetSumOfRandomIntegers(5);
            Console.WriteLine($"\nSum of all items is: {sum}");
        }

        //method to create list of and populate it with random integers from 1-10.
        //size argument determines size of the list
        //method prints out all the items in the list
        //return sum of all items in list
        static int GetSumOfRandomIntegers(int size)
        {
            //create new random object
            Random random = new Random();
            //define list to hold random Integers
            List<int> randomIntegerList = new List<int>();

            for (var i = 0; i < size; i++)
            {
                randomIntegerList.Add(random.Next(1, 11));
            }

            Console.WriteLine($"List of {size} random numbers is: ");

            //define sum to hold sum of all items
            int sum = 0;

            //iterate over list, print and sum every item in list
            foreach(int item in randomIntegerList)
            {
                Console.Write($"{item} ");
                sum += item;
            }

            return sum;
        }
    }
}
