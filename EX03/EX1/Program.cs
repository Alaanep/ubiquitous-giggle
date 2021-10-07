using System;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            double area1 = 20; //rectangle 1
            double area2 = 60; //rectangle 2
            double area3 = 78; //rectangle 3
            double height1 = 5;
            double height2 = 10;
            double height3 = 20;

            double width1 = calculateWidth(area1, height1);
            double circumFerence1 = calculateCircumference(height1, width1);
            double width2 = calculateWidth(area2, height2);
            double circumFerence2 = calculateCircumference(height2, width2);
            double width3 = calculateWidth(area3, height3);

            Console.WriteLine($"Rectangle 1, width: {width1}, height: {height1}, area: {area1}, circumference: {circumFerence1}");
            Console.WriteLine($"Rectangle 2, width: {width2}, height: {height2}, area: {area2}, circumference: {circumFerence2}");
            Console.WriteLine($"Rectangle 3, width: {width3}, height: {height3}, area: {area3}, circumference: N\\A");




        }

        public static double calculateWidth(double area, double height)
        {
            return area / height;
        }

        public static double calculateCircumference(double height, double width)
        {
            return (height + width) * 2;
        }

    }
}
