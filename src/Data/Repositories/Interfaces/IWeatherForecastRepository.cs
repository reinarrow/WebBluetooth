using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBluetooth.Data.Models;

namespace WebBluetooth.Data.Repositories.Interfaces
{
    public interface IWeatherForecastRepository
    {
        Task<List<WeatherForecast>> GetForecastAsync(DateTime startDate);
    }
}