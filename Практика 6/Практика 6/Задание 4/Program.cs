using System;
using static System.Console;
using static System.Convert;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Задание_4;

namespace zadanie4
{
    class Program
    {
        public static int GetSumAlphabets(string inputFIO, string alphabet)
        {
            return inputFIO.Select(c => alphabet.IndexOfLetters(c)).Sum();
        }

        public static IEnumerable<int> GetCutNumbers(int numbers)
        {
            string stringNumbers = numbers.ToString();
            var cutNumbers = stringNumbers.Select(c => (int)char.GetNumericValue(c));
            cutNumbers.ToList().ForEach(WriteLine);

            foreach (var item in cutNumbers)
            {
                WriteLine($"Число - {item}");
            }
            return cutNumbers;
        }

        public static int SummingNumber(IEnumerable<int> cutNumbers)
        {
            var summa = cutNumbers.Sum(c => ToInt32(c));
            WriteLine($"summa - {summa}");
            return summa;
        }
        static void Main(string[] args)
        {
            string alphabet = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            char[] delimiterChars = { ' ', ',', '.', ':', '?', '!', ';', '\n', '\t' };
            WriteLine("Введите ФИО: ");
            var inputFIO = ReadLine().ToLower(); ;

            var summedAlphabets = GetSumAlphabets(inputFIO, alphabet);
            var cuttedNumbers = GetCutNumbers(summedAlphabets);
            var tempNumber = SummingNumber(cuttedNumbers);
            WriteLine($"first try, summa = {tempNumber}");


            while (tempNumber > 9)
            {
                cuttedNumbers = GetCutNumbers(tempNumber);
                tempNumber = SummingNumber(cuttedNumbers);
                WriteLine($"Next try, summa = {tempNumber}");
            }


            ReadKey();
        }
    }
}
