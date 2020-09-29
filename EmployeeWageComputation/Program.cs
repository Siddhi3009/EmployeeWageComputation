using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWageBuilder
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private string company;
        private int noOfWorkingDays;
        private int maxWorkingHrs;
        private int empRatePerHr;

        public EmployeeWageBuilder(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeWageBuilder dmart = new EmployeeWageBuilder("D'Mart", 20, 2, 10);
            Console.WriteLine("Employee wage: " + dmart.EmployeeWageComputation());
            EmployeeWageBuilder reliance = new EmployeeWageBuilder("Reliance", 10, 4, 20);
            Console.WriteLine("Employee wage: " + reliance.EmployeeWageComputation());
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
        public int EmployeeWageComputation()
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
