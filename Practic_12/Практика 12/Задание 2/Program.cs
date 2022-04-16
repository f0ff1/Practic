using System;
using Задание_2.MathClass;
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
                Calculate mathematic = new();
                Write("Введие а: ");
                var a = ToInt32(ReadLine());
                Write("Введие b: ");
                var b = ToInt32(ReadLine());

                WriteLine($"add = {mathematic.Add(a, b)}"); 
                WriteLine($"sub = {mathematic.Sub(a, b)}");
                WriteLine($"mul = {mathematic.Mul(a, b)}");
                WriteLine($"div = {mathematic.Div(a, b)}");

            }
            catch (DivideByZeroException)
            {
                WriteLine("Делить на 0 нельзя!");
            }
            catch (FormatException)
            {
                WriteLine("Неверный формат!");
            }

            ReadKey();
        }
    }
}
