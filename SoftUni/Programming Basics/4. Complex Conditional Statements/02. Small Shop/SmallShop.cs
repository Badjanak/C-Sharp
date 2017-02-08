using System;

class SmallShop
{
    static void Main()
    {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        decimal quanty = decimal.Parse(Console.ReadLine());

        decimal order = 0m;
        if (town.Equals("sofia"))
        {
            switch (product.ToLower())
            {
                case "coffee":
                    order = 0.5m * quanty;
                    break;
                case "water":
                    order = 0.8m * quanty;
                    break;
                case "beer":
                    order = 1.2m * quanty;
                    break;
                case "sweets":
                    order = 1.45m * quanty;
                    break;
                case "peanuts":
                    order = 1.6m * quanty;
                    break;

                default:
                    Console.WriteLine("No such product");
                    break;
            }
        }
        else if (town.Equals("plovdiv"))
        {
            switch (product.ToLower())
            {
                case "coffee":
                    order = 0.4m * quanty;
                    break;
                case "water":
                    order = 0.7m * quanty;
                    break;
                case "beer":
                    order = 1.15m * quanty;
                    break;
                case "sweets":
                    order = 1.30m * quanty;
                    break;
                case "peanuts":
                    order = 1.5m * quanty;
                    break;

                default:
                    Console.WriteLine("No such product");
                    break;
            }
        }
        else if (town.Equals("varna"))
        {
            switch (product.ToLower())
            {
                case "coffee":
                    order = 0.45m * quanty;
                    break;
                case "water":
                    order = 0.7m * quanty;
                    break;
                case "beer":
                    order = 1.1m * quanty;
                    break;
                case "sweets":
                    order = 1.35m * quanty;
                    break;
                case "peanuts":
                    order = 1.55m * quanty;
                    break;

                default:
                    Console.WriteLine("No such product");
                    break;
            }
        }
        else
        {
            Console.WriteLine("No store in that town");
        }

        Console.WriteLine(order);
    }
}
