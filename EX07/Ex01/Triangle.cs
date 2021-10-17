using System;
namespace Ex01
{
    public class Triangle: Shape
    {
        
        public Triangle()
        {
            _type = "triangle";
        }

        public override void Draw()
        {
            base.Draw();
            
        }

        public void CalculateArea(int alus)
        {
            
            double area = (alus * _height) / 2; 
            Console.WriteLine($"{_type}'s area with height of {_height} and alus of {alus} is { area}");
        }


    }
}
