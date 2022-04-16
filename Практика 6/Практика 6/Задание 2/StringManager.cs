using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

namespace Задание_2
{
    public class StringManager
    {
        public void WriteLettersAndDigits(string inputString)
        {
            var letters = inputString.Where(c => char.IsLetter(c));
            WriteLine(string.Join(", ", letters));

            var digits = inputString.Where(c => char.IsDigit(c)).ToArray();
            List<int> intDigits = new List<int>();

            foreach (var digit in digits)
            {
                intDigits.Add(ToInt32(char.GetNumericValue(digit)));
            }
            WriteLine(string.Join(", ", intDigits));

        }


        public int GetSumOfDigitst(string inputString)
        {
            var digits =  inputString.Where(c => char.IsDigit(c)).ToArray();

            List<int> intDigits = new List<int>();

            foreach (var digit in digits)
            {
                intDigits.Add(ToInt32(char.GetNumericValue(digit)));
            }

            return intDigits.Sum();

        }

        


    }
}
