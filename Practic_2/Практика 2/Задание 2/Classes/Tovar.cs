using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Задание_2.Classes
{
    class Tovar
    {
        string title;
        

        public Tovar(string title)
        {
            this.title = title;
        }


        public void GetTitle()
        {
            WriteLine( $"Название товара: {title}");
        }
    }
}
