using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Задание_1.Models;

namespace Задание_1.Services
{
    class BouquetService
    {
        private Bouquet _bouquet;

        public BouquetService(Bouquet bouquet)
        {
            _bouquet = bouquet;
        }
        public int GetTotalCost()
        {
            return _bouquet.GetAll.Sum(f => f.Cost);
        }
        public IEnumerable<FlowerDetale> GetFlowersWithCount()
        {
            return _bouquet.GetAll.GroupBy(f => f.Type).Select(g => new FlowerDetale
            {

                FlowerType = g.Key,
                Count = g.Count(),
                TotalPrice = g.Count() * FlowerManager.FlowersWithCost[g.Key]
            }
          );
        }
    }
}
