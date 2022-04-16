using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_3
{
    public class Bird : Animal
    {
        private double wingspan;
        private int beakLength;

        public Bird(double wingspan, int beakLength, string type, string? name, int age) : base(name, age, type)
        {
            this.wingspan = wingspan;
            this.beakLength = beakLength;            
        }

        public double Wingspan => wingspan;
        public double BeakLength => beakLength;

        public override Animal Clone()
        {
            return new Bird(wingspan, beakLength, type, name, age);
        }

        public override string Information()
        {
            return $"Животное: Птица | Размах крыльев: {wingspan:f2} м | Длина клюва: {beakLength} см | Тип: {type} | Имя: {name??"Отсутствует"} | Возраст: {age}";
        }



    }
}
