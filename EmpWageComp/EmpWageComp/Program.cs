using System;

namespace EmpWageComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manage Employee Wage for Multiple Companies : ");
            Console.WriteLine("\n");            
            EmpWageBuilderArray obj = new EmpWageBuilderArray();
            obj.AddCompanyEmpWage("Jio", 20, 200, 30);
            obj.AddCompanyEmpWage("Airtel", 25, 100, 20);
            obj.CompEmpWage();

        }
    }
}
