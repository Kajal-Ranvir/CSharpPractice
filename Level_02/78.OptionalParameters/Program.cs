using System;

class Program
{
    static void Display(string name, int age = 20)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main()
    {
        Display("Kajal");
        Display("Riya", 25);
    }
}