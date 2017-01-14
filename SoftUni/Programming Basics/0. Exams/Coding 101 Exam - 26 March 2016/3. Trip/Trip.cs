using System;

class Trip
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        string destination = "";
        int percentage = 0;
        string accommodation = "";
        if (budget <= 100)
        {
            destination = "Bulgaria";
            if (season.Equals("summer"))
            {
                percentage = 30;
                accommodation = "Camp";
            }
            else
            {
                percentage = 70;
                accommodation = "Hotel";
            }
        }
        else if (budget > 100 && budget <= 1000)
        {
            destination = "Balkans";
            if (season.Equals("summer"))
            {
                percentage = 40;
                accommodation = "Camp";
            }
            else
            {
                percentage = 80;
                accommodation = "Hotel";
            }
        }
        else
        {
            destination = "Europe";
            percentage = 90;
            accommodation = "Hotel";
        }

        Console.WriteLine("Somewhere in {0}\n{1} - {2:0.00}", destination, accommodation, budget * percentage / 100);
    }
}