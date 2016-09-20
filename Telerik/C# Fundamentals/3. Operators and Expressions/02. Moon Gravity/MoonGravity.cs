/*
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
The weight W should be read from the console.
 */

using System;

class MoonGravity
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = weight * 0.17;

        Console.WriteLine("{0:f3}", moonWeight);
    }
}