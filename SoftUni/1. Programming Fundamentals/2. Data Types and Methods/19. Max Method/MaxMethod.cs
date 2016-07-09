using System;

class MaxMethod
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int result = GetMax(a, GetMax(b, c));
        Console.WriteLine(result);
    }

    static int GetMax(int first, int second)
    {
        int max;
        if (first >= second)
        {
            max = first;
        }
        else
        {
            max = second;
        }
        return max;
    }
}