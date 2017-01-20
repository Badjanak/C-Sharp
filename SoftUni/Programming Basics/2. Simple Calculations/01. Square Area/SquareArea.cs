using System;

class SquareArea
{
    static void Main()
    {
        double squareSide = double.Parse(Console.ReadLine());

        double squareArea = squareSide * squareSide;
        Console.WriteLine(squareArea);
    }
}
