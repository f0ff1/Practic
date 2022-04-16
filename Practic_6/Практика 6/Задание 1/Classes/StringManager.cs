using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public static class StringManager
    {

        public static string GetReverse(this string inputString)
        {
            return new string(inputString.ToArray().Reverse().ToArray());
        }

    }
}
