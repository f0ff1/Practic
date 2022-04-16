using System;
using static System.Console;
using static System.Convert;
namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("Введите скорость в начальном моменте времени (v0): ");
                double v0 = ToDouble(ReadLine());
                WriteLine("Введите постоянное ускорение (a): ");
                double a = ToDouble(ReadLine());
                WriteLine("Введите время (t): ");
                double t = ToDouble(ReadLine());

                var V = v0 + a * t;
                var S = v0 * t + (a * Math.Pow(t, 2) / 2);

                WriteLine($"Скорость = {V} м/c");
                WriteLine($"Расстояние = {S} м");
            }
            catch (FormatException)
            {

                WriteLine("Неправильный ввод данных!");
            }

            catch (DivideByZeroException ex)
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
