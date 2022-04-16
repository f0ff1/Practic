using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public static class Accauntantcs
    {
        public static bool AskForBonus(positions worker, int hours)
        {
            return ((int)worker <= hours);

        }
    }
}
