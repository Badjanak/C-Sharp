using System;

class MetricConverter
{
    static void Main()
    {
        decimal millimeter = 1000m;
        decimal centimeter = 100m;
        decimal meter = 1m;
        decimal kilometer = 0.001m;
        decimal inch = 39.3700787m;
        decimal feet = 3.2808399m;
        decimal yard = 1.0936133m;
        decimal mile = 0.000621371192m;

        decimal value = decimal.Parse(Console.ReadLine());
        string inputUnits = Console.ReadLine();
        string outputUnits = Console.ReadLine();

        decimal converted = value;
        // Calculate value to meters
        switch (inputUnits)
        {
            case "m":
                converted /= meter;
                break;
            case "mm":
                converted /= millimeter;
                break;
            case "cm":
                converted /= centimeter;
                break;
            case "mi":
                converted /= mile;
                break;
            case "in":
                converted /= inch;
                break;
            case "km":
                converted /= kilometer;
                break;
            case "ft":
                converted /= feet;
                break;
            case "yd":
                converted /= yard;
                break;

            default:
                Console.WriteLine("Wrong measurement Units");
                break;
        }
        // Calculate from meters to given units
        switch (outputUnits)
        {
            case "m":
                converted *= meter;
                break;
            case "mm":
                converted *= millimeter;
                break;
            case "cm":
                converted *= centimeter;
                break;
            case "mi":
                converted *= mile;
                break;
            case "in":
                converted *= inch;
                break;
            case "km":
                converted *= kilometer;
                break;
            case "ft":
                converted *= feet;
                break;
            case "yd":
                converted *= yard;
                break;

            default:
                Console.WriteLine("Wrong measurement Units");
                break;
        }

        Console.WriteLine("{0} {1}", converted, outputUnits);
    }
}