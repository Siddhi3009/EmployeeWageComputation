using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeWageBuilder : IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private int noOfCompanies = 0;
        public ArrayList CompanyEmpWageList = new ArrayList();
        public void AddCompanyEmpWage(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWage c = new CompanyEmpWage(company, empRatePerHr, noOfWorkingDays, maxWorkingHrs);
            CompanyEmpWageList.Insert(noOfCompanies, c);
            noOfCompanies++;
        }
        public void ComputeEmpWage()
        {
            for (int i = 0; i < noOfCompanies; i++)
            {
                CompanyEmpWage comObj = (CompanyEmpWage) CompanyEmpWageList[i];
                comObj.SetTotalEmpWage(this.EmployeeWageComputation(comObj));
                Console.WriteLine(comObj.Print());
            }
        }
        public int EmployeeWageComputation(CompanyEmpWage empwage)
        {
            int monthlySalary = 0;
            int totalWorkingHrs = 0;
            int totalWorkingDays = 0;
            int empHrs = 0;
            Random random = new Random();
            while (totalWorkingHrs <= empwage.maxWorkingHrs && totalWorkingDays < empwage.noOfWorkingDays)
            {
                totalWorkingDays++;
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
                totalWorkingHrs += empHrs;
                Console.WriteLine("Working day: " + totalWorkingDays + " Working Hours: " + empHrs);
            }
            monthlySalary = totalWorkingHrs * empwage.empRatePerHr;
            return monthlySalary;
        }

    }
}
