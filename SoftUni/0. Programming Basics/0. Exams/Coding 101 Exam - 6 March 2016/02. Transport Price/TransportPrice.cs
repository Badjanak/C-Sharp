using System;

class TransportPrice
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        string daytime = Console.ReadLine();
        double price = 0;
        double cost = 0;

        if (n >= 100)
        {
            price = 0.06;
        }
        else if (n >= 20)
        {
            price = 0.09;
        }
        else
        {
            cost += 0.7;
            if (daytime.Equals("night"))
            {
                price = 0.9;
            }
            else
            {
                price = 0.79;
            }
        }
        cost += price * n;
        Console.WriteLine(cost);
    }
}