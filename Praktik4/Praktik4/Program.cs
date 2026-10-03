using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4
{
    internal class Program
    {
        static Dictionary<string, string> InitializeCatalog()
        {
            Dictionary<string,string> catalog = new Dictionary<string, string>();
            catalog.Add("iPhone 11", "Смартфоны");
            catalog.Add("iPhone 12", "Смартфоны");
            catalog.Add("iPhone 13", "Смартфоны");
            catalog.Add("iPhone 14 Pro", "Смартфоны");
            catalog.Add("iPhone 18 ProMax", "Смартфоны");
            catalog.Add("AirPods", "Наушники");
            catalog.Add("AirPods Pro", "Наушники");
            catalog.Add("AirPods Pro 2", "Наушники");
            catalog.Add("AirPods Pro 3", "Наушники");
            catalog.Add("MacBook", "Ноутбуки");
            catalog.Add("MacBook Air", "Ноутбуки");
            catalog.Add("MacBook Pro", "Ноутбуки");
            catalog.Add("iPad 2020", "Планшеты");
            catalog.Add("iPad 2021", "Планшеты");
            catalog.Add("iPad 2022", "Планшеты");
            catalog.Add("iPad 2023", "Планшеты");
            catalog.Add("Защитное стекло", "Аксесуары");
            catalog.Add("Чехол", "Аксесуары");
            catalog.Add("Зарядное устройство 20W", "Аксесуары");
            return catalog;
        }
        static void Main(string[] args)
        {
           List<Receipt> historySellers = new List<Receipt>();
           Receipt myReceipt = Receipt.CreateReceipt(InitializeCatalog());
           Receipt.Print(myReceipt);
           Receipt.Save(myReceipt, historySellers);
           ReportsSales.GeneratedReportSales(historySellers, new DateTime(2026, 10, 3), new DateTime(2026, 10, 5));
           ReportsSales.FindTopCategorya(historySellers, InitializeCatalog());

        }
    }
}
