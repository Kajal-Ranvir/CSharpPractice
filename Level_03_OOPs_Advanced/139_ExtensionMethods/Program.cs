using System;

static class Demo
{
    public static void Show(this string s)
    {
        Console.WriteLine(s);
    }
}

class Program
{
    static void Main()
    {
        string str = "Hello";
        str.Show();
    }
}