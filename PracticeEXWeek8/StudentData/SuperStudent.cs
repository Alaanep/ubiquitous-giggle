using System;
namespace StudentData
{
    public class SuperStudent : BachelorStudent
    {
        public SuperStudent(string name) : base(name)
        {
            _creditsToGraduate = 200;
            _status = "active";
        }

        public new string Status
        {
            get { return _status; }
            set
            {
                if (value == "active" || value == "inactive" || value == "onhold")
                {
                    _status = value;
                }
                else
                {
                    Console.WriteLine("Invalid value for status");
                }
            }
        }

        public override void AddCredits(int credits)
        {
            if (CheckSuperStudentStatus())
            {
                _credits += credits;
                Console.WriteLine($"Credits added. Student has {_credits} credits");
                if (_grades.Count >= 4)
                {
                    if (_credits >= _creditsToGraduate)
                    {
                        Console.WriteLine($"Congratulations {_name}, you have {_credits} credits, you have graduated with average grade of {GetAverageGrade()}");
                    }
                }
            }
        }

        private double GetAverageGrade()
        {
            double total = 0;
            foreach (int grade in _grades)
            {
                total += grade;
            }
            return total / _grades.Count;
        }

        private bool CheckSuperStudentStatus()
        {
            if (_status == "onhold" || _status=="active")
            {
                return true;
            }
            Console.WriteLine($"{_name} status is {_status}. Grades or credits cannot be added");
            return false;
        }
    }
}
