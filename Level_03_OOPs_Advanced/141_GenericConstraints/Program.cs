using System;

class Demo<T> where T : struct
{
    public void Show(T value)
    {
        Console.WriteLine(value);
    }
}

class Program
{
    static void Main()
    {
        Demo<int> d = new Demo<int>();
        d.Show(10);
    }
}