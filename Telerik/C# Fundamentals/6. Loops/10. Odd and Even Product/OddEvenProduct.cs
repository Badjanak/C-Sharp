/*
You are given N integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to N, so the first element is odd, the second is even, etc.
 */

using System;

class OddEvenProduct
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        string nums = Console.ReadLine();
        string[] numbers = nums.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);
        long oddProduct = 1;
        long evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            long currentNumber = long.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                evenProduct *= currentNumber;
            }
            else if (i % 2 != 0)
            {
                oddProduct *= currentNumber;
            }
        }

        bool areProductsEqual = oddProduct == evenProduct;
        Console.WriteLine(areProductsEqual ? "yes {0}" : "no {0} {1}", evenProduct, oddProduct);
    }
}