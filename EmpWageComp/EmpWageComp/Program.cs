using System;

namespace EmpWageComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Wage wage = new Wage();
            Console.WriteLine("Employee Wage for Multiple Companies : ");
            Console.WriteLine("\n");
            Wage.CompEmpWage("'Jio'", 25, 100, 30);
            Wage.CompEmpWage("'Airtel'", 20, 200, 20);
        }
    }
}
