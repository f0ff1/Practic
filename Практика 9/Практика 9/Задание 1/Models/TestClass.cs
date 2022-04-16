using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Задание_1.Interface;
using static System.Console;

namespace Задание_1
{
    class TestClass: Ix, Iy, Iz, Iw
    {
        public double xVal;

        public TestClass()
        {
            xVal = 121.40;
        }

        public TestClass(double key)
        {
            xVal = key;
        }

        public void IxF0(double key)
        {
            xVal = Math.Log(key);
            WriteLine($"IxF0 = {xVal} ");
        }

        public void IxF1()
        {
            xVal = Math.Log(xVal);
            WriteLine($"IxF0 = {xVal} ");
        }

        public void F0(double key)
        {
            xVal = 2 / key;
            WriteLine($"F0 = {xVal} ");
        }

        public void F1()
        {
            xVal = 2 / xVal;
            WriteLine($"F0 = {xVal} ");
        }

        void Iw.F0(double key)
        {
            xVal = Math.Pow(key, 3);
            WriteLine($"Iw.F0 = {xVal} ");
        }
        void Iw.F1()
        {
            xVal = Math.Pow(xVal, 3);
            WriteLine($"Iw.F0 = {xVal} ");
        }

        public void bF0()
        {
            WriteLine($"bF0()...");
        }
    }
}
