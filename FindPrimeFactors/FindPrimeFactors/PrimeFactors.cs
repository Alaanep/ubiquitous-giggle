using System;
using System.Collections.Generic;

namespace FindPrimeFactors
{
    public class PrimeFactors
    {
        private List<int> factorsOf;
        public PrimeFactors()
        {
            factorsOf = new List<int>();
        }

        public List<int> FactorsOf(int n)
        {
            //int divisor = 2;
            //while (n > 1)
            //{
            //    while (n % divisor == 0)
            //    {
            //        factorsOf.Add(divisor);
            //        n /= divisor;
            //    }
            //    divisor++;
            //}
            //if (n > 1)
            //{
            //    factorsOf.Add(n);
            //}

            for(int divisor = 2; n > 1; divisor++)
            {
                for (; n % divisor == 0; n /= divisor)
                {
                    factorsOf.Add(divisor);
                }
            }
            return factorsOf;
        }
    }
}
