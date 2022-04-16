using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = @"E:\ПРАКТИКА ПО ПРОГРАММИРОВАНИЮ\Практика 18\Практика 18\Задание 2\bin\Text.txt";

            StreamReader streamReader = new StreamReader(textPath);
            QueueManager queueManager = new();

            var readed = default(string);

            while ((readed = streamReader.ReadLine()) != null)
            {
                foreach (var item in readed)
                {
                    if (char.IsDigit(item))
                    {
                        queueManager.AddToDigitQueue(item);
                    }
                    else
                    {
                        queueManager.AddToNoDigitQueue(item);
                    }
                }
            }
            
            queueManager.GetQueueNoDigits()?.ToList().ForEach(i => Write($"{i}"));
            WriteLine();
            queueManager.GetQueueDigits()?.ToList().ForEach(i => Write($"{i} "));


            ReadLine();
        }
    }
}
