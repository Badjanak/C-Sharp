using System;

class NumberTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mid = n / 2;
        if (n % 2 == 1)
        {
            mid++;
        }
        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < n; cols++)
            {
                int num = rows + cols + 1;
                if (num >= n)
                {
                    Console.Write("{0} ", n * 2 - (num));
                }
                else
                {
                    Console.Write("{0} ", num);
                }
            }
            Console.WriteLine();
        }
    }
}