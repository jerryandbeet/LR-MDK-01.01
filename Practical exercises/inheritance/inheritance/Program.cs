using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Product> products = new List <Product> ();

            foreach (Product product in products)
            {
                decimal sum = product.GetPrice() * product.GetSoldCount();
                decimal sumDiscount = sum * product.CalculateDiscount() / 100;

                Console.WriteLine($"Название товара: {product.GetName()}\tЦена за единицу: {product.GetPrice()} руб.\t" +
                    $"Число проданных товаров: {product.GetSoldCount()} шт.\tСтоимость проданного: {sum} руб.\t" +
                    $"Процент скидки: {product.CalculateDiscount()} %\tСумма с учетом скидки:{sum - sumDiscount} руб.");
            }

        }
        static HouseholdСhemical NewHouseholdСhemical(string name,decimal price,int count)
        {
            HouseholdСhemical prod = new HouseholdСhemical();
            prod.SetName(name);
            prod.SetPrice(price);
            prod.SetSoldCount(count);
            return prod;
        }
        static Food NewFood(string name, decimal price, int count)
        {
            Food prod = new Food();
            prod.SetName(name);
            prod.SetPrice(price);
            prod.SetSoldCount(count);
            return prod;
        }
        static Product NewProduct(string name, decimal price, int count)
        {
            Product prod = new Product();
            prod.SetName(name);
            prod.SetPrice(price);
            prod.SetSoldCount(count);
            return prod;
        }
    }
}
