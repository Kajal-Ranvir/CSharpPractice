using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10, b = 0;
            Console.WriteLine(a / b);
        }
        catch
        {
            Console.WriteLine("Error occurred");
        }
        finally
        {
            Console.WriteLine("Finally block executed");
        }
    }
}