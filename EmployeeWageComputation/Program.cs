using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Employee wage: " + EmployeeWageComputation("D'Mart", 20, 2, 10));
            Console.WriteLine("Employee wage: " + EmployeeWageComputation("Reliance", 10, 4, 20));

        }
        static int EmployeeHours()
        {
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            return empHrs;

        }
        static int EmployeeWageComputation(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs)
        {
            int monthlySalary = 0;
            int totalWorkingHrs = 0;
            int totalWorkingDays = 0;
            Console.WriteLine("\nCompany: " + company + "\n");
            while (totalWorkingHrs <= maxWorkingHrs && totalWorkingDays < noOfWorkingDays)
            {
                totalWorkingDays++;
                int empHrs = EmployeeHours();
                totalWorkingHrs += empHrs;
                Console.WriteLine("Working day: " + totalWorkingDays + " Working Hours: " + empHrs);
            }
            monthlySalary = totalWorkingHrs * empRatePerHr;
            return monthlySalary;
        }
    }
}
