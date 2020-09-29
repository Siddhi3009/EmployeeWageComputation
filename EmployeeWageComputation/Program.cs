using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int EMP_RATE_PER_HOUR = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int MAXIMUM_WORKING_DAYS = 20;
        public const int MAXIMUM_WORKING_HOURS = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Employee wage: " + EmployeeWageComputation());
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
        static int EmployeeWageComputation()
        {
            int monthlySalary = 0;
            int totalWorkingHrs = 0;
            int totalWorkingDays = 0;
            while (totalWorkingHrs <= MAXIMUM_WORKING_HOURS && totalWorkingDays < MAXIMUM_WORKING_DAYS)
            {
                totalWorkingDays++;
                int empHrs = EmployeeHours();
                totalWorkingHrs += empHrs;
                Console.WriteLine("Working day: " + totalWorkingDays + "Working Hours: " + empHrs);
            }
            monthlySalary = totalWorkingHrs * EMP_RATE_PER_HOUR;
            return monthlySalary;
        }
    }
}
