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
            Console.WriteLine("Employee Total Wage: " + EmployeeMaximumMonthlyWageComputation());
        }
        public const int EMP_RATE_PER_HOUR = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_A_MONTH = 100;
        static int EmployeeMaximumMonthlyWageComputation()
        {
            int empHrs = 0;
            int totalHrs = 0;
            int totalDays = 0;
            Random random = new Random();
            while (totalHrs < MAX_HRS_IN_A_MONTH && totalDays < NUM_OF_WORKING_DAYS)
            {
                totalDays++;
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
                totalHrs += empHrs;
            }
            return totalHrs * EMP_RATE_PER_HOUR;
        }
    }
}
