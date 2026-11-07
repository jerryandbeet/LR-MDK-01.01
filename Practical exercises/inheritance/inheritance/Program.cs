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


            HouseholdСhemical grass = new HouseholdСhemical ();
            grass.SetName("Антижир");
            grass.SetPrice(100);
            grass.SetSoldCount(301);

            Food meat = new Food ();
            meat.SetName("Сосиски");
            meat.SetPrice(100);
            meat.SetSoldCount(6);

            Product prod = new Product ();
            prod.SetName("Спички");
            prod.SetPrice(100);
            prod.SetSoldCount(10);

            products.Add(grass);
            products.Add(meat);
            products.Add(prod);

            foreach(Product product in products)
            {
                decimal sum = product.GetPrice() * product.GetSoldCount();
                decimal sumDiscount = sum * product.CalculateDiscount() / 100;

                Console.WriteLine($"Название товара: {product.GetName()}\tЦена за единицу: {product.GetPrice()} руб.\t" +
                    $"Число проданных товаров: {product.GetSoldCount()} шт.\tСтоимость проданного: {sum} руб.\t" +
                    $"Процент скидки: {product.CalculateDiscount()} %\tСумма с учетом скидки:{sum - sumDiscount} руб.");
            }

        }
    }
}
