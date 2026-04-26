using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Break Example:");
        
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                break;   // Stops the loop when i = 5
            }
            Console.WriteLine(i);
        }

        Console.WriteLine("\nContinue Example:");

        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                continue;   // Skips number 5
            }
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}