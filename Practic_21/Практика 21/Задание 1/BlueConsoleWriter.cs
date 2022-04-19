﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Задание_1.Strategy;
using static System.Console;

namespace Задание_1
{
    public class BlueConsoleWriter : IConsoleWriter
    {

        public void WriteText(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine(text);
        }

    }
}
