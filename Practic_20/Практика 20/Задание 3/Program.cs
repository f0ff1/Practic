using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Задание_1;
using static System.Console;
using static System.Convert;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitManager digitManager = new DigitManager();

            var resultTask = Task<List<int>>.Run(() =>
            {                        
                return digitManager.GetDigits(568);
            }).Result;
            //resultTask.Start();
            //var numbers = resultTask.Result;
            Task writerTask = new Task(() => digitManager.WriteDigits(resultTask));
            writerTask.Start();

            ReadKey();  
        }
    }
}
