﻿using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using ReactHomePage.Dtos.Weather;
using ReactHomePage.Models;

namespace ReactHomePage.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private IConfiguration configuration;
        private IHttpClientFactory _factory;
        public WeatherController(IConfiguration config, IHttpClientFactory factory)
        {
            configuration = config;
            _factory = factory;
        }

        [HttpGet]
        public async Task<WeatherAndForecast> GetWeather(string city)
        {
            var client = _factory.CreateClient("weather");
            var historicWeatherJson = await client.GetStringAsync($"data/2.5/forecast?q=" + city + "&appid=" + configuration["openWeather"] + "&units=metric");
            var historicWeather = JsonConvert.DeserializeObject<WeatherDto>(historicWeatherJson);

            var currentWeatherJson = await client.GetStringAsync($"data/2.5/weather?q=" + city + "&appid=" + configuration["openWeather"] + "&units=metric");
            var currentWeather = JsonConvert.DeserializeObject<CurrentWeather>(currentWeatherJson);

            return new WeatherAndForecast(currentWeather, historicWeather);
        }
    }
}