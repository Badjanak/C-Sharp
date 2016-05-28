using System;

class InchesToCentimeters
{
    static void Main()
    {
        decimal inches = decimal.Parse(Console.ReadLine());
        decimal centimeters = inches * 2.54m;

        Console.WriteLine(centimeters);
    }
}