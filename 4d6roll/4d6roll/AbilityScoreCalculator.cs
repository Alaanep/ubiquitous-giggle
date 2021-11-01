using System;
namespace _4d6roll
{
    public class AbilityScoreCalculator
    {
        public AbilityScoreCalculator()
        {
        }
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            //divide the roll result by the DivideBy
            double divided = RollResult / DivideBy;

            //Add amount to the result of that division
            int added = AddAmount + (int)divided;

            //if the result is too small, use Minimum
            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }
    }
}
