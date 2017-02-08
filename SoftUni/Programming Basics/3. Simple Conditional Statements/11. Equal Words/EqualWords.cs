using System;

class EqualWords
{
    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();

        bool areEqual = firstWord.ToLower().Equals(secondWord.ToLower());
        if (areEqual)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
