using System;

class MatchTickets
{
    static void Main()
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());

        decimal ticketPrice = 249.99m;
        if (category.Equals("VIP"))
        {
            ticketPrice = 499.99m;
        }

        decimal transport = 0;
        if (1 <= people && people <= 4)
        {
            transport = 0.75m;
        }
        else if (5 <= people && people <= 9)
        {
            transport = 0.6m;
        }
        else if (10 <= people && people <= 24)
        {
            transport = 0.5m;
        }
        else if (25 < people && people <= 49)
        {
            transport = 0.4m;
        }
        else if (people >= 50)
        {
            transport = 0.25m;
        }

        decimal moneyLeft = budget - (budget * transport) - ticketPrice * people;
        if (moneyLeft >= 0)
        {
            Console.WriteLine($"Yes! You have {Math.Round(moneyLeft, 2)} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {Math.Round(-moneyLeft, 2)} leva.");
        }
    }
}