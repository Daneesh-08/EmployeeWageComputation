using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EmpWageComp
{
    class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public int overallEmpWage; 
        private readonly string company;
        private readonly int EMP_RATE_PER_HOUR;
        private readonly int Totalhrs;
        private readonly int Totaldays;
        public EmpWageBuilder(string company, int EMP_RATE_PER_HOUR, int Totalhrs, int Totaldays)
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.Totalhrs = Totalhrs;
            this.Totaldays = Totaldays;
        }
        public void CompEmpWage()
        {
            int totalEmpHrs = 0;
            int overallWorkingDays = 0;
            overallEmpWage = 0;
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
            Console.WriteLine("Total Employee Wage for '" + company + "' : " + overallEmpWage);            
        }
        public string Save()
        {
            Console.WriteLine("\n");
            Console.WriteLine("SAVED !!");
            return ("Total Wage for '" + this.company + "' : " + overallEmpWage);
        }
    }
}
