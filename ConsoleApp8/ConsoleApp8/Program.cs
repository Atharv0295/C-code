using System;

class Program08_CompoundInterest
{
    static void Main()
    {
        double p = 1000;
        double r = 5;
        double t = 2;

        double ci = p * Math.Pow((1 + r / 100), t) - p;

        Console.WriteLine(ci);
    }
}