using System;
using System.Collections.Generic;

namespace Quiz4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listFromMethod = GetList(5);
            int a = 0;
            foreach (int nr in listFromMethod)
            {
                if (nr % 2 == 1)
                {
                    a += nr; // a = a + nr
                    
                }
                else
                {
                    a += 3;
                }
                Console.WriteLine(a);
            }
            
        }

        static List<int> GetList(int upperLimit)
        {
            List<int> myList = new List<int>();
            for (int i = 0; i <= upperLimit; i++)
            {
                myList.Add(i);
            }
            return myList;
        }
    }
}
