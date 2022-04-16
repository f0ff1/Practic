using System;
using System.Text.RegularExpressions;
using Задание_1;
using static System.Console;
using static System.Convert;



namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var regColl = new RegularCollection();
            Write("Введите текст: ");
            var text = ReadLine();

            var vowels = regColl.GetVowels(text);
            regColl.PrintSome(vowels);
            WriteLine($"Количество согласных букв = {vowels.Count}");

            ReadKey();
        }
    }
}
