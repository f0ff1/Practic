using System.Collections.Generic;
using Задание_1.Enums;

namespace Задание_1
{
    class FlowerManager
    {
        public static Dictionary<FlowerType, int> FlowersWithCost = new Dictionary<FlowerType, int>()
        {
            {FlowerType.Rows,5},
        {FlowerType.Pion,3},
        {FlowerType.Romashka,2},
        {FlowerType.Tylpan,4}
        };

    }
}
