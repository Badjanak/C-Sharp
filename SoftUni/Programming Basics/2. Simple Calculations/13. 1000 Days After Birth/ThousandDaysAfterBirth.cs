using System;
using System.Globalization;

class ThousandDaysAfterBirth
{
    static void Main()
    {
        string input = Console.ReadLine();
        string dateFormat = "dd-MM-yyyy";
        CultureInfo culture = CultureInfo.InvariantCulture;

        DateTime birthDate = DateTime.ParseExact(input, dateFormat, culture);

        DateTime afterThousandDays = birthDate.AddDays(999);
        Console.WriteLine($"{afterThousandDays:dd-MM-yyyy}");
    }
}
