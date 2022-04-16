using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_2
{
    /// <summary>
    /// Класс FileManage работает с текстовыми документами
    /// </summary>
    public static class FileManager
    {
        /// <summary>
        /// Запись n количества строк в файл (строги генерируются с помощью Faker)
        /// </summary>
        /// <param name="countOfStrings">Количество строк</param>
        /// <param name="filePath">Путь к текстовому файлу</param>
        public static void WriteStringToFile(int countOfStrings, string filePath)
        {
            
            StreamWriter streamWriter = new StreamWriter(filePath, false);

            for (int i = 0; i < countOfStrings; i++)
            {
                streamWriter.WriteLine(Faker.TextFaker.Sentence());
            }
            streamWriter.Close();
        }

        /// <summary>
        /// Чтение всех строк из файла 
        /// </summary>
        /// <param name="filePath">Путь к текстовому файлу</param>
        /// <returns>Список строк: List(string)</returns>
        public static List<string> ReadAllString(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);

            List<string> stringList = new();

            while (streamReader.Peek() >= 0)
            {
                stringList.Add(streamReader.ReadLine());
            }

            return stringList;
        } 

        /// <summary>
        /// Вывод всех строк на консоль
        /// </summary>
        /// <param name="stringList">Список строк: List(string)</param>
        public static void WriteAllStrings(List<string> stringList) 
        {
            foreach (var item in stringList)
            {
                WriteLine(item);
            }
        }

        /// <summary>
        /// Вывод всех строк на консоль 
        /// </summary>
        /// <param name="stringList">Список строк: List(int)</param>
        public static void WriteAllStrings(List<int> stringList) 
        {
            foreach (var item in stringList)
            {
                WriteLine(item);
            }
        }

        /// <summary>
        /// Вывод всех строк на консоль
        /// </summary>
        /// <param name="stringList">Список строк: Ienumerable(string)</param>
        public static void WriteAllStrings(IEnumerable<string> stringList)
        {
            foreach (var item in stringList)
            {
                WriteLine(item);
            }
        }

        /// <summary>
        /// Возвращает количество строк в файле   
        /// </summary>
        /// <param name="stringList">Список строк: List(string)</param>
        /// <returns>int count</returns>
        public static int CountOfString(List<string> stringList) => stringList.Count();

        /// <summary>
        /// Возвращает список количества символов в строках
        /// </summary>
        /// <param name="stringList">Список строк: List(string)</param>
        /// <returns>List(int)</returns>
        public static List<int> CountOfChars(List<string> stringList) 
        {
            List<int> lengthStrings = new();

            foreach (var item in stringList)
            {
                lengthStrings.Add(item.Length);
            }

            return lengthStrings;
        }

        /// <summary>
        /// Создаёт новый файл без последней строки из предыдущего (text => text2)
        /// </summary>
        /// <param name="stringList">Список строк: List(string)</param>
        /// <param name="secondFilePath">Путь ко выходному текстовому документу</param>
        public static void FileWithoutLastString(List<string> stringList, string secondFilePath) 
        {
            
            StreamWriter secondStreamWriter = new StreamWriter(secondFilePath, false);

            var withoutLast = stringList.SkipLast(1);

            foreach (var item in withoutLast)
            {
                secondStreamWriter.WriteLine(item);
            }
            secondStreamWriter.Close();
        }

        /// <summary>
        /// Вывод первой и второй строки файла
        /// </summary>
        /// <param name="stringList">Список строк: List(string)</param>
        public static void WriteFirstSecond(List<string> stringList)  
        {
            for (int i = 0; i < 2; i++)
            {
                WriteLine($"{i + 1} строка: {stringList[i] }");
            }
        }

        /// <summary>
        /// Выдает строку максимальной длины
        /// </summary>
        /// <param name="lengthStrings">Список длин всех строк List(int)</param>
        /// <param name="stringList"></param>
        /// <returns>Строку максимальной длины</returns>
        public static string StringWithMaxLength(List<int> lengthStrings, List<string> stringList) 
        {
            var maxLength = lengthStrings.Max();
            var indexOfMaxString = lengthStrings.IndexOf(maxLength);

            return stringList[indexOfMaxString];
        }

        /// <summary>
        /// Возвращает строки начинающиеся с буквы letter
        /// </summary>
        /// <param name="stringList">Список строк: List(string)</param>
        /// <param name="letter">Начальная буква</param>
        /// <returns>Ienumerable(string)</returns>
        public static IEnumerable<string> GetStringsStartWith(List<string> stringList, string letter)
        {
            var finded = stringList.Where(p => p.StartsWith(letter.ToUpper()));
            if (finded != null)
            {
                return finded;
            }
            else
            {
                throw new NullReferenceException("Такой строки не существует");
            }
            
        }

        /// <summary>
        /// Создает файл техт3 с строками.reverse
        /// </summary>
        /// <param name="stringList">Список строк: List(string)</param>
        /// <param name="thirdFilePath">Путь к третьему текстовому документу</param>
        public static void NewFileReverse(List<string> stringList, string thirdFilePath) 
        {
            
            StreamWriter thirdStreamWriter = new StreamWriter(thirdFilePath, false);

            stringList.Reverse();
            foreach (var item in stringList)
            {
                thirdStreamWriter.WriteLine(item);
            }
            thirdStreamWriter.Close();
        }
            
            
        
        
    }
}
