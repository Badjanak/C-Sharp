using System;

class EqualWords
{
    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();

        if ((firstWord.ToLower()).Equals(secondWord.ToLower()))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}