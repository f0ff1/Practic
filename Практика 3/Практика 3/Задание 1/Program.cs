using System;
using static System.Console;
using static System.Convert;

namespace Задание_1
{
    class Program
    {
        public static double MakeMathematic(int n, double x)
        {
            var answer = Math.Pow(x, n) / n;
            return answer;
        }
        static void Main(string[] args)
        {
            double tempAnswer = 0;
            for (int i = 0; i < 3; i++)
            {
                Write("Введите n: ");
                int n = ToInt32(ReadLine());
                Write("Введите x: ");
                double x = ToDouble(ReadLine());

                tempAnswer += MakeMathematic(n, x);
                
            }

            WriteLine($"Ответ: {Math.Round(tempAnswer, 2)}");
        }
    }
}
