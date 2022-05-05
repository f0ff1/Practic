using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Задание_5
{
    class Page
    {
        uint pageNumber;
        string[] words;

        public Page(string[] words, uint pageNumber)
        {
            this.words = words;
            this.pageNumber = pageNumber;
        }

        public string[] GetAllWords()
        {
            return words;
        }
        public uint PageNumber => pageNumber;
    }
}
