using System;

class PositiveNegative
{
    static void Main()
    {
        int number;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine(number + " is Positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine(number + " is Negative.");
        }
        else
        {
            Console.WriteLine("The number is Zero.");
        }
    }
}