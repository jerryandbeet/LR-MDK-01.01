using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class ShopServices
    {
        public static void PrintPriceList(string[] names, int[] prices, int[] stocks)
        {
            Console.WriteLine("=====Прайс лист=====");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} руб., {stocks[i]} шт.");
            }
            Console.WriteLine();
        }
        public static void CollectOrder(int[] order, string[] names)
        {
            while (true)
            {
                int itemNumber = InputReader.ReadItemNumber("Введите номер товара (0 - конец заказа): ");
                if (itemNumber == 0) break;
                int quantity = InputReader.ReadQuantity("Введите количество: ");
                order[itemNumber - 1] += quantity;
            }
        }
        public static void ProcessTransaction(int[] order, int[] stocks, int[] prices, string[] names)
        {
            for (int i = 0; i < order.Length; i++)
            {
                if (order[i] > stocks[i])
                {
                    Console.WriteLine($"Заказ отменен! Товара \"{names[i]}\" не хватает на складе!");
                    return;
                }
            }
            int totalSum = 0;
            for (int i = 0; i < order.Length; i++)
            {
                stocks[i] -= order[i];
                totalSum += order[i] * prices[i];
            }
            Console.WriteLine($"Стоимость заказа: {totalSum} руб.");
        }

        public static void PrintFinalStocks(string[] names, int[] stocks)
        {
            Console.WriteLine($"Остатки на складе: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]} {stocks[i]}");
                if (i < names.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }

    }
}
