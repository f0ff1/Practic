using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Задание_2
{
    public class Product : IComparable<Product>
    {
        string productName;
        string shopName;
        double cost;
        int id;
        

        public Product(string productName, string shopName, double cost, int id)
        {
            this.productName = productName;
            this.shopName = shopName;
            this.cost = cost;
            this.id = id;
        }

        public string GetProductName()
        {
            return productName;
        }

        public string GetShopName()
        {
            return shopName;
        }

        public double GetCost()
        {
            return cost;
        }

        public int GetId()
        {
            return id;
        }

        public string GetAllInfromation()
        {
            return $"ID: {id} | Название продукта: {productName} | Название магазина: {shopName} | цена: {cost}";
        }


        public int CompareTo(Product other)
        {
            if (productName == other.productName)
            {
                if (cost > other.cost)
                {
                    return 1;
                }
                if (cost < other.cost)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
