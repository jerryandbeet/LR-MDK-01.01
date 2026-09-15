using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LAB1
{
    class PizzaСalculation
    {
        public static int ReadInt(string prompt, bool IsPizzaSize)
        {
            Console.Write(prompt);
            if (IsPizzaSize)
            {
                int count = Convert.ToInt32(Console.ReadLine());
                while (count != 6 || count != 8 || count != 10)
                {
                    Console.Write("\nВы ввели неверное количество кусочков! Попробуйте еще раз (6, 8 или 10 кусочков): ");
                    count = Convert.ToInt32(Console.ReadLine());
                }
                return count;
            }
            else
            {
                int count = Convert.ToInt32(Console.ReadLine());
                while (count <= 0)
                {
                    Console.Write("\nВы ввели неверное количество! Попробуйте еще раз: ");
                    count = Convert.ToInt32(Console.ReadLine());
                }
                return count;
            }
        }

        public static void CalculateAndPrint (int guests, int slices, int size)
        {
            int totalSlices = guests * slices;
            int pizzaCount = (totalSlices + size - 1) / size; //округление вверх целочисленым делением
            int remainsSlices = (pizzaCount * size) - totalSlices;

            Console.WriteLine($"\nНеобходимое количество кусков: {totalSlices}");
            Console.WriteLine($"\nКоличество пицц: {pizzaCount}");
            Console.WriteLine($"\nОстаток кусков: {remainsSlices}");


        }


        }
}
