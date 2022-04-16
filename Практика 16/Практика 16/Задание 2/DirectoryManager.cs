using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_2
{
    public static class DirectoryManager
    {
        public static void CreateDirectory()
        {
            string directoryPath = @"E:\ПРАКТИКА ПО ПРОГРАММИРОВАНИЮ\Практика 16\Практика 16\Задание 2\bin\Debug\net5.0\TestDirectory";

            // Проверка на существование папки и ее создание
            if (Directory.Exists(directoryPath))
            {
                WriteLine("Папка уже существует. Продолжаем работу.");
            }
            else
            {
                DirectoryInfo directory = Directory.CreateDirectory(directoryPath);
                WriteLine($"Папка создана успешно. Время создание папки: {Directory.GetCreationTime(directoryPath)}");
            }
        }
        
    }
}
