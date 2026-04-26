using System;

abstract class A
{
    public abstract void Show();
}

interface IB
{
    void Display();
}

class Demo : A, IB
{
    public override void Show()
    {
        Console.WriteLine("Abstract Method");
    }

    public void Display()
    {
        Console.WriteLine("Interface Method");
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