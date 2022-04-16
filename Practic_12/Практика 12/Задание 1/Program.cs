using System;
using static System.Console;

namespace Задание_1
{
    delegate double CalcFigure(double radius);

    class Program
    {
        public static double GetLength(double radius) => 2 * Math.PI * radius;

        public static double GetArea(double radius) => Math.PI * Math.Pow(radius, 2);

        public static double GetVolume(double radius) => 4/3 * Math.PI * radius;

        static void Main(string[] args)
        {
            const int MIN = 1;
            const int MAX = 100;

            var length = new CalcFigure(GetLength);
            double radius = Faker.RandomNumber.Next(MIN, MAX) * 0.1;

            WriteLine($"Длина окружности: {length(radius):f2} см.");

            var area = new CalcFigure(GetArea);
            WriteLine($"Площадь круга: {area(radius):f2} см2.");

            var volume = new CalcFigure(GetVolume);
            WriteLine($"Объём шара:  {volume(radius):f2} см3.");

            ReadKey();
        }
    }
}
