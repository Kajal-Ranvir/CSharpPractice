//Program to Check Palindrome Number

using System;

class PalindromeNum
{
    static void Main()
    {
        int number, originalNum, remainder, reverse = 0;

        Console.Write(" Enter a number:");
        number = Convert.ToInt32(Console.ReadLine());
        originalNum = number;

        while (number != 0)
        {
            remainder = number % 10;
            reverse = reverse * 10 + remainder;
            number = number / 10;
        }
        if (originalNum == reverse)
        Console.WriteLine("It is a Palindrome Number.");
        else
        Console.WriteLine("It is not a Palindrome Number.");
        

    }

  
}