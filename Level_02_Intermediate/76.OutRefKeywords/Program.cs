using System;

class Program
{
    static void Calculate(int a, int b, out int sum, ref int product)
    {
        sum = a + b;
        product = a * b;
    }

    static void Main()
    {
        int sum;
        int product = 1;

        Calculate(5, 3, out sum, ref product);

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Product = " + product);
    }
}