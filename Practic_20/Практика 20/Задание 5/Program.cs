using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Задание_5
{
    class Program
    {
        private static void MakeSecondDegree(int digit, double degree, Action<string> action, ParallelLoopState pls)
        {
            var sDegree = Math.Pow(digit, 2);
            if (/*pls.ShouldExitCurrentIteration &&*/ sDegree > 150)
            {
                pls.Break();
                action($"Состояние прервано со значением secondDegree {sDegree}");
            }
            
            action($"{sDegree:f2}");
        }

        private static void CheckSqrt(int digit, double sqrt, Action<string> action, ParallelLoopState pls)
        {
            var digitSqrt = Math.Sqrt(digit);
            if (digitSqrt > 10)
            {
                pls.Break();
                action($"Состояние прерва со значение digitSqrt {digitSqrt}");
            }

            action($"{digitSqrt:f2}");
        }

        static void Main(string[] args)
        {
            var digits = new List<int>() { 1, 4, 61, 85, 99, 150 };
            double sqrt = default;
            double degree = default;

            ParallelLoopResult loopResult = Parallel.ForEach(digits, (str,state) => MakeSecondDegree(str, degree, WriteLine,state));
            if (!loopResult.IsCompleted)
            { WriteLine($"Выполнение цикла завершено на итерации {loopResult.LowestBreakIteration}"); }
            ParallelLoopResult loopResult1 = Parallel.ForEach(digits, (str, state) => CheckSqrt(str, sqrt, WriteLine, state));
            if (!loopResult1.IsCompleted)
            { WriteLine($"Выполнение цикла завершено на итерации {loopResult.LowestBreakIteration}"); }
            ReadKey();
        }
    }
}
