using System;

class CompoundInterest
{
    static void Main()
    {
        Console.Write("Enter Principal: ");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate: ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time: ");
        double t = Convert.ToDouble(Console.ReadLine());

        double amount = p * Math.Pow((1 + r / 100), t);
        double ci = amount - p;

        Console.WriteLine("Compound Interest = " + ci);
    }
}