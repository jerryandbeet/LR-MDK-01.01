using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = PizzaСalculation.ReadInt("Введите количество гостей: ", false);
            int slices = PizzaСalculation.ReadInt("Введите количество кусков на одного человека: ", false);
            int size = PizzaСalculation.ReadInt("Введите размер пиццы (6, 8 или 10): ", true);

            PizzaСalculation.CalculateAndPrint(guests, slices, size);


        }
    }
}
