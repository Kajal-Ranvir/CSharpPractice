using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string str = "Hello@123#World!";

        string result = Regex.Replace(str, "[^a-zA-Z0-9]", "");

        Console.WriteLine(result);
    }
}