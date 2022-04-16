using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    public class Horse : Animal
    {
        private int weight;
        private string color;

        public Horse(int weight,  string color, string type, string? name, int age) : base(name, age, type)
        {
            this.weight = weight;
            
            this.color = color;
        }

        public int Weight => weight;
        
        public string Color => color;

        public override Animal Clone()
        {
            return new Horse(weight, color, type, name, age);
        }

        public override string Information()
        {
            return $"Животное: Лошадь | Вес: {weight} кг | Цвет: {color} | Порода: {type} | Имя: {name??"Отсутствует"} | Возраст: {age}";
        }
    }
}
