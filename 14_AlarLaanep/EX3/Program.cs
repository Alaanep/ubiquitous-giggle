using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] randmomNumbers = new int[10];

            for(int i =0; i < randmomNumbers.Length; i++)
            {
                randmomNumbers[i] = random.Next(0, 1000);
            }

            randmomNumbers = InsertionSort(randmomNumbers);
            foreach(int nr in randmomNumbers)
            {
                Console.WriteLine(nr);
            }
        }

        static int[] InsertionSort(int[] arr)
        {
            int previous;
            int current;
            //iterate over array
            for(int i = 1; i<arr.Length; i++)
            {

                previous = i - 1; //previus element index
                current = arr[i]; //current element
                
                //compare current element to previous element
                //while index of previous element >=0, meaning if previous element is 0==start of array
                //and previous element is bigger than current element
                while (previous >= 0 && arr[previous] > current)
                {
                    //move element that are creater than current one position to the right
                    arr[previous + 1] = arr[previous];
                    previous--;
                }
                arr[previous + 1] = current;

            }
            return arr;
        }
    }
}
