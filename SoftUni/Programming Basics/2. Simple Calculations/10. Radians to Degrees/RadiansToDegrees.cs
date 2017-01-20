using System;

class RadiansToDegrees
{
    static void Main()
    {
        double radians = double.Parse(Console.ReadLine());

        double degrees = radians * 180 / Math.PI;
        int result = (int)degrees;
        Console.WriteLine(result);
    }
}
