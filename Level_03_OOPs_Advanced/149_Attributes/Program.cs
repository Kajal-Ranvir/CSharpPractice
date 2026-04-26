using System;

[Obsolete("Old Method")]
class Demo
{
    public void Show()
    {
        Console.WriteLine("Hello");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.Show();
    }
}