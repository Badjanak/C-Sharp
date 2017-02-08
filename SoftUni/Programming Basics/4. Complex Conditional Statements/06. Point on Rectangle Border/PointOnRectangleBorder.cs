using System;

class PointOnRectangleBorder
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isLyingOnX = (x == x1 || x == x2) && (y1 <= y && y <= y2);
        bool isLyingOnY = (y == y1 || y == y2) && (x1 <= x && x <= x2);
        bool isOnBorder = isLyingOnX || isLyingOnY;

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
