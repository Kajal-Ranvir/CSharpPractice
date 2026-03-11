using System;

class OperatorsDemo
{
    static void Main()
    {
        int a = 10;
        int b = 5;

        // 1. Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));
        Console.WriteLine("a % b = " + (a % b));

        // 2. Relational Operators
        Console.WriteLine("\nRelational Operators:");
        Console.WriteLine("a > b = " + (a > b));
        Console.WriteLine("a < b = " + (a < b));
        Console.WriteLine("a == b = " + (a == b));
        Console.WriteLine("a != b = " + (a != b));

        // 3. Logical Operators
        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine("(a > 0 && b > 0) = " + (a > 0 && b > 0));
        Console.WriteLine("(a > 0 || b < 0) = " + (a > 0 || b < 0));
        Console.WriteLine("!(a > b) = " + !(a > b));

        // 4. Assignment Operators
        int c = a;
        Console.WriteLine("\nAssignment Operator:");
        Console.WriteLine("c = " + c);

        // 5. Unary Operators
        Console.WriteLine("\nUnary Operators:");
        Console.WriteLine("++a = " + (++a));
        Console.WriteLine("--b = " + (--b));
    }
}