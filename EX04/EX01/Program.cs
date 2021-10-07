using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findSoupTemperature(60, 20));
        }

        //find soup temperature after 7 minutes.
        public static double findSoupTemperature(double soupTemp, double roomTemp)
        {
            double coolDownPercent = 0.13;//cooldown, soup cools down 13% per minute
            double soupT = soupTemp;
            
            for (int i = 0; i<7; i++)
            {   
                double coolDown = (soupT - roomTemp)* coolDownPercent;
                soupT = soupT - coolDown;
            }
            return soupT;
        }

    }
}
