using System;

struct Student
{
    public int roll;
    public string name;
}

class Program
{
    static void Main()
    {
        Student s1;
        s1.roll = 1;
        s1.name = "shri";

        Console.WriteLine("Roll: " + s1.roll);
        Console.WriteLine("Name: " + s1.name);

        Console.ReadLine();
    }
}