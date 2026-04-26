using System;

class Demo
{
    public int a = 10;
    private int b = 20;

    public void Show()
    {
        Console.WriteLine(a);
        Console.WriteLine(b);
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