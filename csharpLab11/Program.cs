using System;

namespace csharpLab11
{
    class Program
    {
        enum weekDays
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        delegate void weekDayDelegate();
        static void Main(string[] args)
        {
            int i = 0;

            weekDayDelegate weekdelegate = () =>
            {
                Console.WriteLine($"{(weekDays)i}");
                i= (i + 1)%7;
            };

            for (int j = 0; j < 10; j++)
            {
                weekdelegate();
            }
        }
    }
}