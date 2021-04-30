using System;
using System.Linq;
using System.Threading.Tasks;
using WebBluetooth.Data.Repositories.Interfaces;
using WebBluetooth.Data.Models;
using System.Collections.Generic;

namespace WebBluetooth.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }

        public async Task<List<WeatherForecast>> CalculateForecast(DateTime startDate)
        {
            List<WeatherForecast> weatherForecasts = await _weatherForecastRepository.GetForecastAsync(startDate);
            return weatherForecasts;
        }
    }
}