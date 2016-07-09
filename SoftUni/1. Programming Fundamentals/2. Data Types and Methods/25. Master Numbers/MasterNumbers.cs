using System;

class MasterNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            if (IsMaster(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPalindrome(int num)
    {
        string number = num.ToString();
        bool isPalindrome = true;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] != number[number.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        return isPalindrome;
    }

    static bool SumDigits(int num)
    {
        int number = num;
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        bool isDivisibleBy7 = sum % 7 == 0;

        return isDivisibleBy7;
    }

    static bool ContainsEvenDigit(int num)
    {
        int number = num;
        bool hasEvenDigit = false;

        while (number > 0)
        {
            int currentDigit = number % 10;
            if (currentDigit % 2 == 0)
            {
                hasEvenDigit = true;
                break;
            }
            number /= 10;
        }

        return hasEvenDigit;
    }

    static bool IsMaster(int n)
    {
        bool isMaster = IsPalindrome(n) && SumDigits(n) && ContainsEvenDigit(n);

        return isMaster;
    }
}