using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1.Constants
{
    public class Constant
    {
        const int _MIN = 1;
        private const int _MAX = 100;

        public int GetMinConst() => _MIN;
        public int GetMaxConst() => _MAX;
    }
}
