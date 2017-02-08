using System;

class FruitShop
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string day = Console.ReadLine().ToLower();
        decimal quanty = decimal.Parse(Console.ReadLine());

        decimal order = 0;
        bool hasError = false;

        switch (day)
        {
            case "monday":
            case "tuesday":
            case "wednesday":
            case "thursday":
            case "friday":
                switch (product)
                {
                    case "banana":
                        order = 2.5m * quanty;
                        break;
                    case "apple":
                        order = 1.2m * quanty;
                        break;
                    case "orange":
                        order = 0.85m * quanty;
                        break;
                    case "grapefruit":
                        order = 1.45m * quanty;
                        break;
                    case "kiwi":
                        order = 2.7m * quanty;
                        break;
                    case "pineapple":
                        order = 5.5m * quanty;
                        break;
                    case "grapes":
                        order = 3.85m * quanty;
                        break;

                    default:
                        hasError = true;
                        break;
                }
                break;
            case "saturday":
            case "sunday":
                switch (product)
                {
                    case "banana":
                        order = 2.7m * quanty;
                        break;
                    case "apple":
                        order = 1.25m * quanty;
                        break;
                    case "orange":
                        order = 0.9m * quanty;
                        break;
                    case "grapefruit":
                        order = 1.6m * quanty;
                        break;
                    case "kiwi":
                        order = 3m * quanty;
                        break;
                    case "pineapple":
                        order = 5.6m * quanty;
                        break;
                    case "grapes":
                        order = 4.2m * quanty;
                        break;

                    default:
                        hasError = true;
                        break;
                }
                break;
            default:
                hasError = true;
                break;
        }

        if (!hasError)
        {
            Console.WriteLine("{0:0.00}", order);
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}
