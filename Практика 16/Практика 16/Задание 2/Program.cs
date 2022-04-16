using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
using static System.Convert;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryManager.CreateDirectory();

                string filePath = @"E:\ПРАКТИКА ПО ПРОГРАММИРОВАНИЮ\Практика 16\Практика 16\Задание 2\bin\Debug\net5.0\TestDirectory\Text.txt";
                string secondFilePath = @"E:\ПРАКТИКА ПО ПРОГРАММИРОВАНИЮ\Практика 16\Практика 16\Задание 2\bin\Debug\net5.0\TestDirectory\Text2.txt";
                string thirdFilePath = @"E:\ПРАКТИКА ПО ПРОГРАММИРОВАНИЮ\Практика 16\Практика 16\Задание 2\bin\Debug\net5.0\TestDirectory\Text3.txt";

                WriteLine("Введите количество строк: ");
                int countString = ToInt32(ReadLine());

                FileManager.WriteStringToFile(countString, filePath);

                var readedStrings = FileManager.ReadAllString(filePath);

                FileManager.WriteAllStrings(readedStrings);

                FileManager.CountOfString(readedStrings);

                var lengthString = FileManager.CountOfChars(readedStrings);
                FileManager.WriteAllStrings(lengthString);

                FileManager.FileWithoutLastString(readedStrings, secondFilePath);

                FileManager.WriteFirstSecond(readedStrings);

                WriteLine($"Строка максимальной длины: {FileManager.StringWithMaxLength(lengthString, readedStrings)} ");

                var finded = FileManager.GetStringsStartWith(readedStrings, "e");

                FileManager.WriteAllStrings(finded);

                FileManager.NewFileReverse(readedStrings, thirdFilePath);
            }
            catch (NullReferenceException ex)
            {
                WriteLine(ex.Message);
                
            }

            ReadKey();

        }
    }
}
