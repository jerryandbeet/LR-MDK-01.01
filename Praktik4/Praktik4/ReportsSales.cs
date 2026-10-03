using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4
{
    public class ReportsSales
    {
        public static void GeneratedReportSales(List<Receipt> history, DateTime startDay, DateTime stopDay)
        {
            int totalItems = 0;
            decimal totalSum = 0;
            foreach (Receipt receipt in history)
            {
                if (receipt.dateTime_ >= startDay && receipt.dateTime_ <= stopDay)
                {
                    totalSum += receipt.totalSum_;
                    foreach (ReceiptItem item in receipt.items_) totalItems += item.countSell_;
                }
            }
            Console.WriteLine($"За указанный приод ({startDay} - {stopDay}) было продано товаров: {totalItems} шт. на сумму: {totalSum} руб.");
        }
        public static void FindTopCategorya(List<Receipt> history, Dictionary<string, string> catalog)
        {
            Dictionary<string, decimal> categories = new Dictionary<string, decimal>();
            foreach (Receipt receipt in history)
            {
                foreach(ReceiptItem item in receipt.items_)
                { 
                    string category = catalog[item.nameItem_];
                    decimal sum = item.countSell_ * item.price_;
                    if (categories.ContainsKey(category))
                    {
                        categories[category] += sum;
                    }else categories.Add(category, sum);
                }
            }
            string nameTopCategory = "";
            decimal max = 0;
            foreach (KeyValuePair<string,decimal> cat in  categories)
            {
                if (cat.Value > max)
                {
                    max = cat.Value;
                    nameTopCategory = cat.Key;
                }
            }
            Console.WriteLine($"Лучшая категория: {nameTopCategory}.Было продано товаров на сумму: {max} руб.");
        }
    }
}
