using System;
namespace StudentData
{
    public class BachelorStudent: Student
    {
        protected int _creditsToGraduate;
        public BachelorStudent(string name): base(name)
        {
            _creditsToGraduate = 180;
        }

        public override void AddCredits(int credits)
        {
            base.AddCredits(credits);
            if (_credits >= _creditsToGraduate)
            {
                Console.WriteLine($"Congratulations {_name}, you have {_credits} credits, you have graduated!");
            }
        }

       
    }
}
