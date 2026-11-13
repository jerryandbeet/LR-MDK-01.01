using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;

namespace MeteorologicalService
{
    public static class WeatherFileManager
    {
        public static WeatherRecord[] GetRecords(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                Console.WriteLine("Ошибка: файл прогноза не был найден!!!");
                return new WeatherRecord[0];
            }
            string[] lines = File.ReadAllLines(path);
            WeatherRecord[] weatherRecords = new WeatherRecord[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                //Пример (шаблон) строки из csv файла : "Дождь;Торжок;03.12.2026;12:00-16:00"
                string[] parts = lines[i].Split(';');
                WeatherType type;
                switch (parts[0].ToLower())
                {
                    case "дождь":
                        type = WeatherType.Rain;
                        break;
                    case "снег":
                        type = WeatherType.Snow;
                        break;
                    case "ветер":
                        type = WeatherType.Wind;
                        break;
                    default:
                        type = WeatherType.Unknown;
                        break;
                }
                DateTime date = DateTime.Parse(parts[2]);
                string[] timeParts = parts[3].Split('-');
                TimeSpan start = TimeSpan.Parse(timeParts[0]);
                TimeSpan end = TimeSpan.Parse(timeParts[1]);
                TimeSpan difference = end - start;
                double durationInHours = difference.TotalHours;
                weatherRecords[i] = new WeatherRecord(parts[1], date, type, durationInHours);
            }
            return weatherRecords;

        }
    }
}
