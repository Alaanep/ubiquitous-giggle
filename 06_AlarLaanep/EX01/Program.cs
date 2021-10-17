using System;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            myCircle.PrintInfo();
            myCircle.SetRadius(2);
            myCircle.SetDiameter(10);
            myCircle.CalcAndPrintArea();
            Circle circle2 = new Circle(2);
            circle2.PrintInfo();
            circle2.SetDiameter(0);
            circle2.PrintInfo();
            circle2.CalcAndPrintArea();
            circle2.CalcAndPrintCircumference();
        }
    }
}
