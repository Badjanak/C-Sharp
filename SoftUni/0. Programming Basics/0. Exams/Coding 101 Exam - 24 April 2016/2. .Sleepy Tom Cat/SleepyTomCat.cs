using System;

class SleepyTomCat
{
    static void Main()
    {
        int holydays = int.Parse(Console.ReadLine());

        int workdays = 365 - holydays;
        int playTime = holydays * 127 + workdays * 63;

        if (playTime > 30000)
        {
            Console.WriteLine("Tom will run away\n{0} hours and {1} minutes more for play", (playTime - 30000) / 60, (playTime - 30000) % 60);
        }
        else
        {
            Console.WriteLine("Tom sleeps well\n{0} hours and {1} minutes less for play", (30000 - playTime) / 60, (30000 - playTime) % 60);
        }
    }
}