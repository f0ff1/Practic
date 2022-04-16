using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1.Services
{
    public static class DelegateService
    {
        public static void WriteSumm(Action<string> action, int a, int b)
        {
            action($"Сумма чисел {a} и {b} = {a+b}");
        }

        public static void WriteDiff(Action<string> action, int a, int b)
        {
            action($"Разность чисел {a} и {b} = {a - b}");
        }

        public static void WriteDiv(Action<string> action, int a, int b)
        {
            action($"Частное чисел {a} и {b} = {a / b}");
        }
    }
}
