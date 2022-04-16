using System;
using Задание_1;
using static System.Console;
using static System.Convert;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProvider arProvider = new ArrayProvider();
            ArrayViewer arViewer = new ArrayViewer();
            ArrayManager arManager = new ArrayManager();

            Write("Укажите количество строк массива: ");
            int lines = ToInt32(ReadLine());
            Write("Укажите количество столбцов массива: ");
            int colums = ToInt32(ReadLine());

            var myMassiv = arProvider.MakeArray(lines, colums);

            arViewer.WriteMassiv(myMassiv);

            arManager.ComparisonOfAmounts(myMassiv);
        }
    }
}
