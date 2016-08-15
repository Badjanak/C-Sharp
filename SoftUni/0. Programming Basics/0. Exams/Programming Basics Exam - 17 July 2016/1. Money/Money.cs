using System;

class Money
{
    static void Main()
    {
        int bitCoins = int.Parse(Console.ReadLine());
        double yuan = double.Parse(Console.ReadLine());
        double commission = double.Parse(Console.ReadLine());

        double sum = (bitCoins * 1168 + yuan * 0.15 * 1.76) / 1.95;
        double tax = sum * commission / 100;

        Console.WriteLine(sum - tax);
    }
}