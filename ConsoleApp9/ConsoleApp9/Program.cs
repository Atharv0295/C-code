using System;

class Program09_LargestOfThree
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = 7;

        int max = Math.Max(a, Math.Max(b, c));

        Console.WriteLine(max);
    }
}