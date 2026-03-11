using System;

class Program
{
    static void Main()
    {
        string str = "C sharp programming language";

        string[] words = str.Split(' ');

        Console.WriteLine("Total Words: " + words.Length);
    }
}