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
            Console.WriteLine("Employee wage: " + EmployeeDailyWageComputation());
        }
        static int EmployeeDailyWageComputation()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            Random random = new Random();
            int empType = random.Next(0, 3);
            if (empType == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else if(empType == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            return empHrs * EMP_RATE_PER_HOUR;
        }
    }
}
