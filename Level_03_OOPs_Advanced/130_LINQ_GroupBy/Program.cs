using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] names = { "A", "B", "A", "C", "B" };

        var groups = names.GroupBy(x => x);

        foreach (var g in groups)
        {
            Console.WriteLine(g.Key + ": " + g.Count());
        }
    }
}