using System;

class MetricConverter
{
    static void Main()
    {
        const double millimeter = 1000;
        const double centimeter = 100;
        const double meter = 1;
        const double kilometer = 0.001;
        const double inch = 39.3700787;
        const double feet = 3.2808399;
        const double yard = 1.0936133;
        const double mile = 0.000621371192;

        double value = double.Parse(Console.ReadLine());
        string inputUnits = Console.ReadLine();
        string outputUnits = Console.ReadLine();

        double metricUnits = value;
        // Calculate value in meters
        switch (inputUnits)
        {
            case "mm":
                metricUnits /= millimeter;
                break;
            case "cm":
                metricUnits /= centimeter;
                break;
            case "m":
                metricUnits /= meter;
                break;
            case "km":
                metricUnits /= kilometer;
                break;

            case "in":
                metricUnits /= inch;
                break;
            case "ft":
                metricUnits /= feet;
                break;
            case "yd":
                metricUnits /= yard;
                break;
            case "mi":
                metricUnits /= mile;
                break;

            default:
                Console.WriteLine("Unknown measurement units");
                break;
        }
        // Calculate from meters to given units
        switch (outputUnits)
        {
            case "mm":
                metricUnits *= millimeter;
                break;
            case "cm":
                metricUnits *= centimeter;
                break;
            case "m":
                metricUnits *= meter;
                break;
            case "km":
                metricUnits *= kilometer;
                break;

            case "in":
                metricUnits *= inch;
                break;
            case "ft":
                metricUnits *= feet;
                break;
            case "yd":
                metricUnits *= yard;
                break;
            case "mi":
                metricUnits *= mile;
                break;

            default:
                Console.WriteLine("Unknown measurement units");
                break;
        }

        Console.WriteLine($"{metricUnits} {outputUnits}");
    }
}
