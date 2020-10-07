using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComp
{
    class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int CountCompany = 0;
        private readonly EmpWageBuilder[] companyEmpWageArray;
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new EmpWageBuilder[5];
        }
        public void AddCompanyEmpWage(string company, int EMP_RATE_PER_HOUR, int Totalhrs, int Totaldays)
        {
            companyEmpWageArray[this.CountCompany] = new EmpWageBuilder(company, EMP_RATE_PER_HOUR, Totalhrs, Totaldays);
            CountCompany++;
        }
        public void CompEmpWage()
        {
            for (int i = 0; i < CountCompany; i++)
            {
                companyEmpWageArray[i].SetTotalWage(this.CompEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].Save());
            }
        }
        public int CompEmpWage(EmpWageBuilder obj)
        {
            int totalEmpHrs = 0;
            int overallWorkingDays = 0;
            int empHrs;
            Random random = new Random();
            while (totalEmpHrs <= obj.Totalhrs && overallWorkingDays <= obj.Totaldays)
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
            }
            return totalEmpHrs*obj.EMP_RATE_PER_HOUR;
        }
    }
}
