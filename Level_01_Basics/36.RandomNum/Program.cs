using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        Console.WriteLine("Random Numbers:");

        for (int i = 1; i <= 5; i++)
        {
            int number = random.Next(1, 101); // Generates number between 1 and 100
            Console.WriteLine(number);
        }

        Console.ReadLine();
    }
}