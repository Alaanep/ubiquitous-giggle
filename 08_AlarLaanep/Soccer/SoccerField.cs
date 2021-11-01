using System;
namespace Soccer
{
    public class SoccerField    
    {

        private int _left;
        private int _right;
        private double _goalDepth;

        public SoccerField(double goalDepth)
        {
            _left = -45;
            _right = 45;
            _goalDepth = goalDepth;
        }

        public int Left { get { return _left; } private set { _left = value; } }
        public int Right { get { return _right; } private set { _right = value; } }
        public double GoalDepth { get { return _goalDepth; } private set { _goalDepth = value; } }


    }
}
