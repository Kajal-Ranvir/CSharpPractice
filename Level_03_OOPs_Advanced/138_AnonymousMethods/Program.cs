using System;

delegate void Show();

class Program
{
    static void Main()
    {
        Show s = delegate() { Console.WriteLine("Anonymous Method"); };
        s();
    }
}