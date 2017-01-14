using System;

class NumberPyramid
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int current = 1;
        for (int row = 1; row <= n; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write("{0} ", current);

                current++;
                if (current > n)
                {
                    return;
                }
            }
            Console.WriteLine();
        }
    }
}