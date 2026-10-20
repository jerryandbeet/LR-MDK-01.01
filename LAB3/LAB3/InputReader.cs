using System.Runtime.InteropServices;
using System;

namespace LAB3
{
    internal class InputReader
    {
        public static int ReadItemNumber(string prompt, int maxItems)
        {
            while(true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if(int.TryParse(input, out int number)&& number >=0&& number<=maxItems)
                {
                    return number; 
                }
                Console.WriteLine($"Ошибка: введите целое число от 0 до {maxItems}!!!");
            }
        }

        public static int ReadQuantity(string prompt)
        {
            while(true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if( int.TryParse(input, out int quantity)&&quantity>=0)
                {
                    return quantity;
                }
                Console.WriteLine($"Ошибка: количество должно быть целым неотрицательным числом!!!");
            }
        }
    }
}
