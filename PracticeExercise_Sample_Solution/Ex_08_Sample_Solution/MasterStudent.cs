using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_08_Sample_Solution
{
    class MasterStudent : BachelorStudent
    {
        protected string _masterNr;


        //we only have constructor with string parameter in base (BachelorStudent) class
        //thereby we have to specify that we want to use this constructor and pass the parameter
        //if in main method is MasterStudent("Jüri") -> BachelorStudent("Jüri") is called (parameter value "Jüri" is passed to base constructor)
        public MasterStudent(string name, string masterNr) : base(name)
        {
            _creditsToGraduate = 120; //master student value
            _minLevelForGradeOne = 40; //master student value
            _masterNr = masterNr;
        }

        //this is not required by the task, just an example
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Master student nr is {0}", _masterNr);
        }
    }
}
