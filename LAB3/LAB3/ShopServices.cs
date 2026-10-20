using System;

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
    }
}
