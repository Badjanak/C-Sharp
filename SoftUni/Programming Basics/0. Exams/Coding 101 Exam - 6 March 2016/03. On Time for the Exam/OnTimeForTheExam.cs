using System;

class OnTimeForTheExam
{
    static void Main()
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinutes = int.Parse(Console.ReadLine());
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinutes = int.Parse(Console.ReadLine());

        int exam = examHour * 60 + examMinutes;
        int arrival = arrivalHour * 60 + arrivalMinutes;
        int difference = Math.Abs(exam - arrival);

        bool hasHour = difference >= 60;
        bool isOnTime = difference <= 30 && arrival <= exam;

        if (isOnTime)
        {
            Console.WriteLine("On time");
            if (difference != 0)
            {
                Console.WriteLine("{0} minutes before the start", difference % 60);
            }
        }
        else if (exam < arrival)
        {
            Console.WriteLine("Late");

            if (hasHour)
            {
                Console.WriteLine("{0}:{1:00} hours after the start", difference / 60, difference % 60);
            }
            else
            {
                Console.WriteLine("{0} minutes after the start", difference % 60);
            }
        }
        else if (exam > arrival)
        {
            Console.WriteLine("Early");

            if (hasHour)
            {
                Console.WriteLine("{0}:{1:00} hours before the start", difference / 60, difference % 60);
            }
            else
            {
                Console.WriteLine("{0} minutes before the start", difference % 60);
            }
        }
    }
}