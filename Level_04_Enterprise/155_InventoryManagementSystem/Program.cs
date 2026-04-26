using System;
using System.Collections.Generic;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
}

class Program
{
    static List<Book> books = new List<Book>();
    static int idCounter = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Library Management System ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;

                case 2:
                    ViewBooks();
                    break;

                case 3:
                    DeleteBook();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();

        books.Add(new Book { Id = idCounter++, Title = title });

        Console.WriteLine("Book Added!");
    }

    static void ViewBooks()
    {
        Console.WriteLine("\n--- Book List ---");

        foreach (var b in books)
        {
            Console.WriteLine($"ID: {b.Id}, Title: {b.Title}");
        }
    }

    static void DeleteBook()
    {
        Console.Write("Enter Book ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var book = books.Find(b => b.Id == id);

        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Book Deleted!");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }
}