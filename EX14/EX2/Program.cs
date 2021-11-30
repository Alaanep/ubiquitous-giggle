using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnGrains(4));
        }

        static public int ReturnGrains(int square)
        {
            int grain = 1;
            if(square == 0)
            {
                return grain;
            } else
            {
                for (int i = 1; i < square; i++)
                {
                    grain = grain * 2;
                }
            }
            
            return grain;
        }
    }
}
