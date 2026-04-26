using System;

delegate void Show();

class Program
{
    static void A() { Console.WriteLine("A"); }
    static void B() { Console.WriteLine("B"); }

    static void Main()
    {
        Show s = A;
        s += B;
        s();
    }
}