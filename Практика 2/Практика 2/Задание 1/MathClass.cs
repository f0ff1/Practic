using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Задание_1
{
    public class MathClass
    {
        public int a, b;
        public MathClass()
        {
            this.a = a;
            this.b = b;
        }

        public double exp(int a, int b)
        {
            var answer = Math.Sin(b + 4) / 2 * a;
            return answer;
        }
        public double sqsum(int a, int b)
        {
            var answer = Math.Pow((a + b), 2);
            return answer;
        }
    }
}
