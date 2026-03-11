using System;

class Demo
{
    // Constant variable (must assign value here only)
    const double PI = 3.14;

    // Readonly variable
    readonly int number;

    // Constructor to assign readonly value
    public Demo(int num)
    {
        number = num;
    }

    void Display()
    {
        Console.WriteLine("Constant value PI: " + PI);
        Console.WriteLine("Readonly value number: " + number);
    }

    static void Main()
    {
        Demo obj = new Demo(100);
        obj.Display();
    }
}