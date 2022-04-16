using System;
using static System.Console;
using static System.Convert;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Введите стороны треугольника...");

                WriteLine("Сторона А: ");
                double a = ToDouble(ReadLine());
                WriteLine("Сторона В: ");
                double b = ToDouble(ReadLine());
                WriteLine("Сторона С: ");
                double c = ToDouble(ReadLine());

                if (!(a + b > c) || !(b + c > a) || !(a + c > b))
                {
                    WriteLine("Треугольник не существует...");
                }
                else
                {
                    WriteLine("Треугольник существует...");
                }
            }
            catch (Exception ex)
            {

                WriteLine(ex.Message);
            }
            finally
            {
                ReadKey();
            }

        }
    }
}
