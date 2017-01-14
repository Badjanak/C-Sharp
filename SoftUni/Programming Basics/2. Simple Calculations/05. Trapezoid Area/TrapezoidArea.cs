using System;

class TrapezoidArea
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal h = decimal.Parse(Console.ReadLine());

        decimal area = (a + b) * h / 2m;
        Console.WriteLine(area);
    }
}