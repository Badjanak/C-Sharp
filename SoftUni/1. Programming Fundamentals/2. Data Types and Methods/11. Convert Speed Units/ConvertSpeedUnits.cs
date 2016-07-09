using System;

class ConvertSpeedUnits
{
    static void Main()
    {
        float distance = float.Parse(Console.ReadLine());
        float hours = float.Parse(Console.ReadLine());
        float minutes = float.Parse(Console.ReadLine());
        float seconds = float.Parse(Console.ReadLine());

        float timeHours = hours + minutes / 60f + seconds / 3600f;

        float kmPerHour = (distance / 1000f) / timeHours;
        float metersPerSecond = kmPerHour / 3.6f;
        float milePerHour = (distance / 1609f) / timeHours;

        Console.WriteLine("{0}\n{1}\n{2}", metersPerSecond, kmPerHour, milePerHour);
    }
}