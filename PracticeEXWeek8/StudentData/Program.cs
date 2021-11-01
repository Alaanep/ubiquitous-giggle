using System;
using System.Collections.Generic;

namespace StudentData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IStudent> students = new List<IStudent>();
            Student student = new Student("Arno");
            BachelorStudent bachelorStudent = new BachelorStudent("Alar");
            MasterStudent masterStudent = new MasterStudent("Marja");
            SuperStudent superStudent = new SuperStudent("Genius");

            students.Add(student);
            students.Add(bachelorStudent);
            students.Add(masterStudent);
            students.Add(superStudent);
            foreach (IStudent s in students)
            {
                s.ConvertToGrade(42);
                s.AddGrade(4);
                s.AddGrade(5);
                s.AddGrade(3);
                s.AddGrade(5);
                s.AddGrade(5);
                s.PrintAllGrades();
                s.PrintInfo();
                s.PrintLastGrade();
                s.AddCredits(30);
                s.AddCredits(30);
                s.AddCredits(30);
                s.AddCredits(30);
                s.AddCredits(30);
                s.AddCredits(30);
                s.AddCredits(30);
            }  
        }
    }
}
