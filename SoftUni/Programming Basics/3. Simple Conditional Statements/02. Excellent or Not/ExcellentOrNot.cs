using System;

class ExcellentOrNot
{
    static void Main()
    {
        float score = float.Parse(Console.ReadLine());

        bool isExcellent = score >= 5.50;
        if (isExcellent)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}
