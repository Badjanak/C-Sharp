using System;

class SquareArea
{
    static void Main()
    {
        decimal squareSide = decimal.Parse(Console.ReadLine());
        decimal squareArea = squareSide * squareSide;

        Console.WriteLine(squareArea);
    }
}