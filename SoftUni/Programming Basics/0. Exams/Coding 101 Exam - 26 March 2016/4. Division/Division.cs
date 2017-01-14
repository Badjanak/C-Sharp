using System;

class Division
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());

        int countTwo = 0;
        int countThree = 0;
        int countFour = 0;

        for (int i = 0; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (current % 2 == 0)
            {
                countTwo++;
            }
            if (current % 3 == 0)
            {
                countThree++;
            }
            if (current % 4 == 0)
            {
                countFour++;
            }
        }

        Console.WriteLine("{0:0.00}%\n{1:0.00}%\n{2:0.00}%", countTwo / n * 100, countThree / n * 100, countFour / n * 100);
    }
}