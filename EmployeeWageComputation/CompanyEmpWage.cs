using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class CompanyEmpWage
    {
        public string company;
        public int noOfWorkingDays;
        public int maxWorkingHrs;
        public int empRatePerHr;
        public int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHr, int noOfWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.noOfWorkingDays = noOfWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string Print()
        {
            return "Total employee wage for company " + this.company + " is " + this.totalEmpWage;
        }
    }
}
