using System;

namespace Alar_Laanep_kodutoo1_kalkulaator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 3;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(x + y);   //sum
            Console.WriteLine(x - y);   //subtraction
            Console.WriteLine(x*y);     //numbers multiplied
            Console.WriteLine(x / y);   //numbers diveded       
            if (x - y > 0)
            {
                Console.WriteLine(Math.Sqrt(x - y)); //sqrt if subtraction is >0
            } else
            {
                Console.WriteLine($"Cannot find square root, the value {x - y} is negative");
            }
        }
    }
}
