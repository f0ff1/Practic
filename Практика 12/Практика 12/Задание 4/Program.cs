using System;
using System.Collections.Generic;
using Задание_4.Models;
using static System.Console;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var d1 = new Func<Action<int>, int> (DelegateService.GetRandomNum);
            var d2 = new Func<Action<int>, int>(DelegateService.GetRandomNum);
            var d3 = new Func<Action<int>, int>(DelegateService.GetRandomNum);

            var delegates = new List<Func<Action<int>, int>>() { d1,d2,d3};

            var average = new Func<List<Func<Action<int>, int>>, Action<int>, double>(DelegateService.GetAverage);
            var averageIn = average(delegates, (n) => {WriteLine(n); });

            WriteLine($"Среднее: {averageIn:f2}");

            ReadKey();
        }
    }
}
