using System;

namespace LAB2
{
    internal class InputReader
    {
        public static int ReadItemNumber(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number) && number >= 0 && number <= 5)
                {
                    return number;
                }
                Console.WriteLine("Ошибка: введите целое число от 0 до 5!!!");
            }
        }
        public static int ReadQuantity(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int quantity) && quantity >= 0)
                {
                    return quantity;
                }
                Console.WriteLine("Ошибка: количество должно быть целым неотрицательным числом!!!");
            }
        }
    }
    
}
