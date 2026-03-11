using System;

class Program
{
    static void Main()
    {
        int? number = null;   // Nullable integer

        if (number.HasValue)
            Console.WriteLine("Value: " + number.Value);
        else
            Console.WriteLine("Value is Null");

        number = 10;

        Console.WriteLine("Now Value: " + number);

        Console.ReadLine();
    }
}