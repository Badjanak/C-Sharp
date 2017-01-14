using System;

class RepairingTheTiles
{
    static void Main()
    {
        double playgroundWidth = double.Parse(Console.ReadLine());
        double tileWidth = double.Parse(Console.ReadLine());
        double tileLenght = double.Parse(Console.ReadLine());
        double benchWidth = double.Parse(Console.ReadLine());
        double benchdLenght = double.Parse(Console.ReadLine());

        double area = playgroundWidth * playgroundWidth - benchWidth * benchdLenght;
        double tileArea = tileLenght * tileWidth;

        double tileCount = area / tileArea;
        double time = tileCount * 0.2;

        Console.WriteLine("{0}\n{1}", tileCount, time);
    }
}