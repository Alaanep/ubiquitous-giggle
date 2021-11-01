using System;
namespace Soccer
{
    public interface IBall
    {
        public void CalculateAverageSpeedOfBall(double startPosition, double finalPosition, int time);
        public void DetermineIfGoalCounted(double ballCoordinate);
        public void PrintTotalGoalAttempts();
        public double CalculateKineticEnergy(double velocity);
        public void CreateAndPrintUniqueCode();
    }
}
