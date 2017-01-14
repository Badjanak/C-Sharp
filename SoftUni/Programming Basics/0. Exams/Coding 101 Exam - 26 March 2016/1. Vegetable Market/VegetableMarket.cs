using System;

class VegetableMarket
{
    static void Main()
    {
        double vegetablePrice = double.Parse(Console.ReadLine());
        double fruitPrice = double.Parse(Console.ReadLine());
        double vegetableWeight = double.Parse(Console.ReadLine());
        double fruitWeight = double.Parse(Console.ReadLine());

        double euro = 1.94;
        double income = vegetablePrice * vegetableWeight + fruitPrice * fruitWeight;

        Console.WriteLine(income / euro);
    }
}