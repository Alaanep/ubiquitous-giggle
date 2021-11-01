using System;
namespace Soccer
{
    public class NormalBall: IBall
    {
        SoccerField soccerField;
        protected double  _diameter;
        protected double _weight;
        protected double _ballCoordinate;
        protected double _ballRadius;
        protected int _goalAttempt;
        protected int _goals;
        protected int _missedGoal;
        protected string _name;
        protected double _goalDepth;
        protected string _uniqueCode;
        protected int _lettersToTake; //for unique code
        protected int _nrOfRandomNumbers; //for unique code

        public NormalBall(string sponsorName)
        {
            _name = sponsorName;
            _diameter = 0.70; //meters
            _weight = 0.45;//kg
            _ballRadius = _diameter / 2;
            _goalAttempt = 0;
            _goals = 0;
            _goalDepth = 1.7;//meters
            soccerField = new SoccerField(_goalDepth);
            _lettersToTake = 4;
            _nrOfRandomNumbers = 5;
        }

        public void CalculateAverageSpeedOfBall(double startPosition, double finalPosition, int time)
        {
            startPosition = ValideCoordinate(startPosition);
            finalPosition = ValideCoordinate(finalPosition);
            double averageSpeed =  Math.Abs((Convert.ToDouble(finalPosition - startPosition) / time));
            Console.WriteLine($"Ball {_name} Average speed is: {averageSpeed}");
        }

        public void DetermineIfGoalCounted(double ballCoordinate)
        {
            _ballCoordinate = ValideCoordinate(ballCoordinate);
            _goalAttempt++;
            //right side of soccerfield
            if ((_ballCoordinate - _ballRadius) >= 0)
            {
                //if ball is fully in goal, its a goal
                if ((_ballCoordinate - _ballRadius) >= (soccerField.Right - soccerField.GoalDepth))
                {
                    _goals++;
                    Console.WriteLine($"Ball {_name} hit the goal with coordinate: {_ballCoordinate}");
                } else
                {
                    _missedGoal++;
                    Console.WriteLine($"Ball {_name} Missed with coordinate: {_ballCoordinate}");
                }
                //left side of soccerfield
            }
            else if (_ballCoordinate - _ballRadius < 0)
            {
                //if ball is fully in goal, its a goal
                if ((_ballCoordinate + _ballRadius) <= (soccerField.Left + soccerField.GoalDepth))
                {
                    _goals++;
                    Console.WriteLine($"Ball {_name} hit the goal with coordinate: {_ballCoordinate}");
                } else
                {
                    _missedGoal++;
                    Console.WriteLine($"Ball {_name} Missed with coordinate: {_ballCoordinate}");
                }
            } 
        }

        //valide input coordinate
        private double ValideCoordinate(double coordinate)
        {
            double coordinateToValidate = coordinate;
            if (coordinateToValidate < -45)
            {
                Console.WriteLine($"Invalid coordinate {coordinate}. Coordinate needs to be between -45 and 45. Defaulted to 0");
                coordinateToValidate = 0;
            } else if(coordinateToValidate > 45)
            {
                Console.WriteLine($"Invalid coordinate {coordinate}. Coordinate needs to be between -45 and 45. Defaulted to 0");
                coordinateToValidate = 0;
            } else
            {
                coordinateToValidate = coordinate;
            }
            return coordinateToValidate;
        }

        //find total number of goal attempts, separate the ones that counted and the ones did not count
        public void PrintTotalGoalAttempts()
        {
            Console.WriteLine($"Goals Scored: {_goals}, total missed: {_missedGoal},  Total Goal Attempts: {_goalAttempt}");
        }

        public double CalculateKineticEnergy(double velocity) {
            double calculatedKineticEnergy = 0.5 * _weight * Math.Pow(velocity, 2);
            Console.WriteLine($"You hit the ball {_name} with {calculatedKineticEnergy}J");
            return calculatedKineticEnergy;
        }

        public void CreateAndPrintUniqueCode()
        {
            GenerateFirstLetters();
            GenerateRandomNumbers();
            Console.WriteLine($"Balls {_name} unique code is: {_uniqueCode}");
        }

        private void GenerateRandomNumbers()
        {
            Random random = new Random();
            for(int i=0; i<_nrOfRandomNumbers; i++)
            {
                _uniqueCode += random.Next(0, 9).ToString();
            }
        }

        private void GenerateFirstLetters()
        {
            if (_name.Length >= _lettersToTake)
            {
                _uniqueCode += _name.Substring(0, _lettersToTake);
            } else if (_name.Length == 0)
            {
                _uniqueCode += "ball";
            } else
            {
                _uniqueCode += _name.Substring(0, _name.Length);
            }
        }
    }
}
