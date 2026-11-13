using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteorologicalService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherRecord[] weatherRecords = WeatherFileManager.GetRecords("Weather.csv");
            if (weatherRecords.Length == 0) return;
            Console.Write("Введите название города: ");
            string city = Console.ReadLine();
            Console.Write("\nВведите дату: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            bool recordExists = false;
            double snowTime = 0;
            double windTime = 0;
            double rainTime = 0;
            foreach (var weatherRecord in weatherRecords)
            {
                if (weatherRecord.City.ToLower() == city.ToLower() && weatherRecord.Date == date)
                {
                    switch (weatherRecord.Type)
                    {
                        case WeatherType.Rain:
                            rainTime += weatherRecord.Duration;
                            break;
                        case WeatherType.Snow:
                            snowTime += weatherRecord.Duration;
                            break;
                        case WeatherType.Wind:
                            windTime += weatherRecord.Duration;
                            break;
                    }

                    recordExists = true;
                    
                }
            }
            if (!recordExists)
            {
                Console.WriteLine($"Невозможно получить рекомендацию. Запись о погоде в городе {city} ({date.ToShortDateString()}) не найдена.");
            }
            else
            {
                double percentSnow = (snowTime / 24) * 100;
                double percentWind = (windTime / 24) * 100;
                double percentRain = (rainTime / 24) * 100;
                if (percentWind >= 80)
                {
                    Console.WriteLine("Рекомендация: оcтавайтесь дома!");
                }
                else if (percentRain >= 30 && percentSnow >= 30)
                {
                    Console.WriteLine("Рекомендация: выходите на улицу с зонтиком и в валенках!");
                }
                else if (percentRain >= 30)
                {
                    Console.WriteLine("Рекомендация: не выходите на улицу без зонтика!");
                }
                else if (percentSnow >= 30)
                {
                    Console.WriteLine("Рекомендация: выходите на улицу в валенках!");
                }
                else Console.WriteLine("Рекомендация не найдена!");

            }


        }
    }
}
