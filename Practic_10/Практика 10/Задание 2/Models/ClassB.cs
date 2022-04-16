using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class ClassB : ClassA
    {
        private int _d;
        private int _answer = 0;
        public ClassB(int a, int b, int d) : base(a, b)
        {
            this.a = a;
            this.b = b;
            this._d = d;
        }

        public ClassB()
        {

        }


       
        public int GetD() => _d;
       
        public int C2()
        {
            for (int i = 0; i < a * b * _d; i++)
            {
                _answer = _answer + a + b + _d;
            }

            return _answer;

        }

    }
}
