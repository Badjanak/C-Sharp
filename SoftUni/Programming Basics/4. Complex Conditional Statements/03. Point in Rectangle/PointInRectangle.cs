using System;

class PointInRectangle
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

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
