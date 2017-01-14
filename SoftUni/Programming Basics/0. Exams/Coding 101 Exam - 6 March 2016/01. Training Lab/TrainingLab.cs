using System;

class TrainingLab
{
    static void Main()
    {
        double w = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double seats = ((int)(w / 1.2)) * ((int)((h - 1) / 0.7)) - 3;
        Console.WriteLine(seats);
    }
}