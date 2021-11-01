using System;
using System.Collections.Generic;
using System.Text;

namespace CodeRevisionTask
{
    interface IStudent
    {
        void SetActiveStatus();
        void SetInactiveStatus();
        void AddCredits(int value);
        void AddGrade(int grade);
        void ConvertGrade(int percentage);
        void PrintInfo();
        void PrintAllGrades();
        void PrintLastGrade();


    }
    class BachelorStudent : IStudent
    {
        protected string studentStatus;
        protected int crebitsBalance;
        protected int lastGrade;
        protected string studentName;
        protected int toGraduate;

        protected List<int> gradeList = new List<int>();

        public BachelorStudent(string fullName)
        {
            studentName = fullName;
            studentStatus = "Inactive";
            crebitsBalance = 0;
            toGraduate = 180;
            
        }
        public virtual void AddCredits(int value)
        {
            if (studentStatus != "Inactive")
            {
                crebitsBalance += value;
                if (crebitsBalance >= toGraduate)
                {
                    Console.WriteLine($"Congradulations, you have {crebitsBalance} credits, you have graduated!");
                }
                else
                {
                    Console.WriteLine($"You have {crebitsBalance} credits");
                }
                
            }            
        }

        public virtual void AddGrade(int grade)
        {
            if (studentStatus != "Inactive")
            {
                if (grade > 0 && grade <= 5)
                {
                    gradeList.Add(grade);
                    lastGrade = grade;
                    if (grade == 5)
                    {
                        Console.WriteLine("Good job!");
                    }
                }
                else
                {
                    Console.WriteLine("Cannot add the grade, invalid value");
                }
            }
            else
            {
                Console.WriteLine($"Change your status!");
                Console.WriteLine($"Current status: {studentStatus}");
            }

        }

        public virtual void ConvertGrade(int percentage)
        {
            if ((studentStatus != "Inactive") && percentage >= 51)
            {
                if (percentage >= 51 && percentage <= 60)
                {
                    AddGrade(1);
                }
                if (percentage >= 61 && percentage <= 70)
                {
                    AddGrade(2);
                }
                if (percentage >= 71 && percentage <= 80)
                {
                    AddGrade(3);
                }
                if (percentage >= 81 && percentage <= 90)
                {
                    AddGrade(4);
                }
                if (percentage >= 91 && percentage <= 100)
                {
                    AddGrade(5);
                }

            }
            else
            {
                if (studentStatus == "Active")
                {
                    CheckGradeForZero(percentage);
                }            
            }

        }

        protected void CheckGradeForZero(int percentage)
        {
           
            if(percentage >= 0 && percentage <= 50)
            {
                //if grade is 0 its not going into gradeList and there is no notification that there is no such grade as 0
            }
            else
            {
                Console.WriteLine("Cannot find the grade, invalid value");
            }
        }

        

        protected bool CheckGradeList()
        {
            if(gradeList.Count == 0)
            {
                Console.WriteLine("Your grade list is empty!");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void SetActiveStatus()
        {
            if (studentStatus == "Active")
            {
                Console.WriteLine("Already ACTIVE!");
            }
            else
            {
                studentStatus = "Active";
                Console.WriteLine("Status has been changed to ACTIVE");
            }
        }

        public void SetInactiveStatus()
        {
            if (studentStatus != "Inactive")
            {
                studentStatus = "Inactive";
                Console.WriteLine("Status has been changed to INACTIVE");
            }
            else
            {
                Console.WriteLine("Already INACTIVE!");
            }
        }

        public virtual void PrintInfo()
        {
                Console.WriteLine($"Name: {studentName}");
                Console.WriteLine($"Credits: {crebitsBalance}");          
        }

        public void PrintAllGrades()
        {
            if (CheckGradeList())
            {
                Console.WriteLine("Grades:");
                foreach(int grade in gradeList)
                {
                    Console.Write($" {grade} ");
                }
                Console.WriteLine();
            }
            
        }

        public void PrintLastGrade()
        {
            if (CheckGradeList())
            {
                Console.WriteLine($"Your last grade was: {lastGrade}");
            }
        }
    }

    class MasterStudent : BachelorStudent
    {
        private int _masterStudentNumm;
        public MasterStudent(string fullName, int masterStudentNum) : base(fullName)
        {
            toGraduate = 120;
            _masterStudentNumm = masterStudentNum;
        }
        public override void ConvertGrade(int percentage)
        {
            base.ConvertGrade(percentage);
            if ((studentStatus != "Inactive") && (percentage >= 41 && percentage <= 50))
            {
                AddGrade(1);
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Master student number: {_masterStudentNumm}");
            Console.WriteLine($"Credits: {crebitsBalance}");
        }
    }

    class SuperStudent : BachelorStudent
    {
        public SuperStudent(string fullName) : base(fullName)
        {
            toGraduate = 200;
        }
        public override void AddCredits(int value)
        {
            if (studentStatus != "Inactive")
            {
                crebitsBalance += value;
                if (crebitsBalance >= toGraduate && gradeList.Count >= 4)
                {
                    Console.WriteLine($"Congradulations, you have {crebitsBalance} credits, you have graduated!");
                    CalculateAverageGrade();
                }
                else
                {
                    Console.WriteLine($"You have {crebitsBalance} credits");
                }

            }
        }

        public override void AddGrade(int grade)
        {
            if (studentStatus != "On hold" && studentStatus != "Inactive")
            {

                if (grade > 0 && grade <= 5)
                {
                    gradeList.Add(grade);
                    lastGrade = grade;
                    if (grade == 5)
                    {
                        Console.WriteLine("Good job!");
                    }
                }
                else
                {
                    Console.WriteLine("Cannot add the grade, invalid value");
                }

            }
            else
            {
                Console.WriteLine($"Change your status!");
                Console.WriteLine($"Current status: {studentStatus}");
            }
        }

        protected void CalculateAverageGrade()
        {
            int sum = 0;
            foreach(int grade in gradeList)
            {
                sum += grade;
            }
            Console.WriteLine($"Average mark: {sum/gradeList.Count}");

        }

        public void SetOnHold()
        {
            if (studentStatus != "On hold")
            {
                studentStatus = "On hold";
            }
            else
            {
                Console.WriteLine("Already on hold");
            }
        }

    }
}
