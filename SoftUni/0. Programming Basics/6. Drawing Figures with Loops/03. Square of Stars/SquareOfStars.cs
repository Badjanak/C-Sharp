using System;

class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                if (cols == n - 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write("* ");
                }
            }
        }
    }
}