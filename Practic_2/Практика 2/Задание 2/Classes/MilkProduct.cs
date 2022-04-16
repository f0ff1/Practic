using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_2.Classes
{
    class MilkProduct : Product
    {
        double fat, volume;
        public MilkProduct(double fat, double volume,string title, double price) : base(price, title)
        {
            this.fat = fat;
            this.volume = volume;
        }

        public void GetFat()
        {
            WriteLine($"Жирность: {fat}%");
        }
        public void GetVolume()
        {
            WriteLine($"Объём: {volume}мл.");
        }

    }
}
