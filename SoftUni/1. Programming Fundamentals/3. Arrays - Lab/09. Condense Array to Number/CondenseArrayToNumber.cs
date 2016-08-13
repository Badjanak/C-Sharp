using System;
using System.Linq;

class CondenseArrayToNumber
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        if (numbers.Length == 1)
        {
            Console.WriteLine(numbers[0]);
        }
        else
        {
            int[] condensed = new int[numbers.Length - 1];
            int arrayLength = numbers.Length;

            while (arrayLength > 1)
            {
                for (int i = 0; i < arrayLength - 1; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];
                }
                arrayLength--;
                numbers = condensed;
            }

            Console.WriteLine(condensed[0]);
        }
    }
}