using System;
namespace EX01
{
    public class Circle
    {
        //private fields
        private double _radius;
        private double _diameter;

        //default constructor
        public Circle()
        {

        }

        //constructor for setting radius and diameter value
        public Circle(double radius)
        {
            _radius = radius;
            _diameter = radius * 2;
        }

        //print info about radius and diameter
        public void PrintInfo()
        {
            if (_radius <= 0 || _diameter <= 0)
            {
                Console.WriteLine("Values are not set");
            } else
            {
                Console.WriteLine($"Circle radius is {_radius} and circle diameter in {_diameter}");
            } 
        }

        //setting radius - takes radius value as parameter and sets value for radius and diameter.
        //If values are set, info method is called
        public void SetRadius(double radius)
        {
            if (radius > 0)
            {
                _radius = radius;
                _diameter = radius * 2;
                PrintInfo();
            }else
            {
                Console.WriteLine($"Radius should be > 0");
            }
            
        }

        //setting radius - take diameter as parameter and sets value for radius and diameter.
        //If values are set,info method is called
        public void SetDiameter(double diameter)
        {
            if(diameter > 0)
            {
                _radius = diameter / 2;
                _diameter = diameter;
                PrintInfo();
            } else
            {
                Console.WriteLine("Diameter shoulde be > 0");
            }
            
        }

        //calculate and print circle area, round to 2 decimal places
        public void CalcAndPrintArea()
        {
            if (_radius > 0)
            {

                double area = Math.Round(Math.PI * (_radius * _radius), 2);
                Console.WriteLine($"Circle area is {area}");
            } else
            {
                Console.WriteLine($"To calculate area, radius should be >0 ");
            }
        }

        //calculate and print circle circumference, round to 2 decimal places
        public void CalcAndPrintCircumference()
        {
            if (_radius > 0)
            {
                double circumference = 2 * Math.PI * _radius;
                Console.WriteLine($"Circle circumference is {circumference}");
            } else
            {
                Console.WriteLine($"To calculate circumference, radius should be >0 ");
            }
            
        }

    }
}
