using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int holydays = int.Parse(Console.ReadLine());
        int home = int.Parse(Console.ReadLine());

        decimal plays = ((48m - home) * 3m / 4m) + home + (holydays * 2m / 3m);
        if (year.Equals("leap"))
        {
            plays *= 1.15m;
        }

        Console.WriteLine((int)plays);
    }
}