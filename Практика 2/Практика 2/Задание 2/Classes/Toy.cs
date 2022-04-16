using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_2.Classes
{
    class Toy : Product
    {
        string material, type;
        public Toy(string material, string type, double price, string title) : base(price, title)
        {
            this.material = material;
            this.type = type;
        }

        public void GetMaterial()
        {
            WriteLine($"Материал игрушки: {material}");
        }
        public void GetType()
        {
            WriteLine($"Тип игрушки: {type}");
        }
    }
}
