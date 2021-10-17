using System;
using System.Collections.Generic;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>() { };
            Shape shape = new Shape();
            Circle circle = new Circle();
            Square square = new Square();
            Triangle triangle = new Triangle();

            shapes.Add(shape);
            shapes.Add(circle);
            shapes.Add(square);
            shapes.Add(triangle);

            foreach( IShape s in shapes)
            {
                s.Draw();
                s.SetColor("Yellow");
                s.SetHeight(15);
            }

            circle.CalculateArea();
            square.CalculateArea();
            triangle.CalculateArea(4);

        }
    }
}
