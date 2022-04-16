using System;
using System.Text.RegularExpressions;
using static System.Console;
using static System.Convert;


namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var regColl = new RegularCollection();
            Write("Введите текст: ");
            var text = ReadLine();


            var firstWord = regColl.FindFirstWord(text);
            var lastWord = regColl.FindLastWord(text);

            Write("Первое слово текста: ");
            regColl.PrintSome(firstWord);

            Write("Последнее слово текста: ");
            regColl.PrintSome(lastWord);

            var findedNUmbers = regColl.FindNumbers(text);
            
            if (findedNUmbers.Count > 0)
            {
                regColl.PrintSome(findedNUmbers);
            }
            else
            {
                WriteLine("Цифры не найдены.");
            }

            var vowels = regColl.GetVowels(text);
            regColl.PrintSome(vowels);
            WriteLine($"Количество согласных букв = {vowels.Count}");

            ReadKey();
        }
    }
}
