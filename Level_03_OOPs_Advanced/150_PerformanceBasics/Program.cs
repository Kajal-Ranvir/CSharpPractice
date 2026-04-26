using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        for(int i=0;i<100000;i++){}

        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
}