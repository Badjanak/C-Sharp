using System;

class VowelOrDigit
{
    static void Main()
    {
        char input = char.Parse(Console.ReadLine());

        if (input >= 48 && input <= 57)
        {
            Console.WriteLine("digit");
        }
        else if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u' ||
             input == 'A' || input == 'E' || input == 'I' || input == 'O' || input == 'U')
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}