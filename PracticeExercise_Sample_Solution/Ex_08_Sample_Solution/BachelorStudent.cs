using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ex_08_Sample_Solution
{
    class BachelorStudent : IStudent
    {
        protected int _credits; //how many credits does student have
        protected int _creditsToGraduate; //how many credits does student need for graduating
        protected int _minLevelForGradeOne; //what lower % gives grade 1
        protected List<int> _grades = new List<int>(); //list for storing grades
        protected bool _isActiveStudent;
        private string _name; //field for storing student name; value is given in constructor

        public BachelorStudent(string name)
        {
            //_credits = 0; //initial value for credits is 0, int default value
            _creditsToGraduate = 180; //bachelor value
            _minLevelForGradeOne = 50; //bachelor value
            _isActiveStudent = true;
            _name = name;
        }
        public virtual void AddCredits(int credit)
        {
            _credits += credit; //increase the _credits field value by the amount that the user entered
            Console.WriteLine("BachelorStudent has {0} credits.", _credits);

            //it is important to do this check after you add the credits
            if (_credits >= _creditsToGraduate)
            {
                Console.WriteLine("Congratulations! You have graduated!");
            }
        }

        public virtual void AddGrade(int grade)
        {
            if (_isActiveStudent) //if student is active
            {
                if (grade > 0 && grade < 6) //if grade is between 1-5
                {
                    if (grade == 5) //add message if grade is 5
                    {
                        Console.WriteLine("Good job!");
                    }
                    _grades.Add(grade); //add grade to list!
                }
            }
            else //grade is not between 1 and 5
            {
                Console.WriteLine("Invalid grade value!");
            }
        }

        public void ConvertGrade(int percentage)
        {
            if (percentage >= 0 && percentage <= 100) //percentage is 0-100
            {
                int grade; //local variable for storing grade value found based on %
                if (percentage <= _minLevelForGradeOne) //grade is 0; % is 0 - minLevel
                {
                    grade = 0;
                }
                else if (percentage <= 60) //grade is 1; % is minLevel - 60
                {
                    grade = 1;
                }
                else if (percentage <= 70)  //grade is 2; % is 60 - 70
                {
                    grade = 2;
                }
                else if (percentage <= 80)  //grade is 3; % is 70 - 80
                {
                    grade = 3;
                }
                else if (percentage <= 90)  //grade is 4; % is 80 - 90
                {
                    grade = 4;
                }
                else //grade is 5; % higher than 90
                {
                    grade = 5;
                }
                AddGrade(grade); //we have method for adding grade. this method checks if student is active and if grade is valid. Do not duplicate this, use the existing method!
            }
            else
            {
                Console.WriteLine("Invalid value, cannot find grade!");
            }
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("BachelorStudent {0} has {1} credits", _name, _grades);
        }

        public void PrintGrades()
        {
            if (_grades.Count == 0) //student does not have any grades OR use helper method HasGrades. If we do not check it we get an exception during indexing. 
            {
                Console.WriteLine("No grades");
            }
            else
            {
                Console.WriteLine("Grades are:");
                foreach (int grade in _grades)
                {
                    Console.Write(grade + " ");
                }
                Console.WriteLine();
            }
        }

        public void PrintLastGrade()
        {
            if (_grades.Count == 0) //student does not have any grades  OR use helper method HasGrades. If we do not check it we get an exception during indexing. 
            {
                Console.WriteLine("No last grade");
            }
            else
            {
                int lastGrade = _grades[_grades.Count - 1]; //indexes start from 0 and are always 1 less than count
                Console.WriteLine("Last grade is: " + lastGrade);
            }
        }

        private bool HasGrades() //optional helper method to avoid code duplication
        {
            if (_grades.Count == 0) //student does not have any grades , this could also be bool return type helper method
            {
                Console.WriteLine("No grades");
                return false;
            }
            return true;
        }
    }
}
