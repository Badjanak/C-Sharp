using System;

class TriangleArea
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal h = decimal.Parse(Console.ReadLine());

        decimal area = a * h / 2m;
        Console.WriteLine("{0:0.00}", area);
    }
}