using System;
using static System.Console;
using static System.Convert;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Write("Введите значение а: ");
                int a = ToInt32(ReadLine());
                Write("Введите значение b: ");
                int b = ToInt32(ReadLine());

                MathClass first = new MathClass();
                WriteLine($"sinb+4/2a = {Math.Round(first.exp(a, b), 2)}");
                WriteLine($"(a+b)^2 = {first.sqsum(a, b)}");

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
