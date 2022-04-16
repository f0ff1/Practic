using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    public static class IenumerableManager
    {

        public static bool AreStringPolindrom(this string inputs)
        {
            return inputs.ToLower().Equals(inputs.ToLower().GetReverse());
        }
    }
}
