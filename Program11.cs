using System;

class Program
{
    delegate string GetNextDayDelegate();
    static void Main(string[] args)
    {
        string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        int currentIndex = 0;

        GetNextDayDelegate getNextDay = () =>
        {
            int nextIndex = (currentIndex) % 7;
            currentIndex += 1;
            return daysOfWeek[nextIndex];
        };

        for (int i = 0; i < 14; i++)
        {
            Console.WriteLine(getNextDay());
        }
    }
}
