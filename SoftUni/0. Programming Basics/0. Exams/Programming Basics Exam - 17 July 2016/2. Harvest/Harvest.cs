using System;

class Harvest
{
    static void Main()
    {
        int vineYardArea = int.Parse(Console.ReadLine());
        double vine = double.Parse(Console.ReadLine());
        int wineNeeded = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());

        double wineProduced = vineYardArea * 40 / 100 * vine / 2.5;
        if (wineProduced >= wineNeeded)
        {
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
            Console.WriteLine($"{(int)wineProduced - (int)wineNeeded} liters left -> {Math.Ceiling((wineProduced - wineNeeded) / workers)} liters per person.");
        }
        else
        {
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded - wineProduced)} liters wine needed.");
        }
    }
}