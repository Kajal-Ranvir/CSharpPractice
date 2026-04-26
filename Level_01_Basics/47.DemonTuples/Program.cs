using System;

class Program
{
    static void Main()
    {
        var student = (Roll: 1, Name: "Raj", Marks: 85);

        Console.WriteLine(student.Roll);
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Marks);

        Console.ReadLine();
    }
}
