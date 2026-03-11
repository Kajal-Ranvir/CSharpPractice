using System;

class SwapTwoNum
{
    static void Main()
    {
        int num1, num2, temp;

        Console.Write("Enter First Number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Second Number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Swapping
        temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("After Swapping:");
        Console.WriteLine("First Number: " + num1);
        Console.WriteLine("Second Number: " + num2);
    }
}