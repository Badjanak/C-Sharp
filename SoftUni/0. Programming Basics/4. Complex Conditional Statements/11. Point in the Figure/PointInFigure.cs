using System;

class PointInFigure
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        bool isInside = ((0 < x && x < 3 * size) && (0 < y && y < 1 * size)) ||
           ((1 * size < x && x < 2 * size) && (1 * size < y && y < 4 * size));

        bool isOutside = ((0 > x || x > 3 * size) || (0 > y || y > 1 * size)) &&
            ((1 * size > x || x > 2 * size) || (1 * size > y || y > 4 * size));

        bool isOnCommon = (1 * size < x && x < 2 * size) && (y == 1 * size);

        if (isInside || isOnCommon)
        {
            Console.WriteLine("inside");
        }
        else if (isOutside)
        {
            Console.WriteLine("outside");
        }
        else
        {
            Console.WriteLine("border");
        }
    }
}