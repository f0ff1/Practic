using System.Text.RegularExpressions;
using static System.Console;

namespace Задание_1
{
    public class RegularCollection
    {
        public void PrintSome(MatchCollection matches)
        {
            foreach (Match match in matches)
            {
                Write($"{ match.Value} ");
            }

            WriteLine();
        }

        public MatchCollection FindFirstWord(string text)
        {
            string patternForFirst = @"^\w*";

            Regex reg = new Regex(patternForFirst, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var matches = reg.Matches(text);

            return matches;
        }

        public MatchCollection FindLastWord(string text)
        {

            string patternForLast = @"\w*\w$";
            Regex reg = new Regex(patternForLast, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var matches = reg.Matches(text);

            return matches;
        }

        public MatchCollection FindNumbers(string text)
        {
            string patternForNumbers = @"\d+";
            Regex reg = new Regex(patternForNumbers, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var matches = reg.Matches(text);
            
            return matches;

        }

        public MatchCollection GetVowels(string text)
        {
            string patternForVowels = @"[б,в,г,д,ж,з,й,к,л,м,н,п,р,с,т,ф,х,ц,ч,ш,щ]";
            Regex reg = new Regex(patternForVowels, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var matches = reg.Matches(text);

            return matches;
        }
    }
}
