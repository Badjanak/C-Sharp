using System;

class Sum5Numbers
{
    static void Main()
    {
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine(sum);
    }
}