using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class WeatherService
{
    private readonly HttpClient httpClient;
    private const string ApiKey = "15bd09558c514461845200442231806";

    public WeatherService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<List<WeatherRecord>> GetWeatherForecast(string city, int days)
    {
        string apiUrl = $"https://api.weatherapi.com/v1/forecast.json?key={ApiKey}&q={city}&days={days}";

        WeatherResponse response = await httpClient.GetFromJsonAsync<WeatherResponse>(apiUrl);

        if (response != null && response.Forecast != null && response.Forecast.Forecastday != null)
        {
            // Преобразование данных из response в список WeatherRecord
            List<WeatherRecord> weatherRecords = new List<WeatherRecord>();
            foreach (var forecast in response.Forecast.Forecastday)
            {
                if (forecast.Day != null)
                {
                    weatherRecords.Add(new WeatherRecord
                    {
                        Date = DateTime.Parse(forecast.Date),
                        MaxTemperature = forecast.Day.Maxtemp_c,
                        MinTemperature = forecast.Day.Mintemp_c,
                        Description = forecast.Day.Condition?.Text,
                        Precipitation = forecast.Day.Totalprecip_mm,
                        Humidity = forecast.Day.Avghumidity,
                        WindSpeed = forecast.Day.Maxwind_kph
                    });
                }
            }

            return weatherRecords;
        }

        return new List<WeatherRecord>();
    }

    public async Task<List<string>> GetCities()
    {
        return new List<string> { "Москва", "Париж", "Лондон", "Вашингтон", "Канберра" };
    }
}

public class WeatherRecord
{
    public DateTime Date { get; set; }
    public decimal MaxTemperature { get; set; }
    public decimal MinTemperature { get; set; }
    public string Description { get; set; }
    public decimal Precipitation { get; set; }
    public decimal Humidity { get; set; }
    public decimal WindSpeed { get; set; }

}

public class WeatherResponse
{
    public Forecast Forecast { get; set; }
}

public class Forecast
{
    public List<Forecastday> Forecastday { get; set; }
}

public class Forecastday
{
    public string Date { get; set; }
    public Day Day { get; set; }
}

public class Day
{
    public decimal Maxtemp_c { get; set; }
    public decimal Mintemp_c { get; set; }
    public Condition Condition { get; set; }
    public decimal Totalprecip_mm { get; set; }
    public decimal Avghumidity { get; set; }
    public decimal Maxwind_kph { get; set; }
}

public class Condition
{
    public string Text { get; set; }
}