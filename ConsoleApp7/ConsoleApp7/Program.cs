using System;

class Program07_SimpleInterest
{
    static void Main()
    {
        double p = 1000;
        double r = 5;
        double t = 2;

        double si = (p * r * t) / 100;

        Console.WriteLine(si);
    }
}