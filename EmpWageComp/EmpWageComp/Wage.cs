using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EmpWageComp
{
    class Wage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public void CompEmpWage(String Company, int EMP_RATE_PER_HOUR, int Totalhrs, int Totaldays)
        {
            int totalEmpHrs = 0;
            int overallWorkingDays = 0;
            int overallEmpWage = 0;
            int empHrs;
            Random random = new Random();
            while (totalEmpHrs <= Totalhrs && overallWorkingDays <= Totaldays)
            {
                overallWorkingDays++;
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                overallEmpWage += empHrs * EMP_RATE_PER_HOUR;
            }
            Console.WriteLine("Total Employee Wage for " + Company + " : " + overallEmpWage);
        }
        
    }
}
