using System;

namespace CodeRevisionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            BachelorStudent firstStudent = new BachelorStudent("Igor Mahlinovski");

            /*firstStudent.SetActiveStatus();
            firstStudent.AddCredits(40);
            firstStudent.AddCredits(40);
            firstStudent.AddGrade(4);
            firstStudent.AddCredits(100);
            firstStudent.AddGrade(5);
            firstStudent.AddGrade(5);
            firstStudent.AddGrade(3);
            firstStudent.AddGrade(2);
            firstStudent.ConvertGrade(11);
            firstStudent.ConvertGrade(55);
            firstStudent.ConvertGrade(66);
            firstStudent.ConvertGrade(77);
            firstStudent.ConvertGrade(99);
            firstStudent.ConvertGrade(88);
            firstStudent.ConvertGrade(140);
            firstStudent.PrintAllGrades();
            firstStudent.PrintInfo();
            firstStudent.PrintLastGrade();
            firstStudent.SetInactiveStatus();*/

            MasterStudent secondStudent = new MasterStudent("John Bride", 4);

            /*secondStudent.SetActiveStatus();
            secondStudent.AddCredits(30);
            secondStudent.AddCredits(100);
            secondStudent.AddGrade(2);
            secondStudent.AddGrade(5);
            secondStudent.AddGrade(3);
            secondStudent.ConvertGrade(45);
            secondStudent.PrintAllGrades();
            secondStudent.PrintInfo();
            secondStudent.PrintLastGrade();
            secondStudent.SetInactiveStatus();*/

            SuperStudent thirdStudent = new SuperStudent("Jack Hoffil");

            thirdStudent.SetActiveStatus();

            thirdStudent.AddCredits(100);
            thirdStudent.SetOnHold();
            thirdStudent.AddCredits(100);
            thirdStudent.AddGrade(5);
            thirdStudent.ConvertGrade(65);
            thirdStudent.SetActiveStatus();
            thirdStudent.AddGrade(4);
            thirdStudent.AddGrade(3);
            thirdStudent.AddGrade(5);
            thirdStudent.AddGrade(5);
            thirdStudent.AddCredits(20);
            thirdStudent.ConvertGrade(99);
            thirdStudent.ConvertGrade(85);
            thirdStudent.PrintInfo();
            thirdStudent.PrintLastGrade();
            thirdStudent.PrintAllGrades();
            thirdStudent.SetInactiveStatus();
            

        }
    }
}
