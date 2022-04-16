using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace Задание_3
{
    class Program
    {
        public static void ReturnDays(int your_day, int day_count)
        {
            var answer = day_count - your_day;
            WriteLine($"Дней до конца месяца: {answer}.");
        }
        static void Main(string[] args)
        {
            var Monthes = new Dictionary<string, int>()
            {
                ["Январь"] = 31,
                ["Февраль"] = 28,
                ["Март"] = 31,
                ["Апрель"] = 30,
                ["Май"] = 31,
                ["Июнь"] = 30,
                ["Август"] = 31,
                ["Сентябрь"] = 30,
                ["Октрябрь"] = 31,
                ["Ноябрь"] = 30,
                ["Декабрь"] = 31
            };
            ц
            try
            {
                WriteLine("Выберите месяц: ");
                string month = ReadLine();
                WriteLine("Выберите день: ");
                int day = ToInt32(ReadLine());


                if (Monthes.ContainsKey(month))
                {
                    ReturnDays(day, Monthes[month]);
                }
                else
                {
                    WriteLine("Такого месяца не существует...");
                }

            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            finally
            {
                ReadKey();
            }      

        }
    }
}
