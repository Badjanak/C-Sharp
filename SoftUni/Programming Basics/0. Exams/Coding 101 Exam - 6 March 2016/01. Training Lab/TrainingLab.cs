using System;

class TrainingLab
{
    static void Main()
    {

        double w = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double rows = Math.Floor(w / 1.2);
        double cols = Math.Floor((h - 1) / 0.7);
        int waste = 3;
    
        double seats = rows * cols - waste;
        Console.WriteLine(seats);
    }
}