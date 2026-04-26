using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static List<Student> students = new List<Student>();
    static int idCounter = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Delete Student");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent();
                    break;

                case 2:
                    ViewStudents();
                    break;

                case 3:
                    DeleteStudent();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        students.Add(new Student { Id = idCounter++, Name = name });

        Console.WriteLine("Student Added!");
    }

    static void ViewStudents()
    {
        Console.WriteLine("\n--- Student List ---");

        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.Id}, Name: {s.Name}");
        }
    }

    static void DeleteStudent()
    {
        Console.Write("Enter ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var student = students.Find(s => s.Id == id);

        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Deleted Successfully!");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }
}