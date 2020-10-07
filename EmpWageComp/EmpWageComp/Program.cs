using System;

namespace EmpWageComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage for Multiple Companies : ");
            Console.WriteLine("\n");
            EmpWageBuilder obj1 = new EmpWageBuilder("Jio", 20, 200, 30);
            EmpWageBuilder obj2 = new EmpWageBuilder("Airtel", 25, 100, 20);
            obj1.CompEmpWage();
            obj2.CompEmpWage();
            Console.WriteLine(obj1.Save());
            Console.WriteLine(obj2.Save());
        }
    }
}
