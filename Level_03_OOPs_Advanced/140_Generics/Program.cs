using System;

class Demo<T>
{
    public T data;

    public void Show()
    {
        Console.WriteLine(data);
    }
}

class Program
{
    static void Main()
    {
        Demo<int> d = new Demo<int>();
        d.data = 10;
        d.Show();
    }
}