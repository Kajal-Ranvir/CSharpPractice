using System;
using Microsoft.VisualBasic;

class DoWhile
{
    static void Main()
    {
        int i = 1;

        do
        {
            Console.WriteLine("Number:" + i);
            i++;
        }
        while (i<=10);
        Console.ReadLine();
    }
}