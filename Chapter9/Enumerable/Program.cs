using System;

namespace Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sports = new ManualSportsSequence();
            //foreach(var sport in sports)
            //{
            //    Console.WriteLine(sport);
            //}
            foreach (int i in new PowersOfTwo())
                Console.Write($" {i} ");

        }
    }
}
