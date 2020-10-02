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
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyEmpWageMap;

        public EmployeeWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void AddCompanyEmpWage(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs)
        {
            CompanyEmpWage companyemployeewage = new CompanyEmpWage(company, empRatePerHr, noOfWorkingDays, maxWorkingHrs);
            this.companyEmpWageList.AddLast(companyemployeewage);
            this.companyEmpWageMap.Add(company, companyemployeewage);
        }
        public void ComputeEmpWage()
        {
            foreach(CompanyEmpWage companyemployeewage in this.companyEmpWageList)
            {
                companyemployeewage.SetTotalEmpWage(this.EmployeeWageComputation(companyemployeewage));
                Console.WriteLine(companyemployeewage.Print());
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
                Console.WriteLine("Working day: " + totalWorkingDays + " Working Hours: " + empHrs + " Daily wage: " + empHrs * empwage.empRatePerHr);
            }
            monthlySalary = totalWorkingHrs * empwage.empRatePerHr;
            return monthlySalary;
        }
        public int getTotalWage(string company)
        {
            return this.companyEmpWageMap[company].totalEmpWage;
        }


    }
}
