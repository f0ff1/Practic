using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Задание_3
{
    class Polynomial
    {
        private double a, b, c;

        
        public Polynomial(double a, double b, double c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("Неверные значения.");
            }
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Calculate(double x)
        {
            var tempAnswer = a * Math.Pow(x, 2) + b * x + c;
            return tempAnswer;
        }

        public string CheckCorrect()
        {
            StringBuilder mySb = new StringBuilder();
            if (a != 0)
            {
                mySb.Append($"{a}x^2 ");
            }
            if (b != 0 )
            {
                if (b > 0 && a != 0)
                {
                    mySb.Append($"+ {b}x ");
                }
                else
                {
                    mySb.Append($"{b}x ");
                }
            }
            if (c != 0)
            {
                if (c > 0)
                {
                    mySb.Append($"+ {c}");
                }
                else
                {
                    mySb.Append($"{c}");
                }
            }
            

            return mySb.ToString();

        }

        public static Polynomial operator +(Polynomial left, Polynomial right)
        {
            return new Polynomial(left.a + right.a, left.b + right.b, left.c + right.c);
        }

        public static Polynomial operator -(Polynomial left, Polynomial right)
        {
            return new Polynomial(left.a - right.a, left.b - right.b, left.c - right.c);
        }

        public static Polynomial operator *(Polynomial left, Polynomial right)
        {
            return new Polynomial(left.a * right.a, left.b * right.b, left.c * right.c);
        }

        public void WritePoly()
        {
            WriteLine(CheckCorrect());
        }
    }
}
