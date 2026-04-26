using System;

partial class Demo
{
    public void Show()
    {
        Console.WriteLine("Part 1");
    }
}

partial class Demo
{
    public void Display()
    {
        Console.WriteLine("Part 2");
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.Show();
        d.Display();
    }
}