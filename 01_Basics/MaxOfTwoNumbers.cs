using System;

namespace CSharp
{
    public class MaxOfTwoNumbers
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int max;

            if (num1 > num2)
                max = num1;
            else
                max = num2;

            Console.WriteLine("\nMaximum of the two numbers is: " + max);
        }
    }
}