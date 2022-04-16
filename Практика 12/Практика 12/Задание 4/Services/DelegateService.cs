using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_4.Models
{
    /// <summary>
    /// Класс DelegateSerivce работает с делегатами: "Action, Func"
    /// </summary>
    public static class DelegateService
    {
        /// <summary>
        /// Возвращает рандомное число, сгенерированное с помощью NuGet Faker.RundomNumber(1, 100)
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public static int GetRandomNum(Action<int> action)
        {
            var number = Faker.RandomNumber.Next(1, 100);
            action(number);

            return number;
        }

       /// <summary>
       /// Вычисляет среднее арифметическое чисел. Linq.Average
       /// </summary>
       /// <param name="myDelegates">Список делегаетов (int,int)</param>
       /// <param name="action"></param>
       /// <returns></returns>
        public static double GetAverage(List<Func<Action<int>, int>> myDelegates, Action<int> action)
        {
            return myDelegates.Average(d => d(action));
        }
    }
}
