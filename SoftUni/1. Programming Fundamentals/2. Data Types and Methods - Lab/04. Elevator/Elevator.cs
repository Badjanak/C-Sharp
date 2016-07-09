using System;

class Elevator
{
    static void Main()
    {
        int people = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());

        int courses = people / capacity;
        if (people % capacity != 0)
        {
            courses++;
        }

        Console.WriteLine(courses);
    }
}