using System;

class Program
{
    static void PrintNum(int n)
    {
        if(n == 0)
            return;

        Console.WriteLine(n);
        PrintNum(n-1);
    }

    static void Main()
    {
        PrintNum(5);
    }
}