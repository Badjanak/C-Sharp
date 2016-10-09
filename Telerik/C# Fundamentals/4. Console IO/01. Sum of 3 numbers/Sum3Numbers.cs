using System;

class Sum3Numbers
{
    static void Main()
    {
        decimal first = decimal.Parse(Console.ReadLine());
        decimal second = decimal.Parse(Console.ReadLine());
        decimal third = decimal.Parse(Console.ReadLine());

        decimal sum = first + second + third;

        Console.WriteLine(sum);
    }
}