using System;
using System.Collections.Generic;

namespace EX2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> listOfString = new List<string>();

            //for(int i = 1; i <= 3; i++)
            //{
            //    listOfString.Add($"item{i}");
            //}

            ////Console.WriteLine(listOfString[2]);
            ////Console.WriteLine(listOfString.Count);
            ////listOfString.RemoveAt(2);
            ////listOfString.Remove("item1");
            ////Console.WriteLine(listOfString.Count);

            //List<string> listOfStrings = new List <string>() { "name", "breed" };
            //listOfString.AddRange(listOfStrings);
            ////Console.WriteLine(listOfString.Count);

            //List<string> weekdays = new List<string>() { "Monday", "Tuesday", "Wednesday" };

            //for(int i = 0; i<weekdays.Count; i++)
            //{
            //    Console.WriteLine(weekdays[i]);
            //}

            //foreach (string day in weekdays)
            //{
            //    Console.WriteLine($"Hello {day}");
            //}

            //int count = 0;
            //while (count < weekdays.Count)
            //{
            //    Console.WriteLine(weekdays[count]);
            //    count++;
            //}


            //for(int i = 1; i<=10; i++)
            //{
            //    Console.Write($"{i} ");
            //}

            //Console.WriteLine(GetIntegerList().Count);

            //int count = 10;
            //while(count >= 5)
            //{
            //    Console.Write($"{count} ");
            //    count--;
            //}

            //Console.WriteLine("Please enter a word with length 4");
            //string input = Console.ReadLine();
            //while (input.Length != 4)
            //{
            //    Console.WriteLine("This is not 4 letters");
            //    Console.WriteLine("Please enter a word with length 4");
            //    input = Console.ReadLine();

            //}

            int[] nums = new int[4];

            nums[0] = 3;
            nums[1] = 5;
            nums[2] = 6;
            nums[3] = 7;



            foreach(int num in nums)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }


        }
        public static List<int> GetIntegerList()
        {
            List<int> integerList = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                integerList.Add(i);
            }
            return integerList;



        }
    }
}
