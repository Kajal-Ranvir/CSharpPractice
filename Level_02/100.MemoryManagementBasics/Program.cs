using System;

class Program
{
    static void Main()
    {
        object obj = new object();

        Console.WriteLine("Object created.");

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Garbage collection executed.");
    }
}