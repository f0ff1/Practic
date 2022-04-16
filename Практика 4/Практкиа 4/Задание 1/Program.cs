using System;
using System.Globalization;
using System.Threading;
using static System.Console;
using static System.Convert;

namespace Задание_1
{
    class Program
    {
        public static double MakeFirstCalculate(int x)
        {
            return x + 2 * x / 4 * Math.Sin(x);
        }

        public static double MakeSecondCalculate(int x)
        {
            return x - 3 + 1 / Math.Tan(x - 1);
        }

        public static void WriteCalculated(double y)
        {
            WriteLine($"Ответ: {y:f2}.\n" +
                $"===================");
        }

        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU", true);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU", true);
            try
            {
                Write("Введите X: ");
                int x = ToInt32(ReadLine());

                WriteCalculated(MakeFirstCalculate(x));

            }
            catch (FormatException ex)
            {
                WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                WriteLine("Ошибка: деление на 0!");
            }

            try
            {
                Write("Введите X: ");
                int x = ToInt32(ReadLine());
                WriteCalculated(MakeSecondCalculate(x));

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
