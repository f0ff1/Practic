using System;
using static System.Console;
using static System.Convert;

namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("-------------------------------------");
            WriteLine("Введите вещественное число А: ");
            double a = ToDouble(ReadLine());
            WriteLine("Введите вещественное число B: ");
            double b = ToDouble(ReadLine());
            WriteLine("-------------------------------------\n");
            var sum_of_num = a + b;
            WriteLine($"Сумма чисел = {Math.Round(sum_of_num,2)}");

            ReadKey();
        }
    }
}
