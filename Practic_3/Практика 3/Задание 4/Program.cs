using System;
using static System.Console;
using static System.Convert;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Количество столбцов = ");
            int columns = ToInt32(ReadLine());
            WriteLine("Количество строк = ");
            int lines = ToInt32(ReadLine());

            Massiv myNumbersMas = new Massiv(columns, lines);
            myNumbersMas.makeMas();

            myNumbersMas.WriteMas();

            WriteLine("Введите номер стобца для суммы: ");
            int numberOfColumn = ToInt32(ReadLine());

            WriteLine("=============\n" +
                $"Суммирование столбца № 1 и № {numberOfColumn} :\n");
            myNumbersMas.makePlus(numberOfColumn);
            myNumbersMas.WriteMas();

            WriteLine("============\n" +
                "ПРОБА №1 + № 2\n");
            var tempMass = myNumbersMas + 2;
            tempMass.WriteMas();
        }
    }
}
