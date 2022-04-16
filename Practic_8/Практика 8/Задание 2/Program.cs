using System;
using static System.Console;
using static System.Convert;
using System.Linq;
using System.Collections.Generic;

namespace Задание_2
{
    public class Program
    {

        static void Main(string[] args)
        {

            WriteLine("Какая должность у вашего сотрудника?\n" +
                "junior\n" +
                "middle\n" +
                "senior\n");

            var post = ReadLine();
            WriteLine("Введите количество отработанных часов: ");
            var hourse = ToInt32(ReadLine());

            try
            {
                var myWorker = Worker.MakeWorker(post);
                var ifBonus = Accauntantcs.AskForBonus(myWorker, hourse);

                if (ifBonus)
                {
                    WriteLine("Работник заработал премию...");
                }
                else
                {
                    WriteLine("Работник не заработал премию...");
                }
            }
            catch (Exception)
            {
                WriteLine("Ошибка");

            }

            ReadKey();

        }
    }
}
