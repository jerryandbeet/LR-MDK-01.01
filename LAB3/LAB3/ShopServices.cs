using System;
using System.Runtime.InteropServices;

namespace LAB3
{
    public class ShopServices
    {
        public static void PrintPriceList(Product[] products)
        {
            Console.WriteLine("Прайс-лист: ");
            for(int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].GetName()} - {products[i].GetPrice()} руб., {products[i].GetStock()} шт.");
            }
            Console.WriteLine();
        }
        public static void ProcessTransaction(int[] order, Product[] products)
        {
            for (int i = 0;i < order.Length;i++)
            {
                if (order[i]> products[i].GetStock())
                {
                    Console.WriteLine($"Заказ отменен! Товара \"{products[i].GetName()}\" не хватает на складе!\n");
                    return;
                }
            }
            decimal totalsum = 0;
            for (int i = 0;i<order.Length ; i++)
            {
                products[i].ReduceStock(order[i]);
                totalsum += order[i] * products[i].GetPrice();
            }
            Console.WriteLine($"Стоимость заказа: {totalsum} руб.\n");
        }

        public static void PrintFinalStocks(Product[] products)
        {
            Console.Write("Остатки на складе: ");
            for (int i = 0;i<products.Length;i++)
            {
                Console.WriteLine($"{products[i].GetName()} {products[i].GetStock()}");
                if (i < products.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();   
        }

    }
}
