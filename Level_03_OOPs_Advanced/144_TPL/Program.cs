using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Task.Run(() => Console.WriteLine("Task Running")).Wait();
    }
}