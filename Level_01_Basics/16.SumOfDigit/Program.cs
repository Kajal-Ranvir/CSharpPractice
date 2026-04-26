using System;

class SumOfDigits
{
    static void Main()
    {
        int number, sum = 0, remainder;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        while (number != 0)
        {
            remainder = number % 10;   // Get last digit
            sum = sum + remainder;     // Add digit to sum
            number = number / 10;      // Remove last digit
        }

        Console.WriteLine("Sum of digits = " + sum);
    }
}