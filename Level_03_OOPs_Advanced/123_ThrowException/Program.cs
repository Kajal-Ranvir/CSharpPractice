using System;

class Program
{
    static void Check(int age)
    {
        if (age < 18)
            throw new Exception("Not eligible");
    }

    static void Main()
    {
        try
        {
            Check(15);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}