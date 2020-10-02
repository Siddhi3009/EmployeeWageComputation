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
            EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total employee wage for DMart " + empWageBuilder.getTotalWage("DMart"));
        }
    }
}