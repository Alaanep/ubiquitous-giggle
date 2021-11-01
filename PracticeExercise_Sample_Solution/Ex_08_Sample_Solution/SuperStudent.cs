using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex_08_Sample_Solution
{
    class SuperStudent : BachelorStudent
    {
        private bool _isOnHold;

        public SuperStudent(string name) : base(name)
        {
            _isOnHold = false;
            _creditsToGraduate = 200;
        }

        public override void AddCredits(int credits)
        {
            _credits += credits;
            Console.WriteLine("BachelorStudent has {0} credits.", _credits);

            if (_grades.Count >= 4 && _credits >= _creditsToGraduate)
            {
                Console.WriteLine("Congratulations; you graduated");
                double averageGrade = (double)_grades.Sum() / _grades.Count;
                Console.WriteLine("Your average grade: " + averageGrade);
            }
        }

        //override the add grade method. Adding grade should be done ONLY when student is not on hold
        public override void AddGrade(int grade)
        {
            if (!_isOnHold)
            {
                base.AddGrade(grade); //if student is not on hold then call AddGrade method
            }
        }
    }
}
