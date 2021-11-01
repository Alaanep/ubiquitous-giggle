using System;
namespace StudentData
{
    public interface IStudent
    {
        public void AddCredits(int credits);
        public void AddGrade(int grade);
        public void ConvertToGrade(int percentage);
        public void PrintAllGrades();
        public void PrintInfo();
        public void PrintLastGrade();
    }
}
