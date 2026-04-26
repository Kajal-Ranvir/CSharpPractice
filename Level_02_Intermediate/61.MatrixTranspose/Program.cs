using System;

class Program
{
    static void Main()
    {
        int[,] matrix = { {1,2,3}, {4,5,6} };

        Console.WriteLine("Transpose Matrix:");

        for(int i=0;i<3;i++)
        {
            for(int j=0;j<2;j++)
            {
                Console.Write(matrix[j,i] + " ");
            }
            Console.WriteLine();
        }
    }
}
