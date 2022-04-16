using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
using static System.Convert;
using System.Linq;


namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Запись чисел в документ
            string path = "Test.txt";

            StreamWriter writer = new StreamWriter(path, false);
            Random rndNumber = new Random();

            var countOfNumbers = rndNumber.Next(10, 100);
            var startDiap = -100;
            var finishDip = 100;

            for (int i = 0; i < countOfNumbers; i++)
            {
                var numberToWrite = rndNumber.Next(startDiap, finishDip);
                writer.Write(numberToWrite);
                writer.Write(" ");
            }
            writer.Close();
            #endregion

            #region Чтение чисел из документа
            StreamReader reader = new StreamReader(path);

            string numbersString = reader.ReadLine();

            var numbersList = numbersString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<int> intNumbers = new();

            foreach (var item in numbersList)
            {
                intNumbers.Add(ToInt32(item));
            }
            reader.Close();
            #endregion

            #region Работа с числами
            var maxNumber = intNumbers.Max();
            var countNegativeNumbers = intNumbers.Count(p => p < 0);                 
            #endregion

            #region Дозапись в файл

            StreamWriter newWriter = new StreamWriter(path, true);

            newWriter.WriteLine($"\nМаксимальное число = {maxNumber}");
            newWriter.WriteLine($"\nКоличество отрицательных чисел: {countNegativeNumbers}");
            newWriter.Close();

            #endregion

            WriteLine("Программа завершила свою работу.");
            ReadKey();

            
        }
    }
}
