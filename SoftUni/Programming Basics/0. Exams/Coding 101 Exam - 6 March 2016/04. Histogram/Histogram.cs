using System;

class Histogram
{
    static void Main()
    {
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int p5 = 0;
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 200)
            {
                p1++;
            }
            else if (n >= 200 && n < 400)
            {
                p2++;
            }
            else if (n >= 400 && n < 600)
            {
                p3++;
            }
            else if (n >= 600 && n < 800)
            {
                p4++;
            }
            else if (n >= 800)
            {
                p5++;
            }
        }
        Console.WriteLine("{0:0.00}\n{1:0.00}\n{2:0.00}\n{3:0.00}\n{4:0.00}",
            (double)p1 * 100 / count, (double)p2 * 100 / count, (double)p3 * 100 / count, (double)p4 * 100 / count, (double)p5 * 100 / count);
    }
}