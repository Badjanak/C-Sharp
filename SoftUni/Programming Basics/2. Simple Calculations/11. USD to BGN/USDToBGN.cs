using System;

class USDToBGN
{
    static void Main()
    {
        decimal dollars = decimal.Parse(Console.ReadLine());

        decimal levs = dollars * 1.79549m;
        Console.WriteLine($"{levs:0.##} BGN");
    }
}
