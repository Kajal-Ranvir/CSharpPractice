using System;

class Program
{
    static void Main()
    {
        Func<int,int,int> add = (a,b) => a+b;
        Action<string> print = x => Console.WriteLine(x);
        Predicate<int> isEven = x => x%2==0;

        print(add(2,3).ToString());
        Console.WriteLine(isEven(4));
    }
}