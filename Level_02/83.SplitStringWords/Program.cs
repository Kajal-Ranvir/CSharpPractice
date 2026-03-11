using System;

class Program
{
    static void Main()
    {
        string str = "C Sharp Programming Language";

        string[] words = str.Split(' ');

        foreach(string w in words)
            Console.WriteLine(w);
    }
}