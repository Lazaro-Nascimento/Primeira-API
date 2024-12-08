using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using Microsoft.Extensions.WebEncoders.Testing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using PrimeiraApi_DbContext;

namespace PrimeiraApi_WeatherForecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "WeatherForecast")]
        public List<WeatherForecast> GetTemp()
        {
            int i = 0;

            List<WeatherForecast> list = new List<WeatherForecast>();
//            WeatherForecast teste = new WeatherForecast();
            
           foreach (var item in Summaries) {
                WeatherForecast teste = new WeatherForecast();

                teste.Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1000.99));
                teste.TemperatureC = Random.Shared.Next(1, 100);
                teste.Id = Random.Shared.Next(1, 100);
                teste.Summary = item;
                list.Add(teste);

                i++;
            }
            return list;
        }
        [HttpPut(Name = "WeatherForecast")]
        public void PutTemp(string nameSummary)
        {
            int id = 0;
            //            WeatherForecast teste = new WeatherForecast();

            List<WeatherForecast> l = DbContext.DataBase;
            id = l.FindIndex(l => l.Summary == nameSummary);

            l.
        }
    }
}
