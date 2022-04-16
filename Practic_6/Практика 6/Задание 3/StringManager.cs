using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class StringManager
    {
        public string[] MakeSplitString(string inputString)
        {
            return inputString.Split(new char[] { ' ', ',', '!', '?', '\n'}, StringSplitOptions.RemoveEmptyEntries);
        }

        public string ReplaceFistLast(string inputString)
        {
            var splitedString = MakeSplitString(inputString);

            (splitedString[0], splitedString[^1]) = (splitedString[^1], splitedString[0]);

            return string.Join(" ", splitedString);
        }

        public string MakeThirdReverse(string inputString)
        {
            var splitedString = MakeSplitString(inputString);

            var thirdWord = splitedString[2].Reverse();
            return string.Join("", thirdWord);
            
        }

        public string CutFirstWord(string inputString)
        {
            var splitedString = MakeSplitString(inputString);

            var firstWord = splitedString[0];

            for (int i = 0; i < 2; i++)
            {
                splitedString[0] = splitedString[0].Remove(0,1);
            }

            return string.Join(" ", splitedString);

        }

        public string GlueSecondThird(string inputString)
        {
            var firstWhiteSpace = inputString.Trim().IndexOf(" ");
            var sub = inputString.Substring(firstWhiteSpace + 1);
            var second = sub.Trim().IndexOf(" ");
            var index=firstWhiteSpace+second+1;
            
            return inputString.Remove(index, 1);

        }

        
    }
}
