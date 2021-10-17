using System;
namespace Ex01
{
    public class Square : Shape
    {
    
        public Square()
        {
            _type = "square";
        }

        public override void Draw()
        {
            base.Draw();
            
        }

        public void CalculateArea()
        {
            Console.WriteLine($"{_type}'s area with height of {_height} is { _height * _height}");
        }
    }
}
