using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    public class StringManager
    {
        public string JoinString(string main) => main + " Мы вставили эту строку";
        public string RemoveString(string main) => main.Replace("Мы вставили эту строку", "");
        public string MakeStringUpper(string main) => main.ToUpper();
    }
}
