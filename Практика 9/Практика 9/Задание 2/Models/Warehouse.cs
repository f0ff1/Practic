using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace Задание_2
{
    class Warehouse
    {
        private List<Product> myProducts = new();

        public List<Product> MakeProductList(Product myProduct)
        {
            myProducts.Add(myProduct);

            return myProducts;
        }

        public Product GetProductByIndex(List<Product> myProducts, int index)
        {
            return myProducts.FirstOrDefault(p => p.GetId() == index);
        }

        public IEnumerable<Product> SortByShopName(List<Product> myProducts) => myProducts.OrderBy(p => p.GetShopName());

        public IEnumerable<Product> SortByProductName(List<Product> myProducts) => myProducts.OrderBy(p => p.GetProductName());

        public IEnumerable<Product> SortByProductCost(List<Product> myProducts) => myProducts.OrderBy(p => p.GetCost());

        public void WriteThis(IEnumerable<Product> products)
        {
            var productsList = products.ToList();

            for (int i = 0; i < productsList.Count(); i++)
            {
                WriteLine($"{productsList[i].GetAllInfromation()}");
            }
        }

        public void WriteThis(List<Product> myProducts)
        {
            for (int i = 0; i < myProducts.Count(); i++)
            {
                WriteLine($"{ myProducts[i].GetAllInfromation()}");
            }
        }

        public void WriteThis(Product myProduct)
        {
            WriteLine($"{ myProduct.GetAllInfromation()}");

        }

    }
}
