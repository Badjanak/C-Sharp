using System;

class RadiansToDegrees
{
    static void Main()
    {
        decimal radians = decimal.Parse(Console.ReadLine());

        decimal degrees = radians * 180 / (decimal)Math.PI;
        int result = (int)degrees;
        Console.WriteLine(result);
    }
}