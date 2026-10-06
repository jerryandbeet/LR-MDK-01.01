using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class ShopServices
    {
        public void PrintPriceList(string[] names, int[] prices, int[] stocks)
        {
            Console.WriteLine("=====Прайс лист=====");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i+1}. {names[i]} - {prices[i]} руб., {stocks[i]} шт.");
            }
            Console.WriteLine();
        }
    }
}
