using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=.;Database=EFTestDB;Trusted_Connection=True;");
}

class Program
{
    static void Main()
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();

            while (true)
            {
                Console.WriteLine("\n--- EF Core CRUD ---");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. View");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        db.Students.Add(new Student { Name = name });
                        db.SaveChanges();
                        Console.WriteLine("Inserted!");
                        break;

                    case 2:
                        var list = db.Students.ToList();
                        foreach (var s in list)
                            Console.WriteLine($"{s.Id} - {s.Name}");
                        break;

                    case 3:
                        Console.Write("Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        var student = db.Students.Find(id);
                        if (student != null)
                        {
                            db.Students.Remove(student);
                            db.SaveChanges();
                            Console.WriteLine("Deleted!");
                        }
                        else
                        {
                            Console.WriteLine("Not found!");
                        }
                        break;

                    case 4:
                        return;
                }
            }
        }
    }
}