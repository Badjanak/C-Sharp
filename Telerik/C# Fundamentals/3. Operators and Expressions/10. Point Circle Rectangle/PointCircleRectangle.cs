/*
 Write a program that reads a pair of coordinates x and y 
 and uses an expression to checks for given point (x, y) 
 if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */

using System;

class PointCircleRectangle
{
    static void Main()
    {
        double raduis = 1.5;

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= raduis);
        bool isOutRectangle = (-1 < x) ^ (x > 5) ^ (-1 <= y) ^ (y > 1);

        Console.WriteLine("{0} {1}", isInCircle ? "inside circle" : "outside circle", isOutRectangle ? "outside rectangle" : "inside rectangle");
    }
}