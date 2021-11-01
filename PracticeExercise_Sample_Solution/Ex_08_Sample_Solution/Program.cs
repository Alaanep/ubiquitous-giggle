using System;

namespace Ex_08_Sample_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
           BachelorStudent mari = new BachelorStudent("Mari");
           mari.AddGrade(5); //5
           mari.AddGrade(6); //invalid
           mari.ConvertGrade(60); //1
           mari.ConvertGrade(40); //0
           mari.ConvertGrade(80); //3
           mari.PrintGrades();

           mari.AddCredits(50);
           mari.AddCredits(130); //should graduate


           MasterStudent ms = new MasterStudent("Toomas", "123a");
           ms.AddCredits(40);
           ms.AddCredits(100); //should graduate

           SuperStudent ss = new SuperStudent("Jüri");
           ss.AddCredits(300); //not enough grades to graduate
           ss.AddGrade(4);
           ss.AddGrade(1);
           ss.AddGrade(2);
           ss.AddGrade(4);
           ss.AddCredits(10); //graduates
        }
    }
}
