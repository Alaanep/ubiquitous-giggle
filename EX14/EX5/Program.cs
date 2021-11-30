using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateRandomArray();

        }

        public static int[] GenerateRandomArray()
        {
            Random random = new Random();
            int[] array = new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-1000, 1001);
            }



            //int temp = 0;

            //for (int write = 0; write < array.Length; write++)
            //{
            //    for (int sort = 0; sort < array.Length - 1; sort++)
            //    {
            //        if (array[sort] > array[sort + 1])
            //        {
            //            temp = array[sort + 1];
            //            array[sort + 1] = array[sort];
            //            array[sort] = temp;
            //        }
            //    }
            //}

            array = bubble_sort(array, false);

            Console.WriteLine("Generated array is: ");
            foreach(int nr in array)
            {
                Console.Write(nr + " ");
            }
            return array;
        }

        static int[] bubble_sort(int[] arr, Boolean ascending)
        {
            int arrLength = arr.Length;
            int temp;
            Boolean isSorted;

            for(int i = 0; i < arrLength; i++)
            {
                isSorted = true;
                for(int j =1;j<(arrLength-i); j++)
                {
                    if (ascending)
                    {
                        if (arr[j - 1] > arr[j])
                        {
                            temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = temp;
                            isSorted = false;
                        }
                    }
                    else
                    {
                        if(arr[j - 1] < arr[j])
                        {
                            temp = arr[j - 1];
                            arr[j - 1] = arr[j];
                            arr[j] = temp;
                            isSorted = false;
                        }
                    }
                }
                if (isSorted) break;
            }
            return arr;
            
        }
    }
}
