using System;
using System.Linq;

class TrippleSum
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        bool isFound = false;

        for (int a = 0; a < numbers.Length; a++)
        {
            for (int b = a + 1; b < numbers.Length; b++)
            {
                int sum = numbers[a] + numbers[b];
                if (numbers.Contains(sum))
                {
                    Console.WriteLine($"{numbers[a]} + {numbers[b]} == {sum}");
                    isFound = true;
                }
            }
        }
        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }
}