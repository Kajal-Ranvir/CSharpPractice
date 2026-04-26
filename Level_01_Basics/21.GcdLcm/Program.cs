
using System;

class GcdLcm
{
    static void Main()
    {
        int num1, num2, gcd, lcm;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        int a = num1;
        int b = num2;

        // Euclidean Algorithm for GCD
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        gcd = a;

        // Formula for LCM
        lcm = (num1 * num2) / gcd;

        Console.WriteLine("GCD = " + gcd);
        Console.WriteLine("LCM = " + lcm);
    }
}