using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Convert;


namespace Задание_5
{
    class Program
    {
        public static Page[] GetPages(string text)
        {
            var pages =  text.Split("<page>", StringSplitOptions.RemoveEmptyEntries);
            return pages.Where(p=>p.Any(char.IsLetterOrDigit)).Select((page, index) => new Page(page.Trim().Split(new char[] { ' ', ',', '\n', '\t', ':', '-', '.','\r' }, StringSplitOptions.RemoveEmptyEntries), (uint)(index + 1))).ToArray();
        }
        public static Dictionary<string, List<uint>> MakeDictionary (Page[] myPages)
        {
            Dictionary<string, List<uint>> myDictionary = new Dictionary<string, List<uint>>();
            foreach (var page in myPages)
            {
                foreach (var word in page.GetAllWords())
                {
                    if (!myDictionary.ContainsKey(word))
                    {
                        myDictionary.Add(word, new List<uint>());
                        
                    }
                    var values = myDictionary[word];
                    if (!values.Contains(page.PageNumber))
                    {
                        myDictionary[word].Add(page.PageNumber);
                    }  
                }
            }
            return myDictionary;
        }

        public static void WriteDictionaryToTxt(Dictionary<string, List<uint>> myDictionary)
        {
            string path = ("E:\\text2.txt");
            StreamWriter sw = new StreamWriter(path, false);
            foreach (var item in myDictionary)
            {
                sw.WriteLine($"{item.Key}\t===\t{string.Join(",",item.Value)}");

               
            }
        }
        
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("E:\\text.txt");
            var text = sr.ReadToEnd();

            WriteDictionaryToTxt(MakeDictionary(GetPages(text)));
            WriteLine("Работа программы завершена...");
            ReadLine();
            

        }
    }
}
