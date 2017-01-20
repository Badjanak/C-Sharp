using System;

class RectangleArea
{
    static void Main()
    {
        decimal x1 = decimal.Parse(Console.ReadLine());
        decimal y1 = decimal.Parse(Console.ReadLine());
        decimal x2 = decimal.Parse(Console.ReadLine());
        decimal y2 = decimal.Parse(Console.ReadLine());

        decimal a = Math.Abs(x1 - x2);
        decimal b = Math.Abs(y2 - y1);
        decimal perimeter = (a + b) * 2m;
        decimal area = a * b;

        Console.WriteLine($"{area}\n{perimeter}");
    }
}
