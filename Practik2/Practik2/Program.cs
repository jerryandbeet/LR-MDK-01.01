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
                {"12:00-13:00", 123},
                {"13:00-14:00", 31},
                {"14:00-15:00", 31},
                {"15:00-16:00", 13},
                {"16:00-17:00", 13},
                {"17:00-18:00", 130},
                {"18:00-19:00", 121 },
                {"19:00-20:00", 245}
            };
            List<string> maxTimes = new List<string>();
            int max = cofe["11:00-12:00"];
            maxTimes.Add("11:00-12:00");
            List<string> minTimes = new List<string>();
            int min = cofe["11:00-12:00"];
            maxTimes.Add("11:00-12:00");

            foreach (KeyValuePair<string, int> time in cofe)
            {
                if (max == time.Value)
                {
                   maxTimes.Add(time.Key);

                }
                if (max < time.Value)
                {
                    maxTimes.Clear();
                    maxTimes.Add(time.Key);
                    max = time.Value;
                }

                if (min == time.Value)
                {
                    minTimes.Add(time.Key);

                }
                if (min > time.Value)
                {
                    minTimes.Clear();
                    minTimes.Add(time.Key);
                    min = time.Value;
                }

            }
            Console.WriteLine($"Наибольшее количество людей было в пеориоды:");
            foreach (string maxTime in maxTimes)
            {
                Console.WriteLine(maxTime);

            }
            Console.WriteLine($"В количестве: {max} человек");

            Console.WriteLine($"Наименьшее количество людей было в пеориоды:");
            foreach (string minTime in maxTimes)
            {
                Console.WriteLine(minTime);

            }
            Console.WriteLine($"В количестве: {min} человек");

           


        }
    }
}
