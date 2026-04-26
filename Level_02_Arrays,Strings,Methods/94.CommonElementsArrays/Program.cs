using System;

class Program
{
    static void Main()
    {
        int[] a = {1,2,3,4};
        int[] b = {3,4,5,6};

        Console.WriteLine("Common elements:");

        foreach(int x in a)
        {
            foreach(int y in b)
            {
                if(x == y)
                    Console.WriteLine(x);
            }
        }
    }
}