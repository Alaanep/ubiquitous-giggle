using System;
namespace StudentData
{
    public class MasterStudent: BachelorStudent
    {
        private string _studentNr;
        

        public MasterStudent(string name): base(name)
        {
            _creditsToGraduate = 120;
            _studentNr = GenerateStudentNr();
            _name += $", {_studentNr}";
        }

        private string GenerateStudentNr()
        {
            string studentNr = string.Empty;
            Random random = new Random();
            for(int i =0; i<=6; i++)
            {
                studentNr += random.Next(0, 9).ToString();
            }
            return studentNr;
        }

        protected override int CalculateGrade(int percentage)
        {
            if(percentage>=40 && percentage <= 60)
            {
                return 1;
            }
            return base.CalculateGrade(percentage);
        }


    }
}
