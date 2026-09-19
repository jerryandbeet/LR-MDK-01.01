using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TaskTwo
    {
        private static int[] newArray()
        {
            Random random = new Random();
            int n = random.Next(1,101);
            int[] array = new int[n];
            Console.WriteLine($"Количество элементов массива: {array.Length}");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-500, 501);
            }
            return array;
        }

        private static List <int> newNumbers(int[] array)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 7 == 0) list.Add(array[i]);              
            }
            return list;
        }

        public static void run()
        {
            int[] array = newArray();
            List<int> list = newNumbers(array);
            foreach (int num in list)
                Console.Write(num + ", ");
        }
    }
}
