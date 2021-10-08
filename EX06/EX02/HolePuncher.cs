using System;
namespace EX02
{
    public class HolePuncher
    {

        private int _totalNrHolesPunched;
        private int _holesPunchedSinceLastSharpening;
        private int _needsSharpening;

        //default constructor without parameter. Sets needsSharpening to 5
        public HolePuncher()
        {
            _needsSharpening = 5;
            Console.WriteLine($"We have created a tool that need sharpening after {_needsSharpening} punches");
        }

        //Constructor that take needsSharpening parameter and sets it
        public HolePuncher(int needsSharpening)
        {
            _needsSharpening = needsSharpening;
            Console.WriteLine($"We have created a tool that need sharpening after {_needsSharpening} punches");
        }

        public void PunchHole()
        {

            if (_holesPunchedSinceLastSharpening >= _needsSharpening)
            {
                Console.WriteLine($"Tool needs sharpening. Has punch {_holesPunchedSinceLastSharpening} since last sharpening");
            }
            //increase totalnrHolesPunched by 1
            _totalNrHolesPunched++;
            //increse holesPunched since last sharpening
            _holesPunchedSinceLastSharpening++;
            Console.WriteLine("Punching a hole"); 
        }

        //print info
        public void PrintInfo()
        {
            Console.WriteLine($"Total numbers of used: {_totalNrHolesPunched}, needs sharpening after: {_needsSharpening- _holesPunchedSinceLastSharpening} punches");
        }

        //sharpening
        public void sharpening()
        {
            _holesPunchedSinceLastSharpening = 0;
            Console.WriteLine("Sharpening");
        }

    }
}
