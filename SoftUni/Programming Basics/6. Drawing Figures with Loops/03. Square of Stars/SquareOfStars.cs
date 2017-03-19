using System;

class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            string starsCount = new string('*', n);
            char[] stars = starsCount.ToCharArray();
            string row = string.Join(" ", stars);
            Console.WriteLine(row);
        }
    }
}
