using System;
using System.Collections.Generic;

namespace loeng3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 30; i++)
            {
                List<int> myList = new List<int>();
                myList.Add(i);
                Console.WriteLine(myList.Count);
            }

        }

      
        }
    }
