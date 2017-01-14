using System;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int first = 1;
        int second = 1;
        int third = first + second;

        for (int i = 0; i < n; i++)
        {
            first = second;
            second = third;
            third = first + second;
        }
        Console.WriteLine(first);
    }
}