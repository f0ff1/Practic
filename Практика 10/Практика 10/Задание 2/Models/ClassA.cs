using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class ClassA
    {
        protected int a;
        protected int b;

        public ClassA()
        {
                
        }

        public ClassA(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int GetA() => a;
        public int GetB() => b;

        public int C()
        {
            while (a<b)
            {
                a *= b;
            }

            return a;
        }
    }
}
