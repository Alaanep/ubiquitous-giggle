using System;
using System.Collections.Generic;

namespace Soccer
{
    class Program
    {
        static void Main(string[] args)
        {
            NormalBall normalBall = new NormalBall("Nike");
            YouthBall youthBall = new YouthBall("Adidas");

            List<IBall> balls = new List<IBall>() { normalBall, youthBall };


            /*In main create both balls. With both of them:
             * Try checking if the ball was inside the goal with 20 random coordinate values 
             * (test also negative ones). Try also the situations where the coordinates are 
             * invalid. After doing that print out how many goals counted and how many did 
             * not count. The sum of them should be 20.
             */

            foreach (IBall ball in balls) { 
                for(int i = 0; i<20; i++)
                {
                    ball.DetermineIfGoalCounted(GenerateRandomCoordinate());
                }
                normalBall.PrintTotalGoalAttempts();

                //Calculate average speed for 10 random coordinates.
                for (int i = 0; i < 10; i++){
                    ball.CalculateAverageSpeedOfBall(GenerateRandomCoordinate(), GenerateRandomCoordinate(), 20);
                }

                //Find kinetic energy for velocity values ranging from 1 to 5.
                for (int i = 1; i <= 5; i++) {
                    ball.CalculateKineticEnergy(i);
                }

                //Create a unique code for both of the balls.
                ball.CreateAndPrintUniqueCode();
            }

        }

        public static double GenerateRandomCoordinate()
        {
            Random random = new Random();
            return random.Next(-55, 55);
        }
    }
}
