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
        private int noOfCompanies = 0;
        private CompanyEmpWage[] CompanyEmpWageArray;
        public EmployeeWageBuilder()
        {
            this.CompanyEmpWageArray = new CompanyEmpWage[10];
        }
        public void AddCompanyEmpWage(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWageArray[noOfCompanies] = new CompanyEmpWage(company, empRatePerHr, noOfWorkingDays, maxWorkingHrs);
            noOfCompanies++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < noOfCompanies; i++)
            {
                CompanyEmpWageArray[i].SetTotalEmpWage(this.EmployeeWageComputation(this.CompanyEmpWageArray[i]));
                Console.WriteLine(CompanyEmpWageArray[i].Print());
            }
        }
        static int EmployeeHours(int empCheck)
        {
            int empHrs = 0;
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
        public int EmployeeWageComputation(CompanyEmpWage empwage)
        {
            int monthlySalary = 0;
            int totalWorkingHrs = 0;
            int totalWorkingDays = 0;
            Random random = new Random();
            while (totalWorkingHrs <= empwage.maxWorkingHrs && totalWorkingDays < empwage.noOfWorkingDays)
            {
                int empCheck = random.Next(0, 3);
                totalWorkingDays++;
                int empHrs = EmployeeHours(empCheck);
                totalWorkingHrs += empHrs;
                Console.WriteLine("Working day: " + totalWorkingDays + " Working Hours: " + empHrs);
            }
            monthlySalary = totalWorkingHrs * empwage.empRatePerHr;
            return monthlySalary;
        }

    }
}
