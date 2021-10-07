using System;
using System.Collections.Generic;

namespace LOENG4
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = ConjugateValues("2", 3);
            //ConjugateValues("3", 2);
            //string b = ConjugateValues("2", 3);
            //int i = 4;
            //for (i = 2; i < 4; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 1; i <= 2; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 0;
            //int j = 10;
            //while (i <= 10 && j <= 10)
            //{
            //    Console.WriteLine(i + j);
            //    i++;
            //}
            //int x = 5;
            //int y = x + 5; Console.WriteLine(y);
            //int a = 2;
            //if (a >= 0 && a < 2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}
            //int i = 7;
            //int j = 5;
            //if (i != j)
            //{
            //    i += 6;
            //    j += 5;
            //}
            //i = j;
            //Console.WriteLine(j);
            //List<int> listOfInts = new List<int>() { 4, 3, 2, 1 };
            //listOfInts.RemoveAt(1);
            //listOfInts.Add(2);
            //Console.WriteLine(listOfInts[1]);

            //int[] myArray = new int[3];
            //myArray[1] = 2;
            //myArray[2] = 1;
            //foreach (int val in myArray)
            //{
            //    Console.WriteLine(val);
            //}
            //int result = Multiply(3);
            //result = Multiply(4); //what is value?
            //int result = Multiply(3, 4);
            //Console.WriteLine(result);

            AddTax(301);

        }
        public static void AddTax(int amount)
        {
            if (ShouldAddTax(300))
            {
                Console.WriteLine("Tax added");
            }
            else
            {
                Console.WriteLine("Tax not added");
            }
        }

        public static bool ShouldAddTax(int amount)
        {
            if (amount > 300)
            {
                return true;
            }
            return false;
        }
        //public static void GreetMe(string name)
        //{
        //    Console.WriteLine("Hello" + "name");
        //}

        //public static int Multiply(int a, int b)
        //{
        //    return b * 3;
        //}

        //public static int Multiply(int a)
        //{
        //    return a * 3;
        //}

        //static string ConjugateValues(string a, int b)
        //{
        //    return a + b;
        //}
    }

    
}
