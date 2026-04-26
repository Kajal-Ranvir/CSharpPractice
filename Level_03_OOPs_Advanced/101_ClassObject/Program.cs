using System;

class Student
{
    public string name;

    public void Display()
    {
        Console.WriteLine("Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.name = "Kajal";
        s.Display();
    }
}