using System;

class Program
{
    static void Main()
    {
        int num = 121, temp, rev = 0;
        temp = num;

        while (num > 0)
        {
            int rem = num % 10;
            rev = rev * 10 + rem;
            num /= 10;
        }

        if (temp == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}