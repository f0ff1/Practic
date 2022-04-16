using System;
using Задание_1;
using static System.Console;
using static System.Convert;

namespace Тестирование_библиотек
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random rnd = new Random();
                Triangle triangle = Triangle.Create(rnd.Next(1, 10), rnd.Next(4, 10), rnd.Next(6, 10));

                WriteLine($"Тип треугольника: {triangle.TypeOfTriangle()}");
                WriteLine($"Площадь треугольника: {triangle.CalcArea()}");
                WriteLine($"Периметр треугольника: {triangle.CalcPerimetr()}");

                Rectangle rectangle = Rectangle.Create(rnd.Next(1, 10), rnd.Next(4, 10));
                WriteLine($"\nПлощадь прямоугольника: {rectangle.CalcArea()}");
                WriteLine($"Периметр треугольника: {rectangle.CalcPerimetr()}");
            }
            catch (ArgumentException ex)
            {
                WriteLine(ex.Message);
            }

            ReadKey();

        }
    }
}
