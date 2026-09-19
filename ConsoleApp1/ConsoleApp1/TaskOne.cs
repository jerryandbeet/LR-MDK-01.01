using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TaskOne
    {
        private static int[] readArray()
        {
            Console.WriteLine("Введите количество элементов массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"\nВведите значение в ячейку массива [{i}] : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array;
        }

        private static int sumArrays(int[] array)
        {
            int sum = 0;
            foreach(int num in array)
            {
                if (num > 0)
                    sum+=num;

            }
            return sum;
        }

        public static void run ()
        {
            Console.WriteLine("Сумма положительных элементов массива = " + sumArrays(readArray()));
        }
    }
}
