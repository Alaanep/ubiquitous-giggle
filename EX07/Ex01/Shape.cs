using System;
namespace Ex01
{
    public class Shape: IShape
    {
        protected string  _type;
        private string _setColor;
        protected int _height;

        public Shape()
        {
            _type = "shape";
        }

        public virtual void Draw()
        {
            Console.WriteLine($"I am a {_type}!");
        }

        public void SetColor(string color)
        {
            _setColor = color;
            Console.WriteLine($"{_setColor} was set to {_type}");
        }

        public void SetHeight(int height)
        {
            _height = height;
            Console.WriteLine($"Height of {_height} was set to {_type}");
        }

        
    }
}
