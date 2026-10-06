

namespace LAB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "хлеб", "молоко", "сыр", "колбаса", "масло" };
            int[] price = { 45, 80, 350, 420, 120 };
            int[] stocks = { 30, 25, 12, 8, 15 };
            int[] order = new int[5];
            ShopServices.PrintPriceList(names, price, stocks);
            ShopServices.CollectOrder(order, names);
            ShopServices.ProcessTransaction(order,stocks,price,names);
            ShopServices.PrintFinalStocks(names,stocks);
        }
    }
}
