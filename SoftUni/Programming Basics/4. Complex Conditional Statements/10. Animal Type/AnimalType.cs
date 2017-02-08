using System;

class AnimalType
{
    static void Main()
    {
        string input = Console.ReadLine();

        switch (input)
        {
            case "dog":
                Console.WriteLine("mamal");
                break;
            case "crocodile":
            case " tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}
