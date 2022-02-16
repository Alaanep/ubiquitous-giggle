using System;

namespace FindPrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFactors factors = new PrimeFactors();
            var list = factors.FactorsOf(9);

            foreach(int n in list) { Console.WriteLine(n); }


        }
    }
}
