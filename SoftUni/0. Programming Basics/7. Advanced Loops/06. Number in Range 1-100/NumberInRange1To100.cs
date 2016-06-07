using System;

class NumberInRange1To100
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        while (1 > n || n > 100)
        {
            Console.WriteLine("Invalid number!");
            n = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(n);
    }
}