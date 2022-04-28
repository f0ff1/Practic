using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Задание_1.Enums;

namespace Задание_1.Models
{
    class FlowerDetale
    {
        public FlowerType FlowerType { get; set; }
        public int Count { get; set; }

        public int TotalPrice { get; set; }        

        public string Print { get { return $"Тип: {FlowerType} | Количество: {Count} | Общая цена: {TotalPrice} |\n"; } }

    }
}
