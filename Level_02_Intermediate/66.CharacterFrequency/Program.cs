using System;

class Program
{
    static void Main()
    {
        string str = "hello";

        foreach(char c in str)
        {
            int count = 0;

            foreach(char d in str)
            {
                if(c == d)
                    count++;
            }

            Console.WriteLine(c + " : " + count);
        }
    }
}