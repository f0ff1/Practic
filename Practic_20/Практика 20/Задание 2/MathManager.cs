using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class MathManager
    { 
        public double FirstAction(int myDigit)
        {
            
            return (Math.Pow(myDigit, 2) + 2 * myDigit - 3 + (myDigit + 1) * Math.Sqrt(Math.Pow(myDigit, 2) - 9)) /
                (Math.Pow(myDigit, 2) - 2 * myDigit - 3 + Math.Sqrt(Math.Pow(myDigit, 2)));
        }

        public double SecondAction(int myDigit)
        {
            return Math.Sqrt(myDigit + 3 / myDigit - 3);
        }
    }
}
