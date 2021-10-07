using System;
namespace EX01
{
    public class Circle
    {
        //private fields
        private double _radius;
        private double _diameter;

        //properties
        //if radius <=0, default to 0
        public double Radius {
            get { return _radius; }
            //set { _radius = value; }
            set { _radius = value <= 0 ? 0: value ; }
        }
        //if diameter <=0, default to 0
        public double Diameter {
            get {return _diameter; }
            set { _diameter = value <= 0 ? 0: value ; }
        }

        //default constructor
        public Circle()
        {

        }

        //constructor for setting radius and diameter value
        public Circle(double radius)
        {
            Radius = radius;
            Diameter = radius * 2;
        }

        //print info about radius and diameter
        public void PrintInfo()
        {
            if (Radius <= 0 || Diameter <= 0)
            {
                Console.WriteLine("Values are not set");
            } else
            {
                Console.WriteLine($"Circle radius is {Radius} and circle diameter in {Diameter}");
            } 
        }

        //setting radius - takes radius value as parameter and sets value for radius and diameter.
        //If values are set, info method is called
        public void SetRadius(double radius)
        {
            if (radius > 0)
            {
                Radius = radius;
                Diameter = radius * 2;
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
                Radius = diameter / 2;
                Diameter = diameter;
                PrintInfo();
            } else
            {
                Console.WriteLine("Diameter shoulde be > 0");
            }
            
        }

        //calculate and print circle area, round to 2 decimal places
        public void CalcAndPrintArea()
        {
            if (Radius > 0)
            {

                double area = Math.Round(Math.PI * (Radius * Radius), 2);
                Console.WriteLine($"Circle area is {area}");
            } else
            {
                Console.WriteLine($"To calculate area, radius should be >0 ");
            }
        }

        //calculate and print circle circumference, round to 2 decimal places
        public void CalcAndPrintCircumference()
        {
            if (Radius > 0)
            {
                double circumference = 2 * Math.PI * Radius;
                Console.WriteLine($"Circle circumference is {circumference}");
            } else
            {
                Console.WriteLine($"To calculate circumference, radius should be >0 ");
            }
            
        }

    }
}
