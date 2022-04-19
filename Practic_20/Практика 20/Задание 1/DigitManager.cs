using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;

namespace Задание_1
{
    public class DigitManager
    {
        private int _myDigit;
      
        private bool CheckLength()
        {
            if (_myDigit.ToString().Length > 3 || _myDigit.ToString().Length < 3)
            {
                throw new ArgumentException("Неудовлетворительная длина введенного числа!");
            }
            else
            {
                return true;
            }
        }


        private List<int> CutDigits()
        {
            List<int> digits = new List<int>();

            if (CheckLength())
            {               
                while (_myDigit != 0)
                {
                    var d = _myDigit % 10;
                    digits.Add(d);
                    _myDigit /= 10;
                }
            }
            

            return digits;
        }

        public List<int> GetDigits(int myDigit)
        {
            _myDigit = myDigit;

            string[] massiv = new string[] { "123", "132", "213", "231", "312", "321" };
            List<int> allDigits = new();
            var cutedDigits = CutDigits();

            for (int elem = 0; elem < massiv.Length; elem++)
            {                
                var mask = massiv[elem];
                var i1 = (int)char.GetNumericValue(mask[0]);
                var i2 = (int)char.GetNumericValue(mask[1]);
                var i3 = (int)char.GetNumericValue(mask[2]);


                var number = cutedDigits[i1 - 1] * 100 +
                            cutedDigits[i2 - 1] * 10 +
                            cutedDigits[i3 - 1];

                allDigits.Add(number);                
            }

            return allDigits;
        }


        public void WriteDigits(List<int> digits)
        {
            foreach (var digit in digits)
            {
                Console.WriteLine($"Число: {digit}");
            }
        }        

    }
}
