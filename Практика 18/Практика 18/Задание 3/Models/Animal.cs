using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    public abstract class Animal
    {
        protected string type;
        protected string? name;
        protected int age;

        protected Animal(string? name, int age, string type)
        {
            this.name = name;
            this.age = age;
            this.type = type;
        }

        public abstract Animal Clone();

        public string? Name => name;

        public string Type => type;

        public int? Age => age;

        public abstract string Information();        
        
    }
}
