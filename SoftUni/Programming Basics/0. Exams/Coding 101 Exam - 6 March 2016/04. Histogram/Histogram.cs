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
        double percentage = 100 / count;

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
        
        Console.WriteLine($"{p1 * percentage:0.00}\n{p2 * percentage:0.00}\n{p3 * percentage:0.00}\n{p4 * percentage:0.00}\n{p5 * percentage:0.00}");
    }
}
