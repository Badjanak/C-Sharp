using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int holydays = int.Parse(Console.ReadLine());
        int home = int.Parse(Console.ReadLine());

        decimal sofiaPlays = (48m - home) * 3m / 4m;
        decimal holidayPlays = holydays * 2m / 3m;
        decimal plays = sofiaPlays + home + holidayPlays;

        if (year.Equals("leap"))
        {
            plays = plays * 1.15m;
        }

        Console.WriteLine((int)plays);
    }
}
