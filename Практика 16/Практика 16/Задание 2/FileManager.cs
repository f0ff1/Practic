using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_2
{
    public static class FileManager
    {
        public static void WriteStringToFile(int countOfStrings, string filePath)
        {
            
            StreamWriter streamWriter = new StreamWriter(filePath, false);

            for (int i = 0; i < countOfStrings; i++)
            {
                streamWriter.WriteLine(Faker.TextFaker.Sentence());
            }
            streamWriter.Close();
        } // Запись n количества строк в файл (строги генерируются с помощью Faker)

        public static List<string> ReadAllString(string filePath)
        {
            StreamReader streamReader = new StreamReader(filePath);

            List<string> stringList = new();

            while (streamReader.Peek() >= 0)
            {
                stringList.Add(streamReader.ReadLine());
            }

            return stringList;
        } // Чтение всех строк из файла (Возвращает List<string>)

        public static void WriteAllStrings(List<string> stringList) // Вывод всех строк на консоль
        {
            foreach (var item in stringList)
            {
                WriteLine(item);
            }
        }

        public static void WriteAllStrings(List<int> stringList) // Вывод всех строк на консоль (Перегрузка INT)
        {
            foreach (var item in stringList)
            {
                WriteLine(item);
            }
        }

        public static void WriteAllStrings(IEnumerable<string> stringList) // Вывод всех строк на консоль (Перегрузка Ienumerable)


        {
            foreach (var item in stringList)
            {
                WriteLine(item);
            }
        }

        public static int CountOfString(List<string> stringList) => stringList.Count(); // Возвращает количество строк в файле         
           
        public static List<int> CountOfChars(List<string> stringList) // Возвращает список количества символов в строках
        {
            List<int> lengthStrings = new();

            foreach (var item in stringList)
            {
                lengthStrings.Add(item.Length);
            }

            return lengthStrings;
        }    

        public static void FileWithoutLastString(List<string> stringList, string secondFilePath) // Создаёт новый файл без последней строки из предыдущего (text => text2)
        {
            
            StreamWriter secondStreamWriter = new StreamWriter(secondFilePath, false);

            var withoutLast = stringList.SkipLast(1);

            foreach (var item in withoutLast)
            {
                secondStreamWriter.WriteLine(item);
            }
            secondStreamWriter.Close();
        }

        public static void WriteFirstSecond(List<string> stringList) // Вывод первой и второй строки файла
        {
            for (int i = 0; i < 2; i++)
            {
                WriteLine($"{i + 1} строка: {stringList[i] }");
            }
        }

        public static string StringWithMaxLength(List<int> lengthStrings, List<string> stringList) // Выдает строку максимальной длины
        {
            var maxLength = lengthStrings.Max();
            var indexOfMaxString = lengthStrings.IndexOf(maxLength);

            return stringList[indexOfMaxString];
        }

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
            
        
        public static void NewFileReverse(List<string> stringList, string thirdFilePath) // Создает файл техт3 с строками.reverse
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
