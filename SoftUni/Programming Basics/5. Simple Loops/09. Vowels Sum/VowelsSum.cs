using System;

class VowelsSum
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            if (currentChar.Equals('a'))
            {
                sum += 1;
            }
            else if (currentChar.Equals('e'))
            {
                sum += 2;
            }
            else if (currentChar.Equals('i'))
            {
                sum += 3;
            }
            else if (currentChar.Equals('o'))
            {
                sum += 4;
            }
            else if (currentChar.Equals('u'))
            {
                sum += 5;
            }
        }

        Console.WriteLine(sum);
    }
}