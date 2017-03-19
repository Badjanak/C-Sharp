using System;

class SmartLilly
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        int toyPrice = int.Parse(Console.ReadLine());

        int toyCount = 0;
        int money = 0;
        int moneyGiven = 10;
        for (int i = 1; i <= age; i++)
        {
            if (i % 2 != 0)
            {
                toyCount++;
            }
            else
            {
                money += moneyGiven - 1;
                moneyGiven += 10;
            }
        }
        double sum = toyCount * toyPrice + money;

        Console.WriteLine("{0} {1:0.00}", sum >= price 
            ? "Yes!" 
            : "No!", Math.Abs(sum - price));
    }
}