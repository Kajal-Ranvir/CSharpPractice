//Program to Check Armstrong Number

using System;

class ArmstrongNum
{
    static void Main()
    {
        int number, originalNum, remainder;
        int sum = 0;

        Console.Write("Enter a number:");
        number = Convert.ToInt32(Console.ReadLine());

        originalNum = number;

        while( number !=0)
        {
            remainder = number % 10;
            sum = sum + (remainder *remainder * remainder);
            number = number / 10;
    
        }

        if (sum ==originalNum)
        Console.WriteLine("It is an Armstrong Number.");
        else
        Console.WriteLine("It is not an Armstrong Number.");
    }
}