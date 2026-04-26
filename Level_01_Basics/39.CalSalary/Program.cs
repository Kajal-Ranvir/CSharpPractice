using System;

class SalaryCalculation
{
    static void Main()
    {
        double basic, hra, da, ta, grossSalary;

        Console.Write("Enter Basic Salary: ");
        basic = Convert.ToDouble(Console.ReadLine());

        // Calculate allowances
        hra = basic * 0.20;   // 20% HRA
        da  = basic * 0.10;   // 10% DA
        ta  = basic * 0.05;   // 5% TA

        grossSalary = basic + hra + da + ta;

        Console.WriteLine("\n---- Salary Details ----");
        Console.WriteLine("Basic Salary: " + basic);
        Console.WriteLine("HRA (20%): " + hra);
        Console.WriteLine("DA (10%): " + da);
        Console.WriteLine("TA (5%): " + ta);
        Console.WriteLine("Gross Salary: " + grossSalary);
    }
}