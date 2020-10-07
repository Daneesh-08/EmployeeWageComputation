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
            wage.CompEmpWage("'Jio'", 25, 100, 30);
            wage.CompEmpWage("'Airtel'", 20, 200, 20);           
        }
    }
}
