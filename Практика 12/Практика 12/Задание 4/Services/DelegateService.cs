using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_4.Models
{
    public static class DelegateService
    {
        public static int GetRandomNum(Action<int> action)
        {
            var number = Faker.RandomNumber.Next(1, 100);
            action(number);

            return number;
        }        

        public static double GetAverage(List<Func<Action<int>, int>> myDelegates, Action<int> action)
        {
            return myDelegates.Average(d => d(action));
        }
    }
}
