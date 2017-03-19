using System;

class TriangleOfDollars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            string starsCount = new string('$', i);
            char[] stars = starsCount.ToCharArray();
            string row = string.Join(" ", stars);
            Console.WriteLine(row);
        }
    }
}
