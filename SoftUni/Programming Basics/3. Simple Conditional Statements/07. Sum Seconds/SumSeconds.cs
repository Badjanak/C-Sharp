using System;

class SumSeconds
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int times = first + second + third;

        int min = 60;
        int minutes = times / min;
        int seconds = times % min;

        Console.WriteLine($"{minutes}:{seconds:00}");
    }
}
