using System;
using System.Collections.Generic;
using System.Linq;

namespace JimmyLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Comic> mostExpensive =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending
                select comic;

            IEnumerable<string> mostExpensiveComicDescription =
                from comic in Comic.Catalog
                where Comic.Prices[comic.Issue] > 500
                orderby Comic.Prices[comic.Issue] descending
                select $"{comic} is worth {Comic.Prices[comic.Issue]:c}";

            //foreach (Comic comic in mostExpensiveComicDescription)
            //{
            //    Console.WriteLine($"{comic} is worth {Comic.Prices[comic.Issue]:c}");
            //}
            foreach (string comic in mostExpensiveComicDescription)
            {
                Console.WriteLine(comic);
            }

        }
    }
}
