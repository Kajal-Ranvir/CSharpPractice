using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter length of rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth of rectangle: ");
        double breadth = Convert.ToDouble(Console.ReadLine());

        double area = length * breadth;

        Console.WriteLine("Area of Rectangle: " + area);
        Console.ReadLine();
    }
}