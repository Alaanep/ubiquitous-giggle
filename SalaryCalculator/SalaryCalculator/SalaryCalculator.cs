using System;
namespace SalaryCalculator
{
    public class SalaryCalculator
    {

        
        const int REGULARHOURS = 40;
        const double OVERTIME = 1.5;

        public string EmployeeName { get; set; }
        public double EmployeePay { get; set; }
        public double HoursWorked { get; set; }
        public SalaryCalculator(string name, double pay, double hours)
        {
            EmployeeName = name;
            EmployeePay = pay;
            HoursWorked = hours;
        }

        public double CalculatePay()
        {
            if(HoursWorked<= REGULARHOURS)
            {
                return HoursWorked * EmployeePay;
            }else
            {
                return (REGULARHOURS * EmployeePay) + ((HoursWorked - REGULARHOURS)* (EmployeePay*OVERTIME));
            }
        }

        public override string ToString()
        {
            return string.Format("Employee name: {0}\nEmployee hourly pay: {1:c}\nEmployee hours worked: {2:N}\n +" +
                "Total pay: {3:c}", EmployeeName, EmployeePay, HoursWorked, CalculatePay());
        }
    }
}
