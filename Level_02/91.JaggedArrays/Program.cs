using System;

class Program
{
    static void Main()
    {
        int[][] arr = new int[3][];

        arr[0] = new int[] {1,2};
        arr[1] = new int[] {3,4,5};
        arr[2] = new int[] {6,7};

        foreach(var row in arr)
        {
            foreach(var num in row)
                Console.Write(num + " ");
            Console.WriteLine();
        }
    }
}