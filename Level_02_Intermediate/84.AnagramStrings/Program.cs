using System;

class Program
{
    static void Main()
    {
        string str1 = "listen";
        string str2 = "silent";

        char[] a = str1.ToCharArray();
        char[] b = str2.ToCharArray();

        Array.Sort(a);
        Array.Sort(b);

        if(new string(a) == new string(b))
            Console.WriteLine("Anagram");
        else
            Console.WriteLine("Not Anagram");
    }
}