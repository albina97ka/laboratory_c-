using System;

class Program
{
    enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Time
    {
        Утро,
        День,
        Вечер,
        Ночь
    }

    static void Main()
    {
        Console.WriteLine("Введите день недели (0-6):");
        int dayIndex = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите текущее время (0-23):");
        int currentTime = Convert.ToInt32(Console.ReadLine());

        Day day = (Day)dayIndex;
        Time timePeriod;

        if (currentTime >= 5 && currentTime <= 12)
        {
            timePeriod = Time.Утро;
        }
        else if (currentTime >= 13 && currentTime <= 18)
        {
            timePeriod = Time.День;
        }
        else if (currentTime >= 19 && currentTime <= 23)
        {
            timePeriod = Time.Вечер;
        }
        else
        {
            timePeriod = Time.Ночь;
        }

        Console.WriteLine($"Сейчас {day}, {timePeriod}");
    }
}