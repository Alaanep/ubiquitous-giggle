using System;
namespace BasicMath_LearningUnitTests
{
    public class BasicMaths
    {
        public BasicMaths()
        {
        }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public double Multiply(double num1, double num2)
        {
            //to trace error while testing, writing + operator instead of * operator
            return num1 + num2;
        }
    }
}
