using System;

class CheckPrime
{
    static void Main()
    {
        int num;
        bool isPrime = true;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num <= 1)
        {
            isPrime = false;
        else
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine(num + " is a Prime Number");
        else
            Console.WriteLine(num + " is not a Prime Number");
    }
}