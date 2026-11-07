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

            products.Add (NewProduct(new Product (), "Спички",10,4));
            products.Add(NewProduct(new HouseholdСhemical(), "Антижир", 210, 21));
            products.Add(NewProduct(new HouseholdСhemical(),"Fairy", 98, 151));
            products.Add(NewProduct(new HouseholdСhemical(),"Grass", 159, 302));
            products.Add(NewProduct(new Food(), "Сосиски", 100, 6));
            products.Add(NewProduct(new Food(), "Макароны", 66, 11));
            products.Add(NewProduct(new Food(), "Рис", 43, 3));

            foreach (Product product in products)
            {
                decimal sum = product.GetPrice() * product.GetSoldCount();
                decimal sumDiscount = sum * product.CalculateDiscount() / 100;

                Console.WriteLine($"Название товара: {product.GetName()}\tЦена за единицу: {product.GetPrice()} руб.\t" +
                    $"Число проданных товаров: {product.GetSoldCount()} шт.\tСтоимость проданного: {sum} руб.\t" +
                    $"Процент скидки: {product.CalculateDiscount()} %\tСумма с учетом скидки:{sum - sumDiscount} руб.");
            }

        }

        static Product NewProduct(Product prod, string name, decimal price, int count)
        {
            prod.SetName(name);
            prod.SetPrice(price);
            prod.SetSoldCount(count);
            return prod;
        }
    }
}
