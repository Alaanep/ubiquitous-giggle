using System;
using System.Collections.Generic;

namespace StudentData
{
    public class Student: IStudent
    {
        protected string _name;
        protected int _credits;
        protected List<int> _grades;
        protected string _status;

        public Student(string name)
        {
            _name = name;
            _status = "active";
            _credits = 0;
            _grades = new List<int>();
        }

        public string Status
        {
            get { return _status; }
            set { if (value == "active" || value == "inactive")
                {
                    _status = value;
                }else
                {
                    Console.WriteLine("Invalid value for status");
                }
            }
        }

        public virtual void AddCredits(int credits)
        {
            if (CheckStatus())
            {
                _credits += credits;
                Console.WriteLine($"Credits added. Student has {_credits} credits");
            }
        }

        public void AddGrade(int grade)
        {
            if (CheckStatus()) { 
                if (grade >= 1 && grade <= 5)
                {
                    _grades.Add(grade);
                    if (grade == 5)
                    {
                        Console.WriteLine("Good job!");
                    }
                }
                else
                {
                    Console.WriteLine($"Cannot add the grade, invalid value");
                }
            } 
        }

        public void ConvertToGrade(int percentage)
        {
            if(percentage >=0 && percentage <= 100)
            {
                AddGrade(CalculateGrade(percentage));

            } else
            {
                Console.WriteLine("Cannot find the grade, invalid value");
            }
        }

        protected virtual int CalculateGrade(int percentage)
        {
            int grade = 0;
            if (percentage <= 50)
            {
                grade = 0;
            }
            else if (percentage <= 60)
            {
                grade = 1;
            }
            else if (percentage <= 70)
            {
                grade = 2;
            }
            else if (percentage <= 80)
            {
                grade = 3;
            }
            else if (percentage <= 90)
            {
                grade = 4;
            }
            else if (percentage <= 100)
            {
                grade = 5;
            }
            return grade;
        }

        public void PrintAllGrades()
        {
            if (CheckIfStudentHasGrades())
            {
                Console.Write($"{_name}'s all grades: [");
                for(int i = 0;  i<_grades.Count; i++)
                {
                    if (i == _grades.Count - 1)
                    {
                        Console.Write($"{_grades[i]}");
                    }
                    else
                    {
                        Console.Write($"{_grades[i]}, ");
                    }
                }
                Console.Write("]\n");
            } 
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student's name: {_name}, Credits: {_credits}");
        }

        public void PrintLastGrade()
        {
            if (CheckIfStudentHasGrades())
            {
                Console.WriteLine($"Last grade was: {_grades[_grades.Count-1]}");
            } 
        }

        private bool CheckIfStudentHasGrades()
        {
            if (_grades.Count > 0)
            {
                return true;
            }
            Console.WriteLine($"{_name} doesn't have any grades");
            return false;
            
        }

        protected virtual bool CheckStatus()
        {
            if (_status == "active")
            {
                return true;
            }
            Console.WriteLine($"{_name} status is {_status}. Grades or credits cannot be added");
            return false;
        }

    }
}
