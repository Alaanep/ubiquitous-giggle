using System;
namespace TargetHeartRateCalculator
{
    public class HeartRate
    {
        private string _firstName;
        private string _lastName;
        private int _yearOfBirth;
        
        //assign firstName, if provided
        public string FirstName {
            get { return _firstName; }
            set { _firstName = value == "" ? "n/a" : value; }
        }
        //assign lastName, if provided
        public string LastName {
            get { return _lastName; }
            set { _lastName = value == "" ? "n/a" : value; }
        }

        //assign yearofBirth
        //if not provided default to 0
        public int YearOfBirth {
            get { return _yearOfBirth; }
            set { _yearOfBirth = value < 1 ? 0 : value;  }
        }

        //current year is set in constructor
        //cannot be set by user

        public readonly int CurrentYear;

        //calculate person age
        public int PersonAge
        {
            get { return CurrentYear - YearOfBirth; }
        }

        //calculate maximum heartrate
        public int MaxHeartRate
        {
            get { return 220 - PersonAge; }
        }

        //calculate minimun target heartrate (50% of the max heart rate
        public int MinTargetHeartRate
        {
            get { return Convert.ToInt32(MaxHeartRate*0.5); }
        }

        //calculate maximum target heart rate(85% of the  max heart rate
        public int MaxTargetHeartRate
        {
            get { return Convert.ToInt32(MaxHeartRate * 0.85); }
        }
        

        public HeartRate(string firstName, string lastName, int yearOfBirth)
        {
            //getting the current year
            CurrentYear = DateTime.Today.Year;

            //assign values passed into constructor
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
        }

    }
}
