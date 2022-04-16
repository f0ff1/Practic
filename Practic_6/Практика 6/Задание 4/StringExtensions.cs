using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    public static class StringExtensions
    {
        public static int IndexOfLetters(this string input, char c)
        {
            if (input.IndexOf(c) == -1)
            {
                return 0;
            }
            return input.IndexOf(c);
        }
    }
}
