using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteorologicalService
{
    public class WeatherRecord
    {
        public string City { get; }
        public DateTime Date { get; }
        public WeatherType Type { get; }
        public double Duration { get; }

        public WeatherRecord(string city, DateTime date, WeatherType type, double duration)
        {
            City = city;
            Date = date;
            Type = type;
            Duration = duration;
        }

        public void PrintRecord()
        {
            Console.WriteLine($"{Date.ToShortDateString()} {City} | Погода: {Type} | Длительность: {Duration} ч.");
        }
    }
}
