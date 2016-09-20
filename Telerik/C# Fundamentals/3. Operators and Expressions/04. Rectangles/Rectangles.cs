/*
 Write an expression that calculates rectangle’s area and perimeter by given width and height. 
 The width and height should be read from the console.
 */

using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        double perimeter = 2 * (width + height);

        Console.WriteLine("{0:f2} {1:f2}", area, perimeter);
    }
}