using System;
using static System.Console;
using static System.Convert;

namespace Задание_2
{
    class Program
    {
        public static double MakeCalculate(int x)
        {
            double f;
            if (x > -5 && x < 1)
            {
                f = x - 3;
            }
            else if (x >= 1)
            {
                f = Math.Pow(x, 2) / 3 * x - 9;
            }
            else
            {
                throw new IndexOutOfRangeException("Ошибка выхода из диапозона.");
            }
            return f;
        }

        public static void WriteCalculated(double f)
        {
            WriteLine($"Ответ: {f:f2}.\n" +
                $"=========================");
        }

        static void Main(string[] args)
        {
            try
            {
                Write("Введите X: ");
                int x = ToInt32(ReadLine());

                WriteCalculated(MakeCalculate(x));
                
            }
            catch(IndexOutOfRangeException ex)
            {
                WriteLine(ex.Message);
            }

            catch (FormatException ex)
            {
                WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                WriteLine("Ошибка: деление на 0!");
            }

            ReadKey();
        }
    }
}
