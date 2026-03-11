using System;

class CountDigits
{
    static void Main()
    {
        int number, count = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        // If number is 0, it has 1 digit
        if (number == 0)
        {
            count = 1;
        }
        else
        {
            // Make number positive (for negative numbers)
            number = Math.Abs(number);

            while (number > 0)
            {
                number = number / 10;   // Remove last digit
                count++;                // Increase count
            }
        }

        Console.WriteLine("Total digits = " + count);
    }
}