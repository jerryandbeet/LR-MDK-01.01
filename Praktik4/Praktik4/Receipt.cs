using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik4
{
    public struct Receipt
    {
        public DateTime dateTime_;
        public ReceiptItem[] items_;
        public decimal totalSum_;

        public static Receipt CreateReceipt(Dictionary<string, string> catalog)
        {
            List<ReceiptItem> receiptItems = new List<ReceiptItem>();
            while (true)
            {

                Console.WriteLine($"Введите имя желаемого товара или слово СТОП, для завершения покупок: ");
                string tovarName = Console.ReadLine();
                if (tovarName == "стоп" || tovarName == "СТОП") break;
                else if (!catalog.ContainsKey(tovarName))
                {
                    Console.WriteLine($"{tovarName} нету в нашем магазине, введите другой товар");
                    continue;
                }
                else
                {
                    Console.WriteLine($"В каком количестве вы хотите приобрести позицию {tovarName}: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"По какой цене вы хотите приобрести позицию {tovarName} (укажите цену за единицу): ");
                    decimal price = Convert.ToDecimal(Console.ReadLine());
                    receiptItems.Add(new ReceiptItem { nameItem_ = tovarName, countSell_ = count, price_ = price });
                }
            }
            decimal sumTovars = 0;
            foreach (ReceiptItem item in receiptItems)
            {
                sumTovars += item.price_ * item.countSell_;
            }
            Receipt receipt = new Receipt();
            receipt.dateTime_ = DateTime.Now;
            receipt.totalSum_ = sumTovars;
            receipt.items_ = receiptItems.ToArray();
            return receipt;
        }
        public static void Print (Receipt receipt)
        {
            Console.WriteLine("=====ЧЕК=====");
            Console.WriteLine($"Дата продажи: {receipt.dateTime_}");
            foreach(ReceiptItem item in receipt.items_)
            {
                Console.WriteLine($"Название: {item.nameItem_}\tколичество: {item.countSell_} шт.\tпо {item.price_} руб.");
            }
            Console.WriteLine($"Итого к оплате: {receipt.totalSum_} руб.");

        }
        public static void Save(Receipt receipt, List<Receipt> history)
        {
            history.Add(receipt);
            Console.WriteLine("Чек успешно сохранен в истории!");
        }
    }
}
