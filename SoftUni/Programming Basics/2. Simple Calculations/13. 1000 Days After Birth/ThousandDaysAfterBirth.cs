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

        Console.WriteLine("{0:dd-MM-yyyy}", birthDate.AddDays(999));
    }
}