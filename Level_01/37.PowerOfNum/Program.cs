using System;

class Program
{
    static void Main()
    {
        int number = 2;
        int power = 3;
        int result = 1;

        for (int i = 1; i <= power; i++)
        {
            result = result * number;
        }

        Console.WriteLine("Result: " + result);
        Console.ReadLine();
    }
}