using System;
namespace Soccer
{
    public class YouthBall: NormalBall
    {
        public YouthBall(string name): base(name)
        {
            _diameter = 0.56; //meters
            _weight = 0.38;//kg
            _goalDepth = 1.4;//meters
            _lettersToTake = 3;
            _nrOfRandomNumbers = 3;
        }
    }
}
