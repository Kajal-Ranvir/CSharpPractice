using System;

class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Kajal";
        Console.WriteLine(p.Name);
    }
}