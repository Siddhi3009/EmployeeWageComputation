using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Employee wage: " + EmployeeMonthlyWageComputation());
        }

        public const int EMP_RATE_PER_HOUR = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int NUM_OF_WORKING_DAYS = 20;
        static int EmployeeMonthlyWageComputation()
        {
            int empHrs = 0;
            int empWage = 0;
            int empCheck = 0;
            int totalWage = 0;
            Random random = new Random();
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                empCheck = random.Next(0, 3);
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
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalWage += empWage;
            }

            return totalWage;
        }
    }
}
