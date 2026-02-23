using System;

namespace CSharp
{
    public class CheckPositiveNegative
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.WriteLine(num + " is positive.");
            else if (num < 0)
                Console.WriteLine(num + " is negative.");
            else
                Console.WriteLine("The number is zero.");
        }
    }
}