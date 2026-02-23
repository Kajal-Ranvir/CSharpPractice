using System;

namespace CSharp
{
    public class CheckEvenOdd
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine(num + " is even.");
            else
                Console.WriteLine(num + " is odd.");
        }
    }
}