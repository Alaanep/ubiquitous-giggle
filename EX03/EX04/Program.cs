using System;
using System.IO;
using System.Collections.Generic;

namespace EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            using(StreamReader reader = new StreamReader("test.txt"))
            {
                string line; //represents the line that we read
                while((line = reader.ReadLine()) != null)
                {
                    myList.Add(line);
                }
            }
            //Console.WriteLine(myList.Count);
            //foreach(string el in myList)
            //{
            //    Console.WriteLine(el);
            //}

            myList.Sort();
            //foreach (string el in myList)
            //{
            //    Console.WriteLine(el);
            //}

            using(StreamWriter writer = new StreamWriter("sortedList.txt", false))
            {
                foreach(string el in myList)
                {
                    writer.WriteLine3(el);
                }
                
            }
        }
    }
}
