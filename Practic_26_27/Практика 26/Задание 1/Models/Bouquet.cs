using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1.Models
{
    public class Bouquet
    {
        private readonly List<Flower> _flowers;

        public Bouquet()
        {
            _flowers = new List < Flower >();
        }

        public List<Flower> GetAll => _flowers;

        public void AddFlower(Flower flower)
        {
            _flowers.Add(flower);
        }
    }
}
