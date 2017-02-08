using System;

class AddFifteenMinutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());

        minutes += 15;
        if (minutes > 59)
        {
            minutes %= 60;
            hours++;
        }

        if (hours > 23)
        {
            hours %= 24;
        }

        Console.WriteLine($"{hours}:{minutes:00}");
    }
}
