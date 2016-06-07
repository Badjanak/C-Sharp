using System;

class BonusScore
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());
        decimal score = 0;

        if (number > 1000)
        {
            score = number * 0.1m;
        }
        else if (number > 100)
        {
            score = number * 0.2m;
        }
        else if (number <= 100)
        {
            score += 5;
        }

        if (number % 2 == 0)
        {
            score++;
        }
        if (number % 10 == 5)
        {
            score += 2;
        }

        Console.WriteLine("{0}\n{1}", score, number + score);
    }
}