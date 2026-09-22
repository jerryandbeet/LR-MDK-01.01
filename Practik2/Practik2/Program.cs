using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cofe = new Dictionary<string, int>()
            {
                {"11:00-12:00", 123},
                {"12:00-13:00", 103},
                {"13:00-14:00", 31},
                {"14:00-15:00", 112},
                {"15:00-16:00", 13},
                {"16:00-17:00", 103},
                {"17:00-18:00", 130},
                {"18:00-19:00", 121 },
                {"19:00-20:00", 245}
            };
            int max = cofe["11:00-12:00"];
            int min = cofe["11:00-12:00"];
            string maxKey = "11:00-12:00";
            string minKey = "11:00-12:00";
            foreach (KeyValuePair<string, int> time in cofe)
            {
                if (max < time.Value)
                {
                    max = time.Value;
                    maxKey = time.Key;
                }
                if (min > time.Value)
                {
                    min = time.Value;
                    minKey = time.Key;
                }

            }
            Console.WriteLine($"Наибольшее количество людей было с: {maxKey}. В количестве: {max} людей\nНаименьшее количество людей было с {minKey}. В количестве: {min} людей");


        }
    }
}
