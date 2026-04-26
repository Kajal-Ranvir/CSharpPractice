using System;

class MyException : Exception
{
    public MyException(string msg) : base(msg) { }
}

class Program
{
    static void Main()
    {
        try
        {
            throw new MyException("Custom Error!");
        }
        catch (MyException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}