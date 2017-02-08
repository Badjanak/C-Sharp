using System;

class PersonalTitles
{
    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string gender = Console.ReadLine();

        bool isFemale = gender.Equals("f");
        bool isMale = gender.Equals("m");
        bool isAdult = age >= 16;
        string greeting = "";
        if (isFemale)
        {
            greeting = isAdult
                ? "Ms."
                : "Miss";
        }
        else if (isMale)
        {
            greeting = isAdult
                ? "Mr."
                : "Master";
        }
    }
}
