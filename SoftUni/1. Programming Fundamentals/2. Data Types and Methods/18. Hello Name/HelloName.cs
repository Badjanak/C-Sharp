using System;

class HelloName
{
    static void Main()
    {
        string name = Console.ReadLine();
        Greet(name);
    }
    static void Greet(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}