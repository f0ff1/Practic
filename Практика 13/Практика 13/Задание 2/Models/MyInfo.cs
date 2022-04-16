using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    public class MyInfo
    {
        string baseName;
        string changedName;

        public MyInfo(string baseName)
        {
            this.baseName = baseName;
        }

        public event Action<string, string> NameChanged;


        public void ChangeName(string changedName)
        {
           
            if (baseName != changedName)
            {
                if (NameChanged != null)
                {
                    NameChanged(baseName, changedName);
                    baseName = changedName;
                }
            }
        }


    }
}
