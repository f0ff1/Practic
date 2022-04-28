using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Задание_1.Enums;
using Задание_1.Models;

namespace Задание_1
{
    class FlowerMaker
    {
        public static Flower Create(FlowerType type)
        {
            var costFlower = FlowerManager.FlowersWithCost[type];
            return new Flower() { Type = type, Cost = costFlower };
        }
    }
}
