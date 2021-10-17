using System;
namespace Ex01
{
    public interface IShape
    {
        public void Draw();
        public void SetColor(string color);
        public void SetHeight(int height);
    }
}
