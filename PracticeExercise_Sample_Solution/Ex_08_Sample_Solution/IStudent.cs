using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_08_Sample_Solution
{
    interface IStudent //all public methods common to all claśses
    {
        void AddCredits(int credit);
        void AddGrade(int grade);
        void ConvertGrade(int percentage);
        void PrintGrades();
        void PrintLastGrade();
        void PrintInfo();
    }
}
