/*
 Write a program that reads your birthday(in the format MM.DD.YYYY) from the console 
 and prints on the console how old you are you now and how old will you be after 10 years.
 */

using System;

class Age
{
    static void Main()
    {
        string input = Console.ReadLine();

        DateTime birthDate = DateTime.Parse(input);
        DateTime now = DateTime.Now;

        TimeSpan lifeSpan = now - birthDate;
        DateTime age = new DateTime(1, 1, 1);
        age += lifeSpan;

        int years = age.Year - 1;
        int months = age.Month - 1;
        int days = age.Day - 1;
        DateTime afterTen = age.AddYears(10 - 1);

        Console.WriteLine($"{years}" /*, {months}, {days} */ );
        Console.WriteLine($"{afterTen.Year}");
    }
}

// http://bgcoder.com/Contests/Practice/Index/314#4