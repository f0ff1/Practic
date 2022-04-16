using System;
using Библиотека_расписаний;

namespace Задание_2___тестирование_библиотеки
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();

            var mySchedule = schedule.Create();
            schedule.WriteShedule(mySchedule);

            Console.ReadKey();


        }
    }
}
