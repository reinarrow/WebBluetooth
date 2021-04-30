using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebBluetooth.Data.Models;

namespace WebBluetooth.Services
{
    public interface IWeatherForecastService
    {
        Task<List<WeatherForecast>> CalculateForecast(DateTime startDate);
    }
}