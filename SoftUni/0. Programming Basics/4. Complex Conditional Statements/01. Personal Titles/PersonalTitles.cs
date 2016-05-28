using System;

class PersonalTitles
{
    static void Main()
    {
        decimal age = decimal.Parse(Console.ReadLine());
        string sex = Console.ReadLine();
        bool isAdult = age >= 16;

        if (sex.Equals("f"))
        {
            Console.WriteLine("{0}", isAdult ? "Ms." : "Miss");
        }
        else if (sex.Equals("m"))
        {
            Console.WriteLine("{0}", isAdult ? "Mr." : "Master");
        }
    }
}