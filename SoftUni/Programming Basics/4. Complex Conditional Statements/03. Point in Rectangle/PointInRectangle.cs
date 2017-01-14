using System;

class PointInRectangle
{
    static void Main()
    {
        decimal x1 = decimal.Parse(Console.ReadLine());
        decimal y1 = decimal.Parse(Console.ReadLine());
        decimal x2 = decimal.Parse(Console.ReadLine());
        decimal y2 = decimal.Parse(Console.ReadLine());
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());

        bool isInsideRectangle = (x1 <= x && x <= x2) && (y1 <= y && y <= y2);
        if (isInsideRectangle)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }
    }
}