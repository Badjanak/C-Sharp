using System;

class BonusScore
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());

        double score = 0;
        // Set score in given ranges
        if (number > 1000)
        {
            score = number * 0.1;
        }
        else if (number > 100)
        {
            score = number * 0.2;
        }
        else if (number <= 100)
        {
            score += 5;
        }
        // Additional bonuses
        if (number % 2 == 0)
        {
            score += 1;
        }
        if (number % 10 == 5)
        {
            score += 2;
        }

        Console.WriteLine($"{score}\n{number + score}");
    }
}
