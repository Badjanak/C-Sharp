using System;

class TriangleOf55Stars
{
    static void Main()
    {
        int rows = 10;
        int starsCount = 0;

        for (int row = 1; row <= rows; row++)
        {
            Console.Write(new string('*', row));
            starsCount += rows;
        }
        // Console.WriteLine(starsCount);
    }
}
