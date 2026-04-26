using System;

delegate void Show();

class Program
{
    static void Display()
    {
        Console.WriteLine("Delegate called");
    }

    static void Main()
    {
        Show s = Display;
        s();
    }
}