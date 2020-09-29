using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComp
{
    class Wage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public static int CompEmpWage()
        {
            int totalEmpHrs = 0;
            int overallWorkingDays = 0;
            int empHrs;
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && overallWorkingDays <= NUM_OF_WORKING_DAYS)
            {
                overallWorkingDays++;
                Random random = new Random();
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
            }
            int overallEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Emp Wage : " + overallEmpWage);
            return overallEmpWage;
        }
        static void main(string[] args)
        {
            CompEmpWage();
        }
    }
}
