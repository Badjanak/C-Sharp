using System;

class TriangleOf55Stars
{
    static void Main()
    {
        int rows = 10;
        int starsCount = 0;

        for (int row = 0; row <= rows; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write("*");
                starsCount++;
            }
            Console.WriteLine();
        }
        // Console.WriteLine(starsCount);
    }
}