using System;
using System.Collections.Generic;
using System.Linq;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>
            {
                new Duck(){Kind=KindOfDuck.Mallard, Size = 17},
                new Duck(){Kind=KindOfDuck.Muscovy, Size = 18},
                new Duck(){Kind=KindOfDuck.Loon, Size = 14},
                new Duck(){Kind=KindOfDuck.Muscovy, Size = 11},
                new Duck(){Kind=KindOfDuck.Mallard, Size = 14},
                new Duck(){Kind= KindOfDuck.Loon, Size = 13},
            };
            IEnumerable<Bird> upCastDucks = ducks;

            Bird.FlyAway(upCastDucks.ToList(), "Minnesota") ;
            //IComparer<Duck> sizeComparer = new DuckComparerBySize();
            //IComparer<Duck> kindComparer = new DuckComparerByKind();
            //ducks.Sort(kindComparer);
            //PrintDucks(ducks);
            //Console.WriteLine();
            //ducks.Sort(sizeComparer);
            //PrintDucks(ducks);

            DuckComparer comparer = new DuckComparer();
            Console.WriteLine("\nSorting by kind, then size\n");
            comparer.SortBy = SortCriteria.kindThenSize;
            ducks.Sort(comparer);
            PrintDucks(ducks);
            Console.WriteLine();

            Console.WriteLine("\nSorting by size, then kind\n ");
            comparer.SortBy = SortCriteria.sizeThenKind;
            ducks.Sort(comparer);
            PrintDucks(ducks);

        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach(Duck duck in ducks)
            {
                //Console.WriteLine($"{duck.Size} inch {duck.Kind}");
                Console.WriteLine(duck);
            }
        }
    }
}
