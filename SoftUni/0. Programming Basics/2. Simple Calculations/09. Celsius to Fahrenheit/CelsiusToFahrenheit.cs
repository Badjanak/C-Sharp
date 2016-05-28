using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        decimal celsius = decimal.Parse(Console.ReadLine());
        decimal fahrenheit = celsius * 1.8m + 32m;

        Console.WriteLine(fahrenheit);
    }
}