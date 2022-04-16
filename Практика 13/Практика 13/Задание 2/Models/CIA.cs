using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class CIA
    {
        private readonly Dictionary<string, string> dictNames;

        public Dictionary<string, string> GetDictionary
        {
            get { return dictNames; }
        }

        public CIA()
        {
            this.dictNames = new Dictionary<string, string>();
        }

        public void CheckName(string baseName, string changedName)
        {
            
            dictNames.Add(baseName, changedName);
        }
    }
}
