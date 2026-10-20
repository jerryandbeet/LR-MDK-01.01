using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = {
                new Product("хлеб", 45, 30),
                new Product("молоко", 80, 25),
                new Product("сыр", 350, 12),
                new Product("колбаса", 420, 8),
                new Product("масло", 120, 15) };

            int[] order = new int[products.Length];
            ShopServices.PrintPriceList(products);
            ShopServices.CollectOrder(order,products.Length);
            ShopServices.ProcessTransaction(order,products);
            ShopServices.PrintFinalStocks(products);
                

        }
    }
}
