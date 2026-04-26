using System;

class Program
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;

            int result = a / b; // This will cause division by zero exception
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed");
        }
        finally
        {
            Console.WriteLine("Program execution completed");
        }
    }
}