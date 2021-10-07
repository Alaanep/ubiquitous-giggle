using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintCharacters();
            PrintCharactersAdv();//advanced and optional
        }

        static void PrintCharacters()
        {
            for(int i = 7; i > 0; i--)
            {
                for(int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            
        }

        //advanced and optional
        static void PrintCharactersAdv()
        {
            int number = 0;
            string numbers="";
            for (int i = 7; i > 0; i--)
            {
                number++;
                numbers = numbers + Convert.ToString(number);
                Console.Write(numbers);
                for (int j = i-1; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
