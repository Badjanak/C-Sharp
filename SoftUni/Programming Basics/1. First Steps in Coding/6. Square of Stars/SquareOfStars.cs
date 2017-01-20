using System;

class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char star = '*';
        char space = ' ';

        for (int col = 1; col <= n; col++)
        {
            for (int row = 1; row <= n; row++)
            {
                if ((row == 1 || row == n) || (col == 1 || col == n))
                {
                    Console.Write(star);
                }
                else
                {
                    Console.Write(space);
                }
            }
            Console.WriteLine();
        }
    }
}
