using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0} -> {1}", i, IsSpecial(i));
        }
    }

    static bool IsSpecial(int number)
    {
        int digitSum = 0;

        while (number > 0)
        {
            digitSum += number % 10;
            number /= 10;
        }

        bool isSpecial = digitSum == 5 || digitSum == 7 || digitSum == 11;
        return isSpecial;
    }
}