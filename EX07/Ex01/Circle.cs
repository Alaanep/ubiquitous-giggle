using System;
namespace Ex01
{
    public class Circle : Shape
    {
    
        public Circle()
        {
            _type = "circle";
        }

        public override void Draw()
        {
            base.Draw();
            
        }

        public void CalculateArea()
        {
            int r = _height / 2;
            Console.WriteLine($"{_type}'s area with height of {_height} is {Math.PI * (r *r)}");
        }


    }
}
