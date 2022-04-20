using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public static class Functions
    {
        public static double firstFunc(double x, double y, Func<double, double> func)
        {
            return 2 * func(Math.Pow(x, 2)) + 3 * y;
        }

        public  static double secFunc(double x, double y, Func<double, double> func)
        {
            return Math.Abs(func(x) - y);
        }

        public static  double thirdFunc(double x, double y, Func<double, double> func)
        {
            return Math.Pow(func(x) - y, 2);
        }

        public static double Snh(double x)
        {
            return Math.Sinh(x);
        }

        

    }
}
