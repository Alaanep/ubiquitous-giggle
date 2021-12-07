using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows; 
            bool result = false;
            while (!result)
            {
                Console.Write("To Draw Diamond, enter numbers of rows(must be even): ");
                result = int.TryParse(Console.ReadLine(), out rows);

                if (rows % 2 == 0)
                {
                    result = false;
                } else
                {
                    DrawDiamond(rows);
                }
            }
        }

        static void DrawDiamond(int rows)
        {
            int count, i, j;
            rows = rows / 2+1;
            count = rows - 1;
            for(i=1; i <= rows; i++)
            {
                for (j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count--;
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            count = 1;
            for (i = 1; i <= rows - 1; i++)
            {
                for (j = 1; j <= count; j++)
                {
                    Console.Write(" ");
                }
                count++;
                for (j = 1; j <= (rows - i) *2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }   
    }
}
