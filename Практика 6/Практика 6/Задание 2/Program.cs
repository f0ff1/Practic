using System;
using static System.Console;
using static System.Convert;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {

            StringManager stManager = new StringManager();
            WriteLine("Введите строку: ");
            var myString = ReadLine();

            stManager.WriteLettersAndDigits(myString);

            var summa = stManager.GetSumOfDigitst(myString);
            WriteLine($"Сумма чисел = {summa}");

            if (summa == myString.Length)
            {
                WriteLine("Сумма чисел = длине текста.");
            }
            else
            {
                WriteLine("Сумма чисел не равна длине текста.");
            }

            ReadKey();
        }
    }
}
