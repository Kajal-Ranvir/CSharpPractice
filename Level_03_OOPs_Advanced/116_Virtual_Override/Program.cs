using System;

class Base
{
    public virtual void Show()
    {
        Console.WriteLine("Base");
    }
}

class Derived : Base
{
    public override void Show()
    {
        Console.WriteLine("Derived");
    }
}

class Program
{
    static void Main()
    {
        Base b = new Derived();
        b.Show();
    }
}