using System;

class ExcellentOrNot
{
    static void Main()
    {
        decimal score = decimal.Parse(Console.ReadLine());
        if (score >= 5.50m)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}