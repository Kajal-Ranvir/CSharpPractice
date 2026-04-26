using System;
using System.Data.SqlClient;

class Program
{
    static string connectionString = 
        "Server=localhost;Database=TestDB;Trusted_Connection=True;";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- ADO.NET CRUD ---");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. View");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Add(); break;
                case 2: View(); break;
                case 3: Delete(); break;
                case 4: return;
            }
        }
    }

    static void Add()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            string query = "INSERT INTO Students(Name) VALUES(@name)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Inserted!");
        }
    }

    static void View()
    {
        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            string query = "SELECT * FROM Students";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine($"{reader["Id"]} - {reader["Name"]}");
            }
        }
    }

    static void Delete()
    {
        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();
            string query = "DELETE FROM Students WHERE Id=@id";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Deleted!");
        }
    }
}