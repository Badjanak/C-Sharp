using System;

class Cinema
{
    static void Main()
    {
        string projection = Console.ReadLine().ToLower();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        decimal price = 0;
        switch (projection)
        {
            case "premiere":
                price = 12m;
                break;
            case "normal":
                price = 7.5m;
                break;
            case "discount":
                price = 5m;
                break;

            default:
                Console.WriteLine("error");
                break;
        }

        decimal income = price * rows * cols;
        Console.WriteLine($"{income:0.00}");
    }
}
