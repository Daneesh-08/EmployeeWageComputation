using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EmpWageComp
{
    class EmpWageBuilder
    {
        public int overallEmpWage; 
        public string company;
        public int EMP_RATE_PER_HOUR;
        public int Totalhrs;
        public int Totaldays;
        public EmpWageBuilder(string company, int EMP_RATE_PER_HOUR, int Totalhrs, int Totaldays)
        {
            this.company = company;
            this.EMP_RATE_PER_HOUR = EMP_RATE_PER_HOUR;
            this.Totalhrs = Totalhrs;
            this.Totaldays = Totaldays;
        }
        
        public void SetTotalWage(int overallEmpWage)
        {
            this.overallEmpWage = overallEmpWage;
        }
        public string Save()
        {
            return ("Total Wage for '" + this.company + "' : " + this.overallEmpWage);
        }
    }
}
