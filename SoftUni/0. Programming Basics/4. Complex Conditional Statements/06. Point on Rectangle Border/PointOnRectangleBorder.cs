using System;

class PointOnRectangleBorder
{
    static void Main()
    {
        decimal x1 = decimal.Parse(Console.ReadLine());
        decimal y1 = decimal.Parse(Console.ReadLine());
        decimal x2 = decimal.Parse(Console.ReadLine());
        decimal y2 = decimal.Parse(Console.ReadLine());
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());

        bool isOnBorder = ((x == x1 || x == x2) && (y1 <= y && y <= y2)) ||
            ((y == y1 || y == y2) && (x1 <= x && x <= x2));

        if (isOnBorder)
        {
            Console.WriteLine("Border");
        }
        else
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}