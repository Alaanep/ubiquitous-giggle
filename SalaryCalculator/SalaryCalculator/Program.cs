/*Develop a C# app that will determine the gross pay for each of three employees. 
 * The company pays straight time for the first 40 hours worked by each employee
 * and time-and-a-half for all hours worked in excess of 40 hours. 
 * You’re given a list of the three employees of the company, 
 * the number of hours each employee worked last week and the hourly rate of each employee. 
 * Your app should input this information for each employee, then should determine and
display the employee’s gross pay. Use the Console class’s ReadLine method to input the data.
*/

using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double pay, hours;
            SalaryCalculator[] employees = new SalaryCalculator [3];

            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Please enter a employee name: ");
                name = Console.ReadLine();

                Console.WriteLine("Please enter employee pay: ");
                pay = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter a employee hours: ");
                hours = Convert.ToDouble(Console.ReadLine());

                employees[i] = new SalaryCalculator(name, pay, hours);
            }
            Console.WriteLine(employees[0]);
            Console.WriteLine(employees[1]);
            Console.WriteLine(employees[2]);




        }
    }
}
