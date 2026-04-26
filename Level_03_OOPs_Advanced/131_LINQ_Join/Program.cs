using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] a = {1,2,3};
        int[] b = {2,3,4};

        var result = a.Join(b, x => x, y => y, (x,y) => x);

        foreach(var i in result)
            Console.WriteLine(i);
    }
}