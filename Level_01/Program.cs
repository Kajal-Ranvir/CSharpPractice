using System;

class Program
{
    static void Main()
    {
        double basic, hra, da, total;

        Console.Write("Enter Basic Salary: ");
        basic = Convert.ToDouble(Console.ReadLine());

        hra = basic * 0.20;   // 20% HRA
        da = basic * 0.10;    // 10% DA

        total = basic + hra + da;

        Console.WriteLine("HRA: " + hra);
        Console.WriteLine("DA: " + da);
        Console.WriteLine("Total Salary: " + total);

        Console.ReadLine();
    }
}