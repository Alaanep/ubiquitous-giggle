using System;
using System.IO;

namespace EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to square it: ");
            
            bool correctInput = int.TryParse(Console.ReadLine(), out int number);
            while (!correctInput)
            {
                Console.WriteLine("Enter number to square it: ");
                correctInput = int.TryParse(Console.ReadLine(), out number);
            }
            WriteSquareOfNumbers(number);

        }

        public static void WriteSquareOfNumbers(int num)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("result.txt", false))
                {
                    for (int i = 0; i < num; i++)
                    {
                        for (int j = 0; j < num; j++)
                        {
                            writer.Write(num);
                            Console.Write(num);
                        }
                        writer.Write("\n");
                        Console.Write("\n");
                    }
                }
                
            } catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            
        }
    }
}
