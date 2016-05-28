using System;

class SumSeconds
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int times = first + second + third;
        int minutes = times / 60;
        int seconds = times % 60;

        Console.WriteLine("{0}:{1:00}", minutes, seconds);
    }
}