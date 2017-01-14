using System;

class PasswordGuess
{
    static void Main()
    {
        string input = Console.ReadLine();
        string password = "s3cr3t!P@ssw0rd";

        if (input.Equals(password))
        {
            Console.WriteLine("Welcome");
        }
        else
        {
            Console.WriteLine("Wrong password!");
        }
    }
}