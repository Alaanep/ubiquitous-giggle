using System;
using System.Collections.Generic; 

namespace DebugingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10,9};
            List<int> smallest = new List<int>();

            smallest = GetSmallests(numbers, 3);

            foreach(int number in smallest)
            {
                Console.WriteLine(number);
            }
        }
        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list", "list cannot be null");
            }
            if(count > list.Count || count <=0)
            {
                throw new ArgumentOutOfRangeException("count", "count shoulde be between 1 and the number of elements in the list.");
            }
            List<int> buffer = new List<int>(list);
            List<int> smallests = new List<int>();
            while(smallests.Count < count)
            {   
                var min = GetSmallest(buffer);
                smallests.Add(min);
                 buffer.Remove(min);
            }
            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            //assume the first number is the smallest
            int min = list[0]; 
            for(var i=1; i < list.Count; i++)
            {
                if(list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;
        }

    }
}
