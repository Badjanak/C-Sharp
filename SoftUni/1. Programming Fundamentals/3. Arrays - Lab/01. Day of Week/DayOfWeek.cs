using System;

class DayOfWeek
{
    static void Main()
    {
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        int n = int.Parse(Console.ReadLine());
        if (n >= 1 && 7 >= n)
        {
            Console.WriteLine(daysOfWeek[n - 1]);
        }
        else
        {
            Console.WriteLine("Invalid Day!");
        }
    }
}