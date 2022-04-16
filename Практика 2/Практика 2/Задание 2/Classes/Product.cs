using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_2.Classes
{
    class Product : Tovar
    {
        double price;
        public Product(double price, string title) : base(title)
        {
            this.price = price;
        }
               
        public void GetPrice()
        {
            WriteLine($"Цена: {price}р.");
        }
       
    }
}
