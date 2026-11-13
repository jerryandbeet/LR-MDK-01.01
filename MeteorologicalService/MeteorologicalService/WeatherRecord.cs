using System;

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
            Console.WriteLine($"Погода: {Type}\t| Длительность: {Duration} ч.");
        }
    }
}
