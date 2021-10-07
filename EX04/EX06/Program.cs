using System;

namespace EX06
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsistsOf(43928);
        }

        public static void ConsistsOf(int number)
        {
            string numbers = number.ToString();
            int multiplier = 1;
            for(int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(int.Parse(numbers[i].ToString())*multiplier);
                multiplier *= 10;
            }
            
        }
        
    }
}
