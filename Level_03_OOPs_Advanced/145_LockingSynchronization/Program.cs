using System;
using System.Threading;

class Program
{
    static object lockObj = new object();

    static void Print()
    {
        lock(lockObj)
        {
            Console.WriteLine("Thread Safe");
        }
    }

    static void Main()
    {
        new Thread(Print).Start();
        new Thread(Print).Start();
    }
}