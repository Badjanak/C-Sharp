using System;

class PasswordGuess
{
    static void Main()
    {
        string input = Console.ReadLine();
        string password = "s3cr3t!P@ssw0rd";

        Console.WriteLine(input.Equals(password)
            ? "Welcome"
            : "Wrong password!");
    }
}
