using System;
using System.Collections.Generic;
using System.Linq;
namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = new List<int>();
            //for(int i = 1; i<=99; i++)
            //{
            //    numbers.Add(i);
            //}
            //IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(5));

            //foreach(int i in firstAndLastFive)

            //{
            //    Console.Write($"{i} ");
            //}

            var random = new Random();
            var numbers = new List<int>();
            int length = random.Next(50, 150);
            for(int i = 0; i < length; i++)
            {
                numbers.Add(random.Next(100));
            }
            Console.WriteLine(
            $@"Stats for these {numbers.Count()} numbers: 
            The first 5 numbers: {string.Join(", ", numbers.Take(5)) }
            The last 5 numbers: {string.Join(", ", numbers.TakeLast(5))}
            The first is {numbers.First()} and the last is {numbers.Last()}
            The smallest is  {numbers.Min()}, and the biggest is {numbers.Max()}
            The sum is {numbers.Sum()}
            The average is {numbers.Average():F2}
            ");
        }
    }
}
