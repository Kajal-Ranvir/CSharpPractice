using System;

class Program
{
    static void Main()
    {
        var name = "shri";     // Type decided at compile time
        Console.WriteLine(name);

        dynamic value = 10;   // Type decided at runtime
        Console.WriteLine(value);

        value = "Hello";      // dynamic can change type
        Console.WriteLine(value);

        Console.ReadLine();
    }
}