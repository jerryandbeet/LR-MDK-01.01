using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class InputReader
    {
        public static int ReadItemNumber(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number) && number >= 0 && number <= 5)
                {
                    return number;
                }
                Console.WriteLine("Ошибка: введите целое число от 0 до 5!!!");
            }
        }

    }
    
}
