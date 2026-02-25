using System;

class PositiveOrNegative
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 0)
            Console.WriteLine("Positive Number");
        else
            Console.WriteLine("Negative Number");
    }
}