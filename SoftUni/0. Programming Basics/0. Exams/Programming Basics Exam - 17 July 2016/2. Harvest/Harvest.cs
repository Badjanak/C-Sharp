using System;

class Harvest
{
    static void Main()
    {
        double vineYardArea = double.Parse(Console.ReadLine());
        double vinesPerSqMeter = double.Parse(Console.ReadLine());
        double wineNeeded = double.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double wineProduced = vineYardArea * 0.4 * vinesPerSqMeter / 2.5;
        double wineLeft = wineProduced - wineNeeded;

        if (wineLeft >= 0)
        {

            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
            Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineLeft / workers)} liters per person.");
        }
        else
        {
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(-wineLeft)} liters wine needed.");
        }
    }
}