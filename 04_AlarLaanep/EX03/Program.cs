using System;
using System.Collections.Generic;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> example1 = new List<int>() { 3, 3, 5, 9, 11};
            List<int> example2 = new List<int>() { 3, 5, 7, 9};
            Console.WriteLine(GetMedian(example1));
            Console.WriteLine(GetMedian(example2));
            Console.WriteLine(GetAverage(example1));
            Console.WriteLine(GetAverage(example2));

        }

        //find and return median
        public static int GetMedian(List<int>listOfNumbers)
        {
            int median;
            List<int> myList = listOfNumbers;
            myList.Sort();
            if (myList.Count % 2 != 0)
            {
                //Console.WriteLine($"half: {}")
                median = myList[myList.Count / 2];
            } else
            {
                median = (myList[(myList.Count / 2)-1] + myList[myList.Count / 2])/2;
            }
            return median;
        }

        //find and return average
        public static double GetAverage(List<int> listOfNumbers)
        {
            double average;
            List<int> myList = listOfNumbers;

            double totalSum = 0;
            foreach(int num in myList)
            {
                totalSum += num;
            }
            average = totalSum / myList.Count;
            return average;
        }
    }
}
