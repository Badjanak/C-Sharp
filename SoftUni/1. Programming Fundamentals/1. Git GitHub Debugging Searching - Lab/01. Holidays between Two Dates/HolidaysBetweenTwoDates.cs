using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string dateFormat = "d.M.yyyy";
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
            dateFormat, CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
            dateFormat, CultureInfo.InvariantCulture);
        int holidaysCount = 0;

        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            // Console.WriteLine(date);
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                // Console.WriteLine(date.DayOfWeek);
                holidaysCount++;
            }
        }

        Console.WriteLine(holidaysCount);
    }
}